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
            timer1 = new System.Windows.Forms.Timer(components);
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
            dataGridViewIncom = new DataGridView();
            dataGridViewOutgoing = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutgoing).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Balance";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(18, 46);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(280, 31);
            txtBalance.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 95);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 2;
            label2.Text = "Beneficiary";
            // 
            // txtBeneficiary
            // 
            txtBeneficiary.Location = new Point(18, 123);
            txtBeneficiary.Name = "txtBeneficiary";
            txtBeneficiary.Size = new Size(280, 31);
            txtBeneficiary.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 169);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 248);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 5;
            label4.Text = "Transfer Ref";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 322);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 6;
            label5.Text = "Remarks";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(18, 197);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(280, 31);
            txtAmount.TabIndex = 7;
            // 
            // txtTransRef
            // 
            txtTransRef.Location = new Point(18, 276);
            txtTransRef.Name = "txtTransRef";
            txtTransRef.Size = new Size(280, 31);
            txtTransRef.TabIndex = 8;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new Point(18, 350);
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(280, 86);
            txtRemarks.TabIndex = 9;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(18, 458);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(186, 458);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 18);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 12;
            label6.Text = "Incoming";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 282);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 13;
            label7.Text = "Outgoing";
            // 
            // dataGridViewIncom
            // 
            dataGridViewIncom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIncom.Location = new Point(472, 46);
            dataGridViewIncom.Name = "dataGridViewIncom";
            dataGridViewIncom.RowHeadersWidth = 62;
            dataGridViewIncom.Size = new Size(436, 225);
            dataGridViewIncom.TabIndex = 14;
            // 
            // dataGridViewOutgoing
            // 
            dataGridViewOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutgoing.Location = new Point(472, 322);
            dataGridViewOutgoing.Name = "dataGridViewOutgoing";
            dataGridViewOutgoing.RowHeadersWidth = 62;
            dataGridViewOutgoing.Size = new Size(436, 225);
            dataGridViewOutgoing.TabIndex = 15;
            // 
            // AccrosTransferPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewOutgoing);
            Controls.Add(dataGridViewIncom);
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
            Name = "AccrosTransferPage";
            Size = new Size(951, 600);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIncom).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutgoing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
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
        private DataGridView dataGridViewIncom;
        private DataGridView dataGridViewOutgoing;
    }
}
