using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nescafe.Forms;
using Nescafe.Services;
using Nescafe.Data;

namespace Nescafe
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db);
            var member = auth.RegisterAsync(txtAddress.Text, txtCardId.Text, txtEmail.Text, txtFullName.Text, txtPassword.Text, txtPhone.Text, txtPhoneAlt.Text, txtReferenceId.Text, txtUsername.Text, txtQuest1.Text, txtQuest2.Text);

            if (member != null) {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.SetSuccessAlert("Registration Success! Please Login...");
                loginForm.ShowDialog();
            } else {
                labelError.Text = "Registration Failed!";
                labelError.Visible = true;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}

