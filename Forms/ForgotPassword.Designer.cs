namespace Nescafe.Forms
{
    partial class ForgotPassword
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
            textUsername = new TextBox();
            textQuest1 = new TextBox();
            label2 = new Label();
            buttonSubmit = new Button();
            buttonBack = new Button();
            textQuest2 = new TextBox();
            label3 = new Label();
            textPassword = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 70);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Username :";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(63, 98);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(330, 31);
            textUsername.TabIndex = 1;
            // 
            // textQuest1
            // 
            textQuest1.Location = new Point(63, 202);
            textQuest1.Name = "textQuest1";
            textQuest1.Size = new Size(330, 31);
            textQuest1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 174);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 2;
            label2.Text = "What Is Your Favorite Color?";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(78, 252);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(112, 34);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(206, 252);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(112, 34);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // textQuest2
            // 
            textQuest2.Location = new Point(452, 202);
            textQuest2.Name = "textQuest2";
            textQuest2.Size = new Size(319, 31);
            textQuest2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(452, 174);
            label3.Name = "label3";
            label3.Size = new Size(255, 25);
            label3.TabIndex = 8;
            label3.Text = "What Is Your Fav Artist/Singer?";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(63, 345);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(330, 31);
            textPassword.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 317);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 10;
            label4.Text = "Password :";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(845, 452);
            Controls.Add(textPassword);
            Controls.Add(label4);
            Controls.Add(textQuest2);
            Controls.Add(label3);
            Controls.Add(buttonBack);
            Controls.Add(buttonSubmit);
            Controls.Add(textQuest1);
            Controls.Add(label2);
            Controls.Add(textUsername);
            Controls.Add(label1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            Load += ForgotPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textUsername;
        private TextBox textQuest1;
        private Label label2;
        private Button buttonSubmit;
        private Button buttonBack;
        private TextBox textQuest2;
        private Label label3;
        private TextBox textPassword;
        private Label label4;
    }
}