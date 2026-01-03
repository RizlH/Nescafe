namespace Nescafe.Forms.AdminMenus
{
    partial class AcrossPage
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
            dgvCoop = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            dgvBalance = new DataGridView();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dgvTransfer = new DataGridView();
            TransferCode = new DataGridViewTextBoxColumn();
            CoopCode = new DataGridViewTextBoxColumn();
            CodeOrigin = new DataGridViewTextBoxColumn();
            CodeBenef = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRefresh = new Button();
            MemberCode = new DataGridViewTextBoxColumn();
            MemberName = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Columns.AddRange(new DataGridViewColumn[] { Code, Name, Address });
            dgvCoop.Location = new Point(47, 43);
            dgvCoop.Margin = new Padding(3, 2, 3, 2);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 51;
            dgvCoop.Size = new Size(465, 171);
            dgvCoop.TabIndex = 0;
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.Name = "Code";
            Code.Width = 90;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Columns.AddRange(new DataGridViewColumn[] { MemberCode, MemberName, Balance });
            dgvBalance.Location = new Point(525, 43);
            dgvBalance.Margin = new Padding(3, 2, 3, 2);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.RowHeadersWidth = 51;
            dgvBalance.Size = new Size(376, 171);
            dgvBalance.TabIndex = 1;
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dgvTransfer
            // 
            dgvTransfer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransfer.Columns.AddRange(new DataGridViewColumn[] { TransferCode, CoopCode, CodeOrigin, CodeBenef, Amount, Remarks });
            dgvTransfer.Location = new Point(47, 249);
            dgvTransfer.Margin = new Padding(3, 2, 3, 2);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 51;
            dgvTransfer.Size = new Size(854, 138);
            dgvTransfer.TabIndex = 2;
            // 
            // TransferCode
            // 
            TransferCode.HeaderText = "Transfer Code";
            TransferCode.Name = "TransferCode";
            // 
            // CoopCode
            // 
            CoopCode.HeaderText = "Coop Code";
            CoopCode.Name = "CoopCode";
            // 
            // CodeOrigin
            // 
            CodeOrigin.HeaderText = "Code Origin";
            CodeOrigin.Name = "CodeOrigin";
            // 
            // CodeBenef
            // 
            CodeBenef.HeaderText = "Code Benef";
            CodeBenef.Name = "CodeBenef";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Remarks
            // 
            Remarks.HeaderText = "Remarks";
            Remarks.Name = "Remarks";
            Remarks.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 26);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 26);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 232);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Transfer";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(440, 398);
            buttonRefresh.Margin = new Padding(3, 2, 3, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(82, 22);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // MemberCode
            // 
            MemberCode.HeaderText = "Member Code";
            MemberCode.Name = "MemberCode";
            // 
            // MemberName
            // 
            MemberName.HeaderText = "Member Name";
            MemberName.Name = "MemberName";
            MemberName.Width = 120;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            // 
            // AcrossPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRefresh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTransfer);
            Controls.Add(dgvBalance);
            Controls.Add(dgvCoop);
            Size = new Size(950, 450);
            Load += AcrossPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoop).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCoop;
        private DataGridView dgvBalance;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dgvTransfer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRefresh;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn TransferCode;
        private DataGridViewTextBoxColumn CoopCode;
        private DataGridViewTextBoxColumn CodeOrigin;
        private DataGridViewTextBoxColumn CodeBenef;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewTextBoxColumn MemberCode;
        private DataGridViewTextBoxColumn MemberName;
        private DataGridViewTextBoxColumn Balance;
    }
}
