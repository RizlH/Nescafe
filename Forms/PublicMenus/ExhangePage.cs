using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nescafe.Models;
using Nescafe.Data;
using Nescafe.Services;

namespace Nescafe.Forms.PublicMenus
{
    public partial class ExhangePage : UserControl
    {
        Member loggedMember;
        public ExhangePage(Member member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void ExhangePage_Load(object sender, EventArgs e)
        {
            tbAmount.Text = "0";
            AppDbContext db = new AppDbContext();
            ConfigurationService configService = new ConfigurationService(db);
            Configuration? config = await configService.GetConfig();
            tbFee.Text = config != null ? config.transferAcrossFee.ToString() : "0";
            tbRate.Text = config != null ? config.exchangeRate.ToString() : "0";
        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(tbAmount.Text);
                decimal rate = Convert.ToDecimal(tbRate.Text);
                decimal fee = Convert.ToDecimal(tbFee.Text);
                decimal subTotal = amount * rate;
                decimal total = subTotal - fee;
                tbTotal.Text = total.ToString("0.00");
                tbSubTotal.Text = subTotal.ToString("0.00");
            }
            catch (Exception)
            {
                tbTotal.Text = "0.00";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange
            {
                MemberId = loggedMember.Id,
                ExchangeId = Guid.NewGuid().ToString(),
                Amount = Convert.ToDecimal(tbAmount.Text),
                Rate = Convert.ToDecimal(tbRate.Text),
                Fee = Convert.ToDecimal(tbFee.Text),
                AmountExchanged = Convert.ToDecimal(tbAmount.Text) * Convert.ToDecimal(tbRate.Text),
                ExchangeDate = DateTime.Now,
                TotalAmountExchanged = Convert.ToDecimal(tbTotal.Text)
            };
            AppDbContext db = new AppDbContext();
            ExchangeService exchangeService = new ExchangeService(db);
            exchangeService.save(exchange);
            tbAmount.Text = "0";
            MessageBox.Show("Exchange submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAmount.Text = "0";
        }
    }


}
