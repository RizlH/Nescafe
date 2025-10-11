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


namespace Nescafe.Forms
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }
        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            var auth = new AuthService(db); //EAIc1B
            var password = await auth.ResetPasswordAsync(textUsername.Text, textQuest1.Text, textQuest2.Text);
            if (password == "")
            {
                MessageBox.Show("Invalid username or the answer", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                textPassword.Text = password;
            }
        }

    }
}
