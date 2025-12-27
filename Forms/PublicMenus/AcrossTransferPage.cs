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

namespace Nescafe.Forms.MemberMenus
{
    public partial class AcrossTransferPage : UserControl
    {
        Member loggedMember;
        public AcrossTransferPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void AcrossTransferPage_Load(object sender, EventArgs e)
        {
            timerInbox.Enabled = false;
            if (loggedMember.ReferenceId == null || loggedMember.ReferenceId == "" || loggedMember.ReferenceId == "-")
            {
                DialogResult result = MessageBox.Show(
                    "You do not have a privilege to Use Across Transfer. Registration Now?", 
                    "Invalid", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    String message;
                    using (var db = new AppDbContext())
                    {
                        message = await MemberRegistration(db);
                    }
                    textBalance.Text = "0";
                   labelMyBenef.Text = "My Benef: " + loadMyBenef();
                    MessageBox.Show(message, "Registration Info", MessageBoxButtons.OK);
                }
            } else
            {
                var db = new AppDbContext();
                BalanceService balanceService = new BalanceService(db);
                Balance? balance = await balanceService.getBalance(loggedMember.MemberId);
                if (balance != null)
                {
                    textBalance.Text = balance.Amount.ToString();
                }

                labelMyBenef.Text = "My Benef: " + loadMyBenef();
                timerInbox.Enabled = true;
            }
        }

        private async Task<String> MemberRegistration(AppDbContext db)
        {
            String message = "Succes";
            MemberService memberService = new MemberService(db);
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationService configurationService = new ConfigurationService(db);
            Configuration? configuration = await configurationService.GetConfig();
            if (configuration == null)
                message = "Configuration not found!";

            if (configuration != null)
            {
                if (configuration.terminologi3 == null || configuration.terminologi3 == "-")
                {
                    message = "Coop not registered to Across System. Please contact administrator.";
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

                        timerInbox.Enabled = true;
                    }
                    else
                    {
                        message = "Failed to register member to across system: " + memberApiResponse?.ResponseMessage;
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;

                }
            }
            return message;
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config = await configService.GetConfig();
            ConnectorPost connectorPost = new ConnectorPost();
            Double transferAmount = Double.Parse(textAmount.Text);

            TransferApiResponse? response = await connectorPost.TransferAsync(new TransferPayload
            {
                amount = transferAmount,
                benefCode = textBenef.Text,
                coopCode = loggedMember.ReferenceId,
                memberCode = loggedMember.MemberId,
                fee = Double.Parse(config?.transferAcrossFee.ToString()),
                remarks = textRemarks.Text,
                transferRef = textTransRef.Text,
            });

            if (response != null && response.ResponseCode == "00")
            {
                BalanceService balanceService = new BalanceService(db);
                Balance? balance = await balanceService.getBalance(loggedMember.MemberId);
                if (balance != null)
                {
                    balance.Amount -= Decimal.Parse(transferAmount.ToString());
                    balance.UpdateOn = DateTime.UtcNow;
                    balance.TransactionName = "Across Transfer";
                    balance.Flow = "OUT";
                    balanceService.Update(balance);

                    textBalance.Text = balance.Amount.ToString();

                    BalanceApiResponse? balanceApiResponse = await connectorPost.BalanceUpdateAsync(new BalancePayload
                    {
                        amount = Double.Parse(balance.Amount.ToString()),
                        memberCode = loggedMember.MemberId,
                    });

                    if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
                    {
                        MessageBox.Show("Transfer Successful", "Success");
                    }
                }
            }
        }

        private async void timerInbox_Tick(object sender, EventArgs e)
        {
            timerInbox.Stop();
            try
            {
                //timerInbox.Start();
                Console.WriteLine("Retrieving...");
                ConnectorGet connectorGet = new ConnectorGet(); 
                TransferApiResponse? responseOutgoing = await connectorGet.GetOutgoingByMemberAsync(loggedMember.MemberId);
                if (responseOutgoing != null && responseOutgoing.ResponseCode == "00")
                {
                    dgvOutgoing.DataSource = responseOutgoing.TransferList;
                    dgvOutgoing.Columns["Id"].Visible = false;
                    dgvOutgoing.Columns["MemberCode"].Visible = false;
                    dgvOutgoing.Columns["BenefCode"].HeaderText = "Beneficiary";
                    dgvOutgoing.Columns["CoopCode"].Visible = false;
                    dgvOutgoing.Columns["updateOn"].Visible = false;
                    dgvOutgoing.Columns["TransferRef"].HeaderText = "Reference";
                    dgvOutgoing.Columns["TransferDate"].HeaderText = "Date";
                    dgvOutgoing.Columns["Amount"].HeaderText = "Amount";
                    dgvOutgoing.Columns["Fee"].HeaderText = "Fee";
                    dgvOutgoing.Columns["Remarks"].HeaderText = "Remarks";
                    dgvOutgoing.Columns["TransactionCode"].HeaderText = "Transaction Code";
                }
                String benefCode = loggedMember.ReferenceId + "-" + loggedMember.MemberId;
                TransferApiResponse? responseIncoming = await connectorGet.GetIncomingByMemberAsync(loggedMember.MemberId);
                if (responseIncoming != null && responseIncoming.ResponseCode == "00")
                {
                    dgvIncoming.Columns["Id"].Visible = false;
                    dgvIncoming.Columns["MemberCode"].HeaderText = "Member Code";
                    dgvIncoming.Columns["BenefCode"].Visible = false;
                    dgvIncoming.Columns["CoopCode"].HeaderText = "Coop Code";
                    dgvIncoming.Columns["updateOn"].Visible = false;
                    dgvIncoming.Columns["TransferRef"].HeaderText = "Reference";
                    dgvIncoming.Columns["TransferDate"].HeaderText = "Date";
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
                timerInbox.Start(); // restart setelah selesai
            }
        }

        private String loadMyBenef()
        {
            return loggedMember.ReferenceId + "-" + loggedMember.MemberId;
        }
    }
}
