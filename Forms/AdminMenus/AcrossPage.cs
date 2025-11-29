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

namespace Nescafe.Forms.AdminMenus
{
    public partial class AcrossPage : UserControl
    {
        public AcrossPage()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void AcrossPage_Load(object sender, EventArgs e)
        {
            String message = "";
            AppDbContext db = new AppDbContext();
            ConnectorPost connectorPost = new ConnectorPost();
            ConfigurationService configurationService = new ConfigurationService(db);
            Configuration? configuration = await configurationService.GetConfig();
            if (configuration == null)
                message = "Configuration not found!";

            if (configuration != null)
            {
                if (configuration.terminologi3 == null || configuration.terminologi3 == "-")
                {
                    DialogResult result = MessageBox.Show("Not registered yet. Register Now!",
                        "Regist Across", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        CoopApiResponse? coopApiResponse = await connectorPost.CoopRegistrationAsync(
                            new CoopPayload
                            {
                                name = "Nescafe",
                                address = "Sumur Pacing", code = ""
                            });

                        if (coopApiResponse != null && coopApiResponse.CoopCode != null) {
                            configuration.terminologi3 = coopApiResponse.CoopCode;
                            configurationService.Update(configuration);

                            LoadData();
                        } else {
                            message = "Failed to register coop to across system: " + coopApiResponse?.ResponseMessage;
                        }
                    }
                } else {
                    LoadData();
                }
            }
        }

        private async void LoadData()
        {
            AppDbContext appDbContext = new AppDbContext();
            ConfigurationService configurationService = new ConfigurationService(appDbContext);
            Configuration? configuration = await configurationService.GetConfig();

            String message = "";

            ConnectorGet connectorGet = new ConnectorGet();
            CoopApiResponse? coopApiResponse = await connectorGet.GetCoopAsync();
            if (coopApiResponse != null && coopApiResponse.ResponseCode == "00")
            {
                dgvCoop.Rows.Clear();
                foreach (var coop in coopApiResponse.CoopList)
                {
                    dgvCoop.Rows.Add(coop.Code, coop.Name, coop.Address);
                }
            }
            else
            {
                message = coopApiResponse != null ? coopApiResponse.ResponseCode + " - "
                    + coopApiResponse.ResponseMessage : "Did not get data";
            }

            BalanceApiResponse? balanceApiResponse = await connectorGet.GetBalancesByCoopAsync(configuration.terminologi3);
            if (balanceApiResponse != null && balanceApiResponse.ResponseCode == "00")
            {
                dgvBalance.Rows.Clear();
                foreach (var balance in balanceApiResponse.BalanceList)
                {
                    dgvBalance.Rows.Add(balance.Member.Code, balance.Member.Name, balance.Amount);
                }
            }
            else
            {
                message = balanceApiResponse != null ? balanceApiResponse.ResponseCode + " - "
                    + balanceApiResponse.ResponseMessage : "Did not get data";
            }

            TransferApiResponse? transferApiResponse = await connectorGet.GetTransfersByCoopAsync(configuration.terminologi3);
            if (transferApiResponse != null && transferApiResponse.ResponseCode == "00")
            {
                dgvTransfer.Rows.Clear();
                foreach (var transfer in transferApiResponse.TransferList)
                {
                    dgvTransfer.Rows.Add(transfer.Code, transfer.CoopCode, transfer.CodeOrigin, transfer.CodeBenef, transfer.Amount, transfer.Remarks);
                }
            }
            else
            {
                message = transferApiResponse != null ? transferApiResponse.ResponseCode + " - "
                    + transferApiResponse.ResponseMessage : "Did not get data";
            }

            if (message != "")
            {
                MessageBox.Show("Failed to load data from API.\n Error: " + message);
            }
        }
    }
}