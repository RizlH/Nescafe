namespace Nescafe.Forms.PublicMenus
{
    partial class AccrosTransferPage
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
            components = new System.ComponentModel.Container();
            timerInbox = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            txtBalance = new TextBox();
            label2 = new Label();
            txtBeneficiary = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAmount = new TextBox();
            txtTransRef = new TextBox();
            txtRemarks = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            label6 = new Label();
            label7 = new Label();
            dgvIncoming = new DataGridView();
            dgvOutgoing = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(13, 28);
            txtBalance.Margin = new Padding(2, 2, 2, 2);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(197, 23);
            txtBalance.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Beneficiary";
            // 
            // txtBeneficiary
            // 
            txtBeneficiary.Location = new Point(13, 74);
            txtBeneficiary.Margin = new Padding(2, 2, 2, 2);
            txtBeneficiary.Name = "txtBeneficiary";
            txtBeneficiary.Size = new Size(197, 23);
            txtBeneficiary.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 149);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "Transfer Ref";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 193);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 6;
            label5.Text = "Remarks";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(13, 118);
            txtAmount.Margin = new Padding(2, 2, 2, 2);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(197, 23);
            txtAmount.TabIndex = 7;
            // 
            // txtTransRef
            // 
            txtTransRef.Location = new Point(13, 166);
            txtTransRef.Margin = new Padding(2, 2, 2, 2);
            txtTransRef.Name = "txtTransRef";
            txtTransRef.Size = new Size(197, 23);
            txtTransRef.TabIndex = 8;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(13, 210);
            txtRemarks.Margin = new Padding(2, 2, 2, 2);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(197, 53);
            txtRemarks.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(13, 275);
            btnSubmit.Margin = new Padding(2, 2, 2, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(78, 20);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(130, 275);
            btnClear.Margin = new Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 20);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 11);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 12;
            label6.Text = "Incoming";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(330, 169);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Outgoing";
            // 
            // dgvIncoming
            // 
            dgvIncoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncoming.Location = new Point(330, 28);
            dgvIncoming.Margin = new Padding(2, 2, 2, 2);
            dgvIncoming.Name = "dgvIncoming";
            dgvIncoming.RowHeadersWidth = 62;
            dgvIncoming.Size = new Size(305, 135);
            dgvIncoming.TabIndex = 14;
            // 
            // dgvOutgoing
            // 
            dgvOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutgoing.Location = new Point(330, 193);
            dgvOutgoing.Margin = new Padding(2, 2, 2, 2);
            dgvOutgoing.Name = "dgvOutgoing";
            dgvOutgoing.RowHeadersWidth = 62;
            dgvOutgoing.Size = new Size(305, 135);
            dgvOutgoing.TabIndex = 15;
            // 
            // AccrosTransferPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvOutgoing);
            Controls.Add(dgvIncoming);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtRemarks);
            Controls.Add(txtTransRef);
            Controls.Add(txtAmount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBeneficiary);
            Controls.Add(label2);
            Controls.Add(txtBalance);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AccrosTransferPage";
            Size = new Size(666, 360);
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerInbox;
        private Label label1;
        private TextBox txtBalance;
        private Label label2;
        private TextBox txtBeneficiary;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAmount;
        private TextBox txtTransRef;
        private TextBox txtRemarks;
        private Button btnSubmit;
        private Button btnClear;
        private Label label6;
        private Label label7;
        private DataGridView dgvIncoming;
        private DataGridView dgvOutgoing;
    }
}
