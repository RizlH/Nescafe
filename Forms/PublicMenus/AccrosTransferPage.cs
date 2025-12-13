using Nescafe.Api.Connectors;
using Nescafe.Api.Models;
using Nescafe.Data;
using Nescafe.Models;
using Nescafe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nescafe.Forms.PublicMenus
{
    public partial class AccrosTransferPage : UserControl
    {
        Member loggedMember;
        public AccrosTransferPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void AccrosTransferPage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (loggedMember.ReferenceId == null || loggedMember.ReferenceId == "" || loggedMember.ReferenceId == "--")
            {
                DialogResult result = MessageBox.Show("You do not have a privilege to Use Across Transfer. Registration Now?", "Invalid", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string message;
                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }
                    MessageBox.Show(message, "Registration Info", MessageBoxButtons.OK);
                }
                else
                {
                    timerInbox.Enabled = true;
                }
            }
        }

        private async Task<String> MemberRegistration(AppDbContext db)
        {
            String message = "Success";
            MemberService memberService = new MemberService(db);
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationService configurationService = new ConfigurationService(db);
            Configuration? configuration = await configurationService.GetConfig();
            if (configuration != null)
                message = "Configuration not found!";

            if (configuration != null)
            {
                if (configuration.terminologi3 == null || configuration.terminologi3 == "-")
                {
                    message = "Coop not registered to Acroos System. Please contact administrator";
                }
                try
                {
                    MemberApiResponse? memberApiResponse = await connectorPost.MemberRegistrationAsync(
                        new MemberPayload
                        {
                            name = loggedMember.FullName,
                            address = loggedMember.Address,
                            code = loggedMember.MemberId,
                            coopCode = configuration.terminologi3!
                        });

                    if (memberApiResponse != null && memberApiResponse.ResponseCode == "00")
                    {
                        loggedMember.ReferenceId = configuration.terminologi3!;
                        memberService.Update(loggedMember);

                        BalanceService balanceService = new BalanceService(db);
                        balanceService.setBalance(loggedMember.MemberId);

                        timer1.Enabled = true;
                    }
                    else
                    {
                        message = "Failed to Register member to across system: " + memberApiResponse?.ResponseMessage;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                return message;
            }
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config = await configService.GetConfig();
            ConnectorPost connectorPost = new ConnectorPost();

            double transferAmount = Double.Parse(txtAmount.Text);

            TransferPayload payload = new TransferPayload
            {
                amount = transferAmount,
                benefCode = txtBeneficiary.Text,
                coopCode = loggedMember.ReferenceId,
                memberCode = loggedMember.MemberId,
                fee = Double.Parse(config?.transferAcrossFee.ToString() ?? "0"),
                remarks = txtRemarks.Text,
                transferRef = txtTransRef.Text
            };

            TransferApiResponse? response = await connectorPost.TransferAsync(payload);

            if (response != null && response.ResponseCode == "00")
            {
                BalanceService balanceService = new BalanceService(db);
                Balance? balance = await balanceService.getBalance(loggedMember.MemberId);

                if (balance != null)
                {
                    balance.amount -= Decimal.Parse(transferAmount.ToString());
                    balance.updateOn = DateTime.Now;
                    balance.transactionName = "Across Transfer";
                    balance.flow = "OUT";
                    balanceService.Update(balance);
                }

                BalancePayload balancePayload = new BalancePayload
                {
                    amount = Double.Parse(balance.amount.ToString()),
                    memberCode = loggedMember.MemberId
                };

                BalanceApiResponse? balanceApiResponse = await connectorPost.BalanceUpdateAsync(balancePayload);

                if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
                {
                    MessageBox.Show("Transfer Successful", "Success");
                }
            }
        }


        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            try
            {
                Console.WriteLine("Retrieving...");

                ConnectorGet connectorGet = new ConnectorGet();
                TransferApiResponse? responseOutgoing = await connectorGet.GetOutgoingByMemberAsync(loggedMember.MemberId);

                if (responseOutgoing != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvOutgoing.DataSource = responseOutgoing.TransferList;
                    dgvOutgoing.Columns["id"].Visible = false;
                    dgvOutgoing.Columns["BenefCode"].HeaderText = "Beneficiary";
                    dgvOutgoing.Columns["coopCode"].Visible = false;
                    dgvOutgoing.Columns["updateOn"].Visible = false;
                    dgvOutgoing.Columns["transferRef"].HeaderText = "Reference";
                    dgvOutgoing.Columns["transferDate"].HeaderText = "Date";
                    dgvOutgoing.Columns["Amount"].HeaderText = "Amount";
                    dgvOutgoing.Columns["Fee"].HeaderText = "Fee";
                    dgvOutgoing.Columns["Remarks"].HeaderText = "Remarks";
                    dgvOutgoing.Columns["TransactionCode"].HeaderText = "Transaction Code";
                }

                string benefCode = loggedMember.ReferenceId + "-" + loggedMember.MemberId;
                TransferApiResponse? responseIncoming = await connectorGet.GetIncomingByMemberAsync(loggedMember.MemberId);

                if (responseIncoming != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvIncoming.Columns["id"].Visible = false;
                    dgvIncoming.Columns["MemberCode"].HeaderText = "Member Code";
                    dgvIncoming.Columns["BenefCode"].Visible = false;
                    dgvIncoming.Columns["transferRef"].HeaderText = "Reference";
                    dgvIncoming.Columns["Amount"].HeaderText = "Amount";
                    dgvIncoming.Columns["Fee"].HeaderText = "Fee";
                    dgvIncoming.Columns["Remarks"].HeaderText = "Remarks";
                    dgvIncoming.Columns["TransactionCode"].HeaderText = "Transaction Code";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                timer1.Start(); // restart setelah selesai
            }
        }
    }
}
