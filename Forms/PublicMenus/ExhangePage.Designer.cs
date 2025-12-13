namespace Nescafe.Forms.PublicMenus
{
    partial class ExhangePage
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
            tbAmount = new TextBox();
            tbRate = new TextBox();
            label3 = new Label();
            tbSubTotal = new TextBox();
            label4 = new Label();
            tbFee = new TextBox();
            label5 = new Label();
            tbTotal = new TextBox();
            label6 = new Label();
            btnSubmit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 35);
            label1.Name = "label1";
            label1.Size = new Size(231, 38);
            label1.TabIndex = 0;
            label1.Text = "EXCHANGE USD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 141);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // tbAmount
            // 
            tbAmount.Location = new Point(102, 138);
            tbAmount.Name = "tbAmount";
            tbAmount.Size = new Size(194, 27);
            tbAmount.TabIndex = 2;
            // 
            // tbRate
            // 
            tbRate.Location = new Point(102, 187);
            tbRate.Name = "tbRate";
            tbRate.ReadOnly = true;
            tbRate.Size = new Size(194, 27);
            tbRate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 190);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "Rate";
            // 
            // tbSubTotal
            // 
            tbSubTotal.Location = new Point(102, 246);
            tbSubTotal.Name = "tbSubTotal";
            tbSubTotal.ReadOnly = true;
            tbSubTotal.Size = new Size(194, 27);
            tbSubTotal.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 249);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 5;
            label4.Text = "Sub Total";
            // 
            // tbFee
            // 
            tbFee.Location = new Point(102, 297);
            tbFee.Name = "tbFee";
            tbFee.ReadOnly = true;
            tbFee.Size = new Size(194, 27);
            tbFee.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 300);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 7;
            label5.Text = "Fee";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(102, 351);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(194, 27);
            tbTotal.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 354);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 9;
            label6.Text = "Total";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(102, 384);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(202, 384);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // ExhangePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(tbTotal);
            Controls.Add(label6);
            Controls.Add(tbFee);
            Controls.Add(label5);
            Controls.Add(tbSubTotal);
            Controls.Add(label4);
            Controls.Add(tbRate);
            Controls.Add(label3);
            Controls.Add(tbAmount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExhangePage";
            Size = new Size(343, 474);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbAmount;
        private TextBox tbRate;
        private Label label3;
        private TextBox tbSubTotal;
        private Label label4;
        private TextBox tbFee;
        private Label label5;
        private TextBox tbTotal;
        private Label label6;
        private Button btnSubmit;
        private Button btnClear;
    }
}
