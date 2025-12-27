namespace Nescafe.Forms.MemberMenus
{
    partial class AcrossTransferPage
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
            label1 = new Label();
            textBalance = new TextBox();
            textBenef = new TextBox();
            label2 = new Label();
            textAmount = new TextBox();
            label3 = new Label();
            textTransRef = new TextBox();
            label4 = new Label();
            textRemarks = new TextBox();
            label5 = new Label();
            buttonSubmit = new Button();
            buttonClear = new Button();
            dgvIncoming = new DataGridView();
            label6 = new Label();
            timerInbox = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            dgvOutgoing = new DataGridView();
            labelMyBenef = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Balance";
            // 
            // textBalance
            // 
            textBalance.Location = new Point(25, 65);
            textBalance.Name = "textBalance";
            textBalance.Size = new Size(209, 23);
            textBalance.TabIndex = 1;
            // 
            // textBenef
            // 
            textBenef.Location = new Point(25, 120);
            textBenef.Name = "textBenef";
            textBenef.Size = new Size(209, 23);
            textBenef.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 99);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Beneficiary";
            // 
            // textAmount
            // 
            textAmount.Location = new Point(25, 174);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(209, 23);
            textAmount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 153);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // textTransRef
            // 
            textTransRef.Location = new Point(25, 229);
            textTransRef.Name = "textTransRef";
            textTransRef.Size = new Size(209, 23);
            textTransRef.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 208);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Transfer Ref";
            // 
            // textRemarks
            // 
            textRemarks.Location = new Point(25, 285);
            textRemarks.Multiline = true;
            textRemarks.Name = "textRemarks";
            textRemarks.Size = new Size(209, 43);
            textRemarks.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 263);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 8;
            label5.Text = "Remarks";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(23, 343);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(97, 23);
            buttonSubmit.TabIndex = 10;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(137, 343);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(97, 23);
            buttonClear.TabIndex = 11;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // dgvIncoming
            // 
            dgvIncoming.AllowUserToAddRows = false;
            dgvIncoming.AllowUserToDeleteRows = false;
            dgvIncoming.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIncoming.Location = new Point(266, 32);
            dgvIncoming.Name = "dgvIncoming";
            dgvIncoming.ReadOnly = true;
            dgvIncoming.Size = new Size(240, 132);
            dgvIncoming.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 14);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 13;
            label6.Text = "Incoming";
            // 
            // timerInbox
            // 
            timerInbox.Interval = 10000;
            timerInbox.Tick += timerInbox_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(266, 178);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 15;
            label7.Text = "Outgoing";
            // 
            // dgvOutgoing
            // 
            dgvOutgoing.AllowUserToAddRows = false;
            dgvOutgoing.AllowUserToDeleteRows = false;
            dgvOutgoing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOutgoing.Location = new Point(266, 196);
            dgvOutgoing.Name = "dgvOutgoing";
            dgvOutgoing.ReadOnly = true;
            dgvOutgoing.Size = new Size(240, 132);
            dgvOutgoing.TabIndex = 14;
            // 
            // labelMyBenef
            // 
            labelMyBenef.AutoSize = true;
            labelMyBenef.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMyBenef.Location = new Point(23, 14);
            labelMyBenef.Name = "labelMyBenef";
            labelMyBenef.Size = new Size(67, 15);
            labelMyBenef.TabIndex = 16;
            labelMyBenef.Text = "My Benef: ";
            // 
            // AcrossTransferPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMyBenef);
            Controls.Add(label7);
            Controls.Add(dgvOutgoing);
            Controls.Add(label6);
            Controls.Add(dgvIncoming);
            Controls.Add(buttonClear);
            Controls.Add(buttonSubmit);
            Controls.Add(textRemarks);
            Controls.Add(label5);
            Controls.Add(textTransRef);
            Controls.Add(label4);
            Controls.Add(textAmount);
            Controls.Add(label3);
            Controls.Add(textBenef);
            Controls.Add(label2);
            Controls.Add(textBalance);
            Controls.Add(label1);
            Name = "AcrossTransferPage";
            Size = new Size(543, 383);
            Load += AcrossTransferPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIncoming).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOutgoing).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBalance;
        private TextBox textBenef;
        private Label label2;
        private TextBox textAmount;
        private Label label3;
        private TextBox textTransRef;
        private Label label4;
        private TextBox textRemarks;
        private Label label5;
        private Button buttonSubmit;
        private Button buttonClear;
        private DataGridView dgvIncoming;
        private Label label6;
        private System.Windows.Forms.Timer timerInbox;
        private Label label7;
        private DataGridView dgvOutgoing;
        private Label labelMyBenef;
    }
}
