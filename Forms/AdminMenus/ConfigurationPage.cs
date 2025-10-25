using Nescafe.Data;
using Nescafe.Models;
using Nescafe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nescafe.Forms.AdminMenus
{
    public partial class ConfigurationPage : UserControl
    {
        public ConfigurationPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void ConfigurationPage_Load(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration config = await service.GetConfig();
            if (config != null)
            {
                txtTerm1.Text = config.terminologi1;
                txtTerm2.Text = config.terminologi2;
                txtTerm3.Text = config.terminologi3;
                txtExchange.Text = config.exchangeRate.ToString();
                txtInhouse.Text = config.transferInhouseFee.ToString();
                txtAccross.Text = config.transferAcrossFee.ToString();
            }
        }

        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            decimal exchangeRate = decimal.Parse(txtExchange.Text);
            decimal inhouseFee = decimal.Parse(txtInhouse.Text);
            decimal accrossFee = decimal.Parse(txtAccross.Text);

            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            await service.addOrUpdate(txtTerm1.Text, txtTerm2.Text,
                txtTerm3.Text, exchangeRate, inhouseFee, accrossFee);
            MessageBox.Show("Configuration updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void ConfigurationPage_Load_1(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            ConfigurationService service = new ConfigurationService(db);
            Configuration config = await service.GetConfig();
            if (config != null)
            {
                txtTerm1.Text = config.terminologi1;
                txtTerm2.Text = config.terminologi2;
                txtTerm3.Text = config.terminologi3;
                txtExchange.Text = config.exchangeRate.ToString();
                txtInhouse.Text = config.transferInhouseFee.ToString();
                txtAccross.Text = config.transferAcrossFee.ToString();
            }
        }
    }
}
