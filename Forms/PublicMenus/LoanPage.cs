using System;
using System.Security.Cryptography;
using Nescafe.Models;
using Nescafe.Data;
using Nescafe.Forms.PublicMenus;
using Nescafe.Models;
using Nescafe.Utils;
using Nescafe.Services;

namespace Nescafe.Forms.MemberMenus
{
    public partial class LoanPage : UserControl
    {
        Member loggedMember;
        InstallmentForm installmentForm;
        public LoanPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonBrowseKTP_Click(object sender, EventArgs e)
        {
            textDocumentKTP.Text = FileHelper.UploadDocument("KTP");
        }

        private void buttonBrowseKK_Click(object sender, EventArgs e)
        {
            textDocumentKK.Text = FileHelper.UploadDocument("KK");
        }

        private void buttonBrowseSlipGaji_Click(object sender, EventArgs e)
        {
            textDocumentSlipGaji.Text = FileHelper.UploadDocument("Slip Gaji");
        }

        private void LoanPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();
            LoadLoanGrid(db);
            HideInstallment();
        }

        private void SetLoanDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            comboBoxLoanType.DataSource = productService.SetDropDownLoan();
            comboBoxLoanType.DisplayMember = "DisplayName";
            comboBoxLoanType.ValueMember = "Id";
            comboBoxLoanType.Enabled = true;
            HideInstallment();
        }

        private void SetDefaultField()
        {
            comboBoxLoanType.SelectedIndex = 0;
            buttonShowKTP.Visible = false;
            buttonShowKK.Visible = false;
            buttonShowSlipGaji.Visible = false;
            buttonBrowseKTP.Visible = true;
            buttonBrowseKK.Visible = true;
            buttonBrowseSlipGaji.Visible = true;
        }

        private void SetChosenField()
        {
            buttonShowKTP.Visible = true;
            buttonShowKK.Visible = true;
            buttonShowSlipGaji.Visible = true;
            buttonBrowseKTP.Visible = false;
            buttonBrowseKK.Visible = false;
            buttonBrowseSlipGaji.Visible = false;
        }

        private void ResetField()
        {
            textDocumentKTP.Text = "";
            textDocumentKK.Text = "";
            textDocumentSlipGaji.Text = "";
            textDueDate.Text = "";
            textInterest.Text = "";
            textTenor.Text = "";
            textInterestFine.Text = "";
            textMinAmount.Text = "";
            textMaxAmount.Text = "";
            textAdminFee.Text = "";
            textLoanID.Text = RandomNumberGenerator.GetString("1234567890", 6);
            labelID.Text = "";
        }

        private async void LoadLoanGrid(AppDbContext db)
        {
            LoanService loanService = new LoanService(db);
            dataGridLoan.DataSource = await loanService.LoadLoanGrid(loggedMember.Id);
            dataGridLoan.Columns[0].DataPropertyName = "Id";
            dataGridLoan.Columns[1].DataPropertyName = "LoanId";
            dataGridLoan.Columns[2].DataPropertyName = "Outstanding";
            dataGridLoan.Columns[3].DataPropertyName = "TenorLeft";

            dataGridLoan.Columns[0].Visible = false;
            dataGridLoan.Columns[1].HeaderText = "Loan ID";
            dataGridLoan.Columns[2].HeaderText = "Outstanding";
            dataGridLoan.Columns[3].HeaderText = "Tenor Left";
        }

        private void dataGridLoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridLoan.Rows[e.RowIndex];
                labelID.Text = row.Cells[0].Value.ToString();

                AppDbContext db = new AppDbContext();
                LoanService loanService = new LoanService(db);
                Loan loan = loanService.FindById(int.Parse(labelID.Text));

                if (loan != null)
                {
                    if (loan.IsApproved)
                    {
                        SetChosenField();
                        textDocumentKK.Text = loan.KkPath;
                        textDocumentKTP.Text = loan.KtpPath;
                        textDocumentSlipGaji.Text = loan.SlipGajiPath;
                        textDueDate.Text = loan.DueDate.ToString();
                        textInterest.Text = loan.Interest.ToString();
                        textTenor.Text = loan.Tenor.ToString();
                        textInterestFine.Text = loan.Fine.ToString();
                        textMinAmount.Text = loan.MinAmount.ToString();
                        textMaxAmount.Text = loan.MaxAmount.ToString();
                        textAdminFee.Text = loan.AdminFee.ToString();
                        textLoanID.Text = loan.LoanId.ToString();
                        comboBoxLoanType.SelectedIndex = 0;
                        comboBoxLoanType.Enabled = false;

                        if (installmentForm == null)
                            installmentForm = new InstallmentForm(loggedMember, 0);
                        installmentForm.SetLoan(loan.Id);
                        installmentForm.Show();

                        buttonApplyLoan.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Your Loan is not approved yet.", "Approval", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        HideInstallment();
                    }
                }
                else
                {
                    HideInstallment();
                }
            }
        }

        private async void buttonApplyLoan_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            LoanService loanService = new LoanService(db);
            decimal minAmount = decimal.Parse(textMinAmount.Text);
            decimal maxAmount = decimal.Parse(textMaxAmount.Text);
            decimal amount = decimal.Parse(textAmount.Text);
            if (amount < minAmount || amount > maxAmount)
            {
                MessageBox.Show("Invalid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await loanService.SaveOrUpdate(loggedMember, textAmount.Text,
                textDocumentKTP.Text, textDocumentKK.Text, textDocumentSlipGaji.Text, textDueDate.Text,
                textInterest.Text, textTenor.Text, textLoanID.Text,
                comboBoxLoanType.Text, textInterestFine.Text);
        }

        private void HideInstallment()
        {
            if (installmentForm == null)
                installmentForm = new InstallmentForm(loggedMember, 0);
            installmentForm.Hide();
        }

        private void ResetDropDown()
        {
            textInterest.Text = "";
            textTenor.Text = "";
            textInterestFine.Text = "";
            textMinAmount.Text = "";
            textMaxAmount.Text = "";
            textAdminFee.Text = "";
        }

        private async void comboBoxLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetDropDown();

            if (comboBoxLoanType.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboBoxLoanType.SelectedValue.ToString());
                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster loanMaster = await productService.FindLoanById(idLoanMaster);
                if (loanMaster != null)
                {
                    textInterest.Text = loanMaster.Interest.ToString();
                    textInterestFine.Text = loanMaster.Fine.ToString();
                    textTenor.Text = loanMaster.Tenor.ToString();
                    textMinAmount.Text = loanMaster.MinAmount.ToString();
                    textMaxAmount.Text = loanMaster.MaxAmount.ToString();
                    textAdminFee.Text = loanMaster.AdminFee.ToString();
                }
                else
                {
                    ResetDropDown();
                }
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();
            LoadLoanGrid(db);
            HideInstallment();
        }

        private void buttonNewLoan_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            SetLoanDropDown(db);
            SetDefaultField();
            ResetField();
            HideInstallment();
        }
    }
}
