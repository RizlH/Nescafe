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
            dgvBalance = new DataGridView();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dgvTransfer = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCoop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransfer).BeginInit();
            SuspendLayout();
            // 
            // dgvCoop
            // 
            dgvCoop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoop.Location = new Point(22, 38);
            dgvCoop.Margin = new Padding(3, 2, 3, 2);
            dgvCoop.Name = "dgvCoop";
            dgvCoop.RowHeadersWidth = 51;
            dgvCoop.Size = new Size(446, 171);
            dgvCoop.TabIndex = 0;
            // 
            // dgvBalance
            // 
            dgvBalance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBalance.Location = new Point(473, 38);
            dgvBalance.Margin = new Padding(3, 2, 3, 2);
            dgvBalance.Name = "dgvBalance";
            dgvBalance.RowHeadersWidth = 51;
            dgvBalance.Size = new Size(353, 171);
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
            dgvTransfer.Location = new Point(22, 244);
            dgvTransfer.Margin = new Padding(3, 2, 3, 2);
            dgvTransfer.Name = "dgvTransfer";
            dgvTransfer.RowHeadersWidth = 51;
            dgvTransfer.Size = new Size(804, 138);
            dgvTransfer.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 21);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Coop";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 21);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 227);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Transfer";
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(386, 397);
            buttonRefresh.Margin = new Padding(3, 2, 3, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(82, 22);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
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
            Name = "AcrossPage";
            Size = new Size(863, 431);
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
    }
}
