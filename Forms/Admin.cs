using Nescafe.Forms.AdminMenus;
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
    public partial class Admin : Form
    {
        Member? loggedMember = null;
        public Admin(Member member)
        {
            loggedMember = member;
            InitializeComponent();
            this.Text = "Nescafe (Administrator: " +
                loggedMember.MemberId + "-" + loggedMember.FullName + ")";
        }
        public void route(Control control)
        {
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Add(control);
        }
        private void Admin_Load(Object sender, EventArgs e)
        {
            route(new DashboardAdminPage(loggedMember));
        }
        private void accessToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            route(new AccesPage(loggedMember));
        }
        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ConfigurationPage());
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loggedMember = null;
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new MemberPage());
        }
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            route(new ProductPage());
        }
        private void acrossCooperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // route(new AccrossPage());
        }
        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  route(new ApprovalPage(loggedMember));
        }

    }
}
