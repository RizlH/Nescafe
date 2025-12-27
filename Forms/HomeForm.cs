using Nescafe.Api.Connectors;
using Nescafe.Api.Models;
using Nescafe.Data;
using Nescafe.Forms.MemberMenus;
using Nescafe.Forms.PublicMenus;
using Nescafe.Models;
using Nescafe.Services;

namespace Nescafe.Forms
{
    public partial class HomeForm : Form
    {
        Member loggedMember;
        string title;
        private System.Threading.Timer? balanceTimer;
        private bool isSyncRunning = false;
        public HomeForm(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = this.Text + " - User: " + loggedMember.FullName + " (" + loggedMember.MemberId + ")";
            title = this.Text;
            route(new DashboardPage(member));
        }

        public void route(System.Windows.Forms.Control control)
        {
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(control);
        }

        public void autoDisableMenu()
        {
            loanToolStripMenuItem.Enabled = false;
            savingToolStripMenuItem.Enabled = false;
            transferToolStripMenuItem.Enabled = false;
            exchangeToolStripMenuItem.Enabled = false;
            inhouseToolStripMenuItem.Enabled = false;
            acrossCooperationToolStripMenuItem.Enabled = false;

            loanToolStripMenuItem.ToolTipText = "Disabled";
            savingToolStripMenuItem.ToolTipText = "Disabled";
            transferToolStripMenuItem.ToolTipText = "Disabled";
            exchangeToolStripMenuItem.ToolTipText = "Disabled";
            inhouseToolStripMenuItem.ToolTipText = "Disabled";
            acrossCooperationToolStripMenuItem.ToolTipText = "Disabled";
        }

        public void grantAllMenu()
        {
            loanToolStripMenuItem.Enabled = true;
            savingToolStripMenuItem.Enabled = true;
            transferToolStripMenuItem.Enabled = true;
            exchangeToolStripMenuItem.Enabled = true;
            inhouseToolStripMenuItem.Enabled = true;
            acrossCooperationToolStripMenuItem.Enabled = true;
        }

        public void grantAccess()
        {
            AppDbContext db = new AppDbContext();
            AccessService accessService = new AccessService(db);
            Access? access = accessService.findByMember(loggedMember.Id);
            if (access != null)
            {
                var listAccess = access.AccessList.Split(",");

                for (int i = 0; i < listAccess.Length; i++)
                {
                    var accessName = listAccess[i];
                    var accessSegment = accessName.Trim();

                    if (accessSegment == "Grant All")
                    {
                        grantAllMenu();
                        break;
                    }

                    if (accessSegment.Contains("-"))
                    {
                        var parts = accessSegment.Split("-");
                        if (parts.Length > 1)
                            accessSegment = parts[1].Trim();
                    }

                    foreach (ToolStripMenuItem menu in menuHome.Items)
                    {
                        if (menu.Text != null && menu.Text.Contains(accessSegment))
                        {
                            menu.Enabled = true;
                            menu.ToolTipText = "";
                        }
                        else
                        {
                            foreach (ToolStripMenuItem submenu in menu.DropDownItems)
                            {
                                if (submenu.Text != null && submenu.Text.Contains(accessSegment))
                                {
                                    submenu.Enabled = true;
                                    submenu.ToolTipText = "";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void definitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new TerminologiPage(loggedMember));
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            autoDisableMenu();
            grantAccess();
            //StartBackgroundScheduler();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title;
            route(new DashboardPage(loggedMember));
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Profile Page >>";
            route(new ProfilePage(loggedMember));
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Loan Page >>";
            route(new LoanPage(loggedMember));
        }

        private void acrossCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Across Transfer Page >>";
            route(new AcrossTransferPage(loggedMember));
        }

        //private void StartBackgroundScheduler()
        //{
        //    if (isSyncRunning) return;

        //    // Timer jalan tiap 3 detik (3000 ms)
        //    balanceTimer = new System.Threading.Timer(async _ => await SyncBalanceAsync(), null, 0, 3000);
        //    isSyncRunning = true;
        //}

        private void StopBackgroundScheduler()
        {
            balanceTimer?.Dispose();
            isSyncRunning = false;
        }

        //private async Task SyncBalanceAsync()
        //{
        //    try
        //    {
        //        AppDbContext db = new AppDbContext();
        //        BalanceService balanceService = new BalanceService(db);
        //        Balance? balance = await balanceService.getBalance(loggedMember.MemberId);
        //        if (balance != null)
        //        {
        //            Console.WriteLine($"Syncing balance for member {loggedMember.MemberId}: {balance.Amount}");
        //            ConnectorPost connector = new ConnectorPost();
        //            BalanceApiResponse? response = await connector.BalanceUpdateAsync(new BalancePayload
        //            {
        //                amount = Double.Parse(balance.Amount.ToString()),
        //                memberCode = loggedMember.MemberId
        //            });
        //            if (response != null && response.ResponseCode == "00")
        //            {
        //                Console.WriteLine($"Balance sync successful for member {loggedMember.MemberId}");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Balance sync failed for member {loggedMember.MemberId}: {response?.ResponseMessage}");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error sync:" + ex.Message);
        //    }
        //}

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Exchange Transfer Page >>";
            route(new ExchangePage(loggedMember));
        }
    }
}
