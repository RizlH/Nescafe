namespace Nescafe.Forms.AdminMenus
{
    partial class AccessPage
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
            dataGridViewAccess = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            memberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accessListDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            updateOnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accessBindingSource = new BindingSource(components);
            comboMember = new ComboBox();
            memberBindingSource = new BindingSource(components);
            listBoxAccess = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            labelAddress = new Label();
            labelPhoneAlt = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelJoinDate = new Label();
            labelFullName = new Label();
            label7 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            buttonSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewAccess
            // 
            dataGridViewAccess.AllowUserToAddRows = false;
            dataGridViewAccess.AllowUserToDeleteRows = false;
            dataGridViewAccess.AllowUserToOrderColumns = true;
            dataGridViewAccess.AutoGenerateColumns = false;
            dataGridViewAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccess.Columns.AddRange(new DataGridViewColumn[] { Id, memberDataGridViewTextBoxColumn, accessListDataGridViewTextBoxColumn, updateOnDataGridViewTextBoxColumn });
            dataGridViewAccess.DataSource = accessBindingSource;
            dataGridViewAccess.Location = new Point(265, 38);
            dataGridViewAccess.Name = "dataGridViewAccess";
            dataGridViewAccess.ReadOnly = true;
            dataGridViewAccess.Size = new Size(476, 344);
            dataGridViewAccess.TabIndex = 0;
            dataGridViewAccess.CellContentClick += dataGridViewAccess_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // memberDataGridViewTextBoxColumn
            // 
            memberDataGridViewTextBoxColumn.DataPropertyName = "Member";
            memberDataGridViewTextBoxColumn.HeaderText = "Member";
            memberDataGridViewTextBoxColumn.Name = "memberDataGridViewTextBoxColumn";
            memberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accessListDataGridViewTextBoxColumn
            // 
            accessListDataGridViewTextBoxColumn.DataPropertyName = "AccessList";
            accessListDataGridViewTextBoxColumn.HeaderText = "AccessList";
            accessListDataGridViewTextBoxColumn.Name = "accessListDataGridViewTextBoxColumn";
            accessListDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateOnDataGridViewTextBoxColumn
            // 
            updateOnDataGridViewTextBoxColumn.DataPropertyName = "updateOn";
            updateOnDataGridViewTextBoxColumn.HeaderText = "updateOn";
            updateOnDataGridViewTextBoxColumn.Name = "updateOnDataGridViewTextBoxColumn";
            updateOnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accessBindingSource
            // 
            accessBindingSource.DataSource = typeof(Models.Access);
            // 
            // comboMember
            // 
            comboMember.DataSource = memberBindingSource;
            comboMember.DisplayMember = "memberId";
            comboMember.FormattingEnabled = true;
            comboMember.Location = new Point(3, 38);
            comboMember.Name = "comboMember";
            comboMember.Size = new Size(175, 23);
            comboMember.TabIndex = 1;
            comboMember.SelectedIndexChanged += comboMember_SelectedIndexChanged;
            // 
            // memberBindingSource
            // 
            memberBindingSource.DataSource = typeof(Models.Member);
            // 
            // listBoxAccess
            // 
            listBoxAccess.FormattingEnabled = true;
            listBoxAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer - Inhouse", "Transfer - Accross", "Exchange" });
            listBoxAccess.Location = new Point(3, 67);
            listBoxAccess.Name = "listBoxAccess";
            listBoxAccess.Size = new Size(256, 112);
            listBoxAccess.TabIndex = 2;
            listBoxAccess.SelectedIndexChanged += listBoxAccess_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Member";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 20);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Access";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelAddress);
            groupBox1.Controls.Add(labelPhoneAlt);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelJoinDate);
            groupBox1.Controls.Add(labelFullName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(5, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(254, 197);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(105, 151);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(16, 15);
            labelAddress.TabIndex = 11;
            labelAddress.Text = "...";
            // 
            // labelPhoneAlt
            // 
            labelPhoneAlt.AutoSize = true;
            labelPhoneAlt.Location = new Point(105, 125);
            labelPhoneAlt.Name = "labelPhoneAlt";
            labelPhoneAlt.Size = new Size(16, 15);
            labelPhoneAlt.TabIndex = 10;
            labelPhoneAlt.Text = "...";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(105, 100);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(16, 15);
            labelPhone.TabIndex = 9;
            labelPhone.Text = "...";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(105, 74);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(16, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "...";
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(105, 49);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(16, 15);
            labelJoinDate.TabIndex = 7;
            labelJoinDate.Text = "...";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(105, 23);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(16, 15);
            labelFullName.TabIndex = 6;
            labelFullName.Text = "...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 151);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 5;
            label7.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 125);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 4;
            label8.Text = "Phone Alt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 100);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 3;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 74);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 2;
            label6.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 49);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 1;
            label4.Text = "Join Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(184, 38);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSubmit);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxAccess);
            Controls.Add(comboMember);
            Controls.Add(dataGridViewAccess);
            Name = "AccessPage";
            Size = new Size(744, 398);
            Load += AccessPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).EndInit();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAccess;
        private ComboBox comboMember;
        private CheckedListBox listBoxAccess;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label labelAddress;
        private Label labelPhoneAlt;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelJoinDate;
        private Label labelFullName;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private BindingSource accessBindingSource;
        private Button buttonSubmit;
        private BindingSource memberBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn memberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn accessListDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn updateOnDataGridViewTextBoxColumn;
    }
}
