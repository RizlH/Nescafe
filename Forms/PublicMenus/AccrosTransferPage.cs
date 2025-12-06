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
        public AccrosTransferPage()
        {
            InitializeComponent();
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
    }
}