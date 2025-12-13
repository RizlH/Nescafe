using Nescafe.Models;
using Nescafe.Forms.PublicMenus;
using Nescafe.Forms.AdminMenus;
using Nescafe.Data;
using Nescafe.Services;
using Nescafe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nescafe.Forms
{
    public partial class HomeForm : Form
    {
        Member? loggedMember;
        string title;
        public HomeForm(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = this.Text + " -- User: " + loggedMember.FullName + " {" + loggedMember.MemberId + "}";
            this.title = this.Text;
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
            //inhouseToolStripMenuItem.Enabled = false;
            //acrossCooperationToolStripMenuItem.Enabled = false;
            //definitionsToolStripMenuItem.Enabled = false;
            // manualToolStripMenuItem.Enabled = false;
            fileToolStripMenuItem.Enabled = false;
            dashboardToolStripMenuItem.Enabled = false;
            profileToolStripMenuItem.Enabled = false;

            loanToolStripMenuItem.ToolTipText = "Disabled";
            savingToolStripMenuItem.ToolTipText = "Disabled";
            //  inhouseToolStripMenuItem.ToolTipText = "Disabled";
            //   acrossCooperationToolStripMenuItem.ToolTipText = "Disabled";
        }

        public void grantAllMenu()
        {
            loanToolStripMenuItem.Enabled = true;
            savingToolStripMenuItem.Enabled = true;
            //  inhouseToolStripMenuItem.Enabled = true;
            //  acrossCooperationToolStripMenuItem.Enabled = true;
        }

        public void grantAccess()
        {
            AppDbContext db = new AppDbContext();
            AccessService accessService = new AccessService(db);
            Access? access = accessService.findByMember(loggedMember.Id);
            if (access != null)
            {
                var listAccess = access.AccessList.Split(',');

                for (int i = 0; i < listAccess.Length; i++)
                {
                    var accessName = listAccess[i];
                    var accessSegment = accessName.Trim();

                    if (accessSegment == "Grant All")
                    {
                        grantAllMenu();
                        break;
                    }

                    if (accessSegment.Contains("::"))
                    {
                        var parts = accessSegment.Split("::");
                        if (parts.Length > 1)
                        {
                            accessSegment = parts[1].Trim();
                        }
                    }

                    //foreach (ToolStripMenuItem menu in menuItem.Items)
                    //{
                    //    if (menu.Text != null && menu.Text.Contains(accessSegment))
                    //    {
                    //        menu.Enabled = true;
                    //        menu.ToolTipText = "";
                    //    }
                    //    else
                    //    {
                    //        foreach (ToolStripMenuItem submenu in menu.DropDownItems)
                    //        {
                    //            if (submenu.Text != null && submenu.Text.Contains(accessSegment))
                    //            {
                    //                submenu.Enabled = true;
                    //                submenu.ToolTipText = "";
                    //            }
                    //        }
                    //    }
                    //}
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
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            var loginForm = new LoginForm();
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
            //route(new ProfilePage(loggedMember));
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Loan Page >>";
            route(new LoanPage(loggedMember));
        }

        private void terminologiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = title + " << Exchange Transfer Page >> ";
            route(new ExhangePage(loggedMember));
        }
    }
}

