namespace Nescafe.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            labelSuccess = new Label();
            LinkForgotPassword = new LinkLabel();
            buttonSubmit = new Button();
            buttonRegistration = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(563, 96);
            label1.Name = "label1";
            label1.Size = new Size(87, 30);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(434, 141);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(434, 218);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(434, 164);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(311, 23);
            textUsername.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(434, 241);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(311, 23);
            textPassword.TabIndex = 4;
            // 
            // labelSuccess
            // 
            labelSuccess.AutoSize = true;
            labelSuccess.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuccess.Location = new Point(434, 38);
            labelSuccess.Name = "labelSuccess";
            labelSuccess.Size = new Size(25, 20);
            labelSuccess.TabIndex = 5;
            labelSuccess.Text = "....";
            // 
            // LinkForgotPassword
            // 
            LinkForgotPassword.AutoSize = true;
            LinkForgotPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkForgotPassword.Location = new Point(638, 339);
            LinkForgotPassword.Name = "LinkForgotPassword";
            LinkForgotPassword.Size = new Size(107, 17);
            LinkForgotPassword.TabIndex = 6;
            LinkForgotPassword.TabStop = true;
            LinkForgotPassword.Text = "Forgot Password";
            LinkForgotPassword.LinkClicked += LinkForgotPassword_LinkClicked;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(434, 293);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(86, 35);
            buttonSubmit.TabIndex = 7;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistration.Location = new Point(434, 378);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(108, 35);
            buttonRegistration.TabIndex = 8;
            buttonRegistration.Text = "Registration";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegistration);
            Controls.Add(buttonSubmit);
            Controls.Add(LinkForgotPassword);
            Controls.Add(labelSuccess);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label labelSuccess;
        private LinkLabel LinkForgotPassword;
        private Button buttonSubmit;
        private Button buttonRegistration;
    }
}