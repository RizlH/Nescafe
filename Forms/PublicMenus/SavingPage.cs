using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nescafe.Data;
using Nescafe.Models;
using BraveHeroCooperation.Utils;
using Nescafe.Services;
using System.Reflection.Emit;
using System.Security.Cryptography;

namespace Nescafe.Forms.PublicMenus
{
    public partial class SavingPage : UserControl
    {
        Member loggedMember;

        public SavingPage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {

        }

        private void buttonFileKK_Click(object sender, EventArgs e)
        {
            textDocKK.Text = FileHelper.UploadDocument("KK");
        }

        private void SavingPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }

        private void SetSavingDropDown(AppDbContext db)
        {
            ProductService productService = new ProductService(db);
            //loanMasterBindingSource.DataSource = productService.SetDropDownSaving();
            Object obj = productService.SetDropDownSaving();
            comboSavingMaster.DataSource = obj;
            comboSavingMaster.DisplayMember = "DisplayName";
            comboSavingMaster.ValueMember = "Id";
        }

        private void SetDefaultField()
        {
            comboSavingMaster.SelectedIndex = 0;
            buttonShowDocKtp.Visible = false;
            buttonShowDocKk.Visible = false;
            buttonShowDocSlip.Visible = false;
            buttonFileKTP.Visible = true;
            buttonFileKK.Visible = true;
            buttonFileSlip.Visible = true;
        }

        private void SetChosenField()
        {
            buttonShowDocKtp.Visible = true;
            buttonShowDocKk.Visible = true;
            buttonShowDocSlip.Visible = true;
            buttonFileKTP.Visible = false;
            buttonFileKK.Visible = false;
            buttonFileSlip.Visible = false;
        }

        private void ResetField()
        {
            textDocKK.Text = "";
            textDocKtp.Text = "";
            textDocSlip.Text = "";
            textDueDate.Text = "";
            textAmount.Text = "";
            ResetDropDown();
            textSavingId.Text = RandomNumberGenerator.GetString("1234567890", 6);
            labelId.Text = "";
        }

        private void ResetDropDown()
        {
            textInterest.Text = "";
            textInterestFine.Text = "";
            textTenor.Text = "";
            textAdminFee.Text = "";
            textMinAmount.Text = "";
            textMaxAmount.Text = "";
        }

        private async void LoadSavingGrid(AppDbContext db)
        {
            SavingService savingService = new SavingService(db);
            /*loanBindingSource.DataSource = await savingService.LoadSavingGrid(loggedMember);
            dataGriedViewSaving.Columns[0].DataPropertyName = "Id";
            dataGriedViewSaving.Columns[1].DataPropertyName = "SavingId";
            dataGriedViewSaving.Columns[2].DataPropertyName = "Amount";
            dataGriedViewSaving.Columns[3].DataPropertyName = "Tenor";*/


            List<Saving> listSaving = await savingService.LoadSavingGrid(loggedMember.Id);
            foreach (Saving s in listSaving)
            {
                dataGriedViewSaving.Rows.Add(s.Id, s.SavingId, s.Amount, s.Tenor);
            }
            
            dataGriedViewSaving.Columns[0].Visible = false;
            dataGriedViewSaving.Columns[1].HeaderText = "Saving ID";
            dataGriedViewSaving.Columns[2].HeaderText = "Amount";
            dataGriedViewSaving.Columns[3].HeaderText = "Tenor";
        }

        private async void comboLoanMaster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSavingMaster.SelectedIndex == 0)
                ResetDropDown();

            if (comboSavingMaster.SelectedIndex > 0)
            {
                int idLoanMaster = int.Parse(comboSavingMaster.SelectedValue.ToString());

                AppDbContext db = new AppDbContext();
                ProductService productService = new ProductService(db);
                LoanMaster? loanMaster = await productService.FindLoanById(idLoanMaster);
                if (loanMaster != null)
                {

                    textInterest.Text = loanMaster.Interest.ToString();
                    textInterestFine.Text = loanMaster.Fine.ToString();
                    textTenor.Text = loanMaster.Tenor.ToString();
                    textAdminFee.Text = loanMaster.AdminFee.ToString();
                    textMinAmount.Text = loanMaster.MinAmount.ToString();
                    textMaxAmount.Text = loanMaster.MaxAmount.ToString();
                }
                else
                {
                    ResetDropDown();
                };
            }
        }

        private void buttonNewSaving_Click(object sender, EventArgs e)
        {
            SetDefaultField();
            ResetField() ;
            buttonApply.Enabled = true;
            comboSavingMaster.SelectedIndex = 0;
            comboSavingMaster.Enabled = true ;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();

            SetSavingDropDown(db);
            SetDefaultField();
            ResetField();

            LoadSavingGrid(db);
        }
    }
}
