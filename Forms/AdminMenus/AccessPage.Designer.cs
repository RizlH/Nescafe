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
            comboMember = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnSubmit = new Button();
            dataGridViewAccess = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Member = new DataGridViewTextBoxColumn();
            AccessList = new DataGridViewTextBoxColumn();
            updateOn = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblAddress = new Label();
            lblPhoneAlt = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblJoinDate = new Label();
            lblFullName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            accessBindingSource = new BindingSource(components);
            memberBindingSource = new BindingSource(components);
            clbAccess = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboMember
            // 
            comboMember.FormattingEnabled = true;
            comboMember.Location = new Point(27, 77);
            comboMember.Name = "comboMember";
            comboMember.Size = new Size(289, 33);
            comboMember.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Member";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 37);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Access";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(322, 77);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // dataGridViewAccess
            // 
            dataGridViewAccess.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccess.Columns.AddRange(new DataGridViewColumn[] { Id, Member, AccessList, updateOn });
            dataGridViewAccess.Location = new Point(453, 71);
            dataGridViewAccess.Name = "dataGridViewAccess";
            dataGridViewAccess.RowHeadersWidth = 62;
            dataGridViewAccess.Size = new Size(735, 537);
            dataGridViewAccess.TabIndex = 4;
            dataGridViewAccess.CellContentClick += this.dataGridViewAccess_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Member
            // 
            Member.HeaderText = "Member";
            Member.MinimumWidth = 8;
            Member.Name = "Member";
            Member.Width = 150;
            // 
            // AccessList
            // 
            AccessList.HeaderText = "AccessList";
            AccessList.MinimumWidth = 8;
            AccessList.Name = "AccessList";
            AccessList.Width = 150;
            // 
            // updateOn
            // 
            updateOn.HeaderText = "updateOn";
            updateOn.MinimumWidth = 8;
            updateOn.Name = "updateOn";
            updateOn.Width = 150;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblPhoneAlt);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblJoinDate);
            groupBox1.Controls.Add(lblFullName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(27, 304);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 304);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(168, 261);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(24, 25);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "...";
            // 
            // lblPhoneAlt
            // 
            lblPhoneAlt.AutoSize = true;
            lblPhoneAlt.Location = new Point(168, 213);
            lblPhoneAlt.Name = "lblPhoneAlt";
            lblPhoneAlt.Size = new Size(24, 25);
            lblPhoneAlt.TabIndex = 10;
            lblPhoneAlt.Text = "...";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(168, 163);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(24, 25);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "...";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(168, 117);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(24, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "...";
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(168, 75);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(24, 25);
            lblJoinDate.TabIndex = 7;
            lblJoinDate.Text = "...";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(168, 33);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(24, 25);
            lblFullName.TabIndex = 6;
            lblFullName.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 261);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 5;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 213);
            label7.Name = "label7";
            label7.Size = new Size(89, 25);
            label7.TabIndex = 4;
            label7.Text = "Phone Alt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 163);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 3;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 117);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 75);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 1;
            label4.Text = "Join Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 33);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 0;
            label3.Text = "Full Name";
            // 
            // clbAccess
            // 
            clbAccess.FormattingEnabled = true;
            clbAccess.Items.AddRange(new object[] { "Grant All", "Loan", "Saving", "Transfer - Inhouse", "Transfer - Accross", "Exchange" });
            clbAccess.Location = new Point(27, 116);
            clbAccess.Name = "clbAccess";
            clbAccess.Size = new Size(407, 172);
            clbAccess.TabIndex = 5;
            clbAccess.SelectedIndexChanged += clbAccess_SelectedIndexChanged;
            // 
            // AccessPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(clbAccess);
            Controls.Add(dataGridViewAccess);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboMember);
            Name = "AccessPage";
            Size = new Size(1252, 668);
            Load += AccesPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccess).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accessBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)memberBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboMember;
        private Label label1;
        private Label label2;
        private Button btnSubmit;
        private DataGridView dataGridViewAccess;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private BindingSource accessBindingSource;
        private BindingSource memberBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Member;
        private DataGridViewTextBoxColumn AccessList;
        private DataGridViewTextBoxColumn updateOn;
        private Label lblAddress;
        private Label lblPhoneAlt;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblJoinDate;
        private Label lblFullName;
        private CheckedListBox clbAccess;
    }
}
