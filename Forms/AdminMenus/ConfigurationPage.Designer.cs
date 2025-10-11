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
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Teminologi 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 37);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 1;
            label2.Text = "Terminologi 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(860, 37);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 2;
            label3.Text = "Terminologi 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 407);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 3;
            label4.Text = "Exchange Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 407);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 4;
            label5.Text = "Inhouse Fee";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(860, 407);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 5;
            label6.Text = "Accross Fee";
            // 
            // txtTerm1
            // 
            txtTerm1.Location = new Point(44, 65);
            txtTerm1.Multiline = true;
            txtTerm1.Name = "txtTerm1";
            txtTerm1.Size = new Size(381, 339);
            txtTerm1.TabIndex = 6;
            // 
            // txtTerm2
            // 
            txtTerm2.Location = new Point(454, 65);
            txtTerm2.Multiline = true;
            txtTerm2.Name = "txtTerm2";
            txtTerm2.Size = new Size(381, 339);
            txtTerm2.TabIndex = 7;
            // 
            // txtTerm3
            // 
            txtTerm3.Location = new Point(860, 65);
            txtTerm3.Multiline = true;
            txtTerm3.Name = "txtTerm3";
            txtTerm3.Size = new Size(381, 339);
            txtTerm3.TabIndex = 8;
            // 
            // txtExchange
            // 
            txtExchange.Location = new Point(44, 447);
            txtExchange.Name = "txtExchange";
            txtExchange.Size = new Size(381, 31);
            txtExchange.TabIndex = 9;
            // 
            // txtInhouse
            // 
            txtInhouse.Location = new Point(454, 447);
            txtInhouse.Name = "txtInhouse";
            txtInhouse.Size = new Size(381, 31);
            txtInhouse.TabIndex = 10;
            // 
            // txtAccross
            // 
            txtAccross.Location = new Point(860, 447);
            txtAccross.Name = "txtAccross";
            txtAccross.Size = new Size(381, 31);
            txtAccross.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(554, 507);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ConfigurationPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Name = "ConfigurationPage";
            Size = new Size(1260, 579);
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
