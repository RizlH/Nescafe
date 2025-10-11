using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nescafe.Models;


namespace Nescafe.Forms
{
    public partial class LoginForm : Form
    {
        public Member? LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        public void SetSuccessAlert(string message)
        {
            labelSuccess.Text = message;
            labelSuccess.Visible = true;
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelSuccess.Visible = false;

            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var user = await auth.LoginAsync(textUsername.Text, textPassword.Text);

            if (user != null)
            {
                LoggedInUser = user;

                if (LoggedInUser.level == "admin")
                {
                    this.Hide();
                    var adminForm = new AdminForm(LoggedInUser);
                    adminForm.ShowDialog();
                }
                else
                {
                    AccessService accessService = new AccessService(db);
                    var access = await accessService.GetAccess(user.Id);

                    if (access == null)
                    {
                        labelSuccess.Text = "Access Is Not Granted By Admin!";
                        labelSuccess.ForeColor = Color.Red;
                        labelSuccess.Visible = true;
                        return;
                    }

                    this.Hide();
                    var homeForm = new HomeForm(LoggedInUser);
                    homeForm.ShowDialog();
                }
            }
            else
            {
                labelSuccess.Text = "Invalid Credentials";
                labelSuccess.ForeColor = Color.Red;
                labelSuccess.Visible = true;
            }
        }

        private void LinkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.ShowDialog();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm form = new RegistrationForm();
            form.ShowDialog();
        }


    }
}