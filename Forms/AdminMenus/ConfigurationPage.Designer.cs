namespace Nescafe.Forms.AdminMenus
{
    partial class ConfigurationPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTerm1 = new TextBox();
            txtTerm2 = new TextBox();
            txtTerm3 = new TextBox();
            txtExchange = new TextBox();
            txtInhouse = new TextBox();
            txtAccross = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 65);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Teminologi 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Terminologi 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(613, 65);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Terminologi 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 287);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 3;
            label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 287);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Inhouse Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 287);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Accross Fee";
            // 
            // txtTerm1
            // 
            txtTerm1.Location = new Point(42, 82);
            txtTerm1.Margin = new Padding(2);
            txtTerm1.Multiline = true;
            txtTerm1.Name = "txtTerm1";
            txtTerm1.Size = new Size(268, 205);
            txtTerm1.TabIndex = 6;
            // 
            // txtTerm2
            // 
            txtTerm2.Location = new Point(329, 82);
            txtTerm2.Margin = new Padding(2);
            txtTerm2.Multiline = true;
            txtTerm2.Name = "txtTerm2";
            txtTerm2.Size = new Size(268, 205);
            txtTerm2.TabIndex = 7;
            // 
            // txtTerm3
            // 
            txtTerm3.Location = new Point(613, 82);
            txtTerm3.Margin = new Padding(2);
            txtTerm3.Multiline = true;
            txtTerm3.Name = "txtTerm3";
            txtTerm3.Size = new Size(268, 205);
            txtTerm3.TabIndex = 8;
            // 
            // txtExchange
            // 
            txtExchange.Location = new Point(42, 311);
            txtExchange.Margin = new Padding(2);
            txtExchange.Name = "txtExchange";
            txtExchange.Size = new Size(268, 23);
            txtExchange.TabIndex = 9;
            // 
            // txtInhouse
            // 
            txtInhouse.Location = new Point(329, 311);
            txtInhouse.Margin = new Padding(2);
            txtInhouse.Name = "txtInhouse";
            txtInhouse.Size = new Size(268, 23);
            txtInhouse.TabIndex = 10;
            // 
            // txtAccross
            // 
            txtAccross.Location = new Point(613, 311);
            txtAccross.Margin = new Padding(2);
            txtAccross.Name = "txtAccross";
            txtAccross.Size = new Size(268, 23);
            txtAccross.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(399, 347);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 24);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // ConfigurationPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(txtAccross);
            Controls.Add(txtInhouse);
            Controls.Add(txtExchange);
            Controls.Add(txtTerm3);
            Controls.Add(txtTerm2);
            Controls.Add(txtTerm1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ConfigurationPage";
            Size = new Size(950, 450);
            Load += ConfigurationPage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTerm1;
        private TextBox txtTerm2;
        private TextBox txtTerm3;
        private TextBox txtExchange;
        private TextBox txtInhouse;
        private TextBox txtAccross;
        private Button btnUpdate;
    }
}
