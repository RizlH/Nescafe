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
    public partial class AccesPage : UserControl
    {
        private Member? loggedMember;
        public AccesPage(Member? member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService memberService = new MemberService(db);
            AccessService accessService = new AccessService(db);
            string accessList = string.Join(",", clbAccess.CheckedItems.Cast<string>());
            int id = comboMember.SelectedValue as int? ?? 0;
            Member? member = id != 0 ? memberService.FindById(id) : null;
            if (member != null)
            {
                Access? access = accessService.findByMember(member.Id);
                if (access != null)
                {
                    await accessService.update(access, accessList);
                }
                else
                {
                    await accessService.newOne(access, member, accessList);
                }
                loadAccessList(db);
                clearField();
            }
            else
            {
                MessageBox.Show("Invalid Member", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearField()
        {
            for (int i = 0; i < clbAccess.Items.Count; i++)
            {
                Access.SetItemChecked(i, false);
            }

            comboMember.SelectedItem = null;
            lblFullName.Text = "";
            lblAddress.Text = "";
            lblEmail.Text = "";
            lblJoinDate.Text = "";
            lblPhone.Text = "";
            lblPhoneAlt.Text = "";
        }

        private void clbAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool n = clbAccess.GetItemChecked(0);
            if (n)
            {
                for (int i = 1; i < clbAccess.Items.Count; i++)
                {
                    clbAccess.SetItemChecked(i, true);
                }
                /*listBoxAccess.SetItemChecked(1, true);
                listBoxAccess.SetItemChecked(2, true);
                listBoxAccess.SetItemChecked(3, true);
                listBoxAccess.SetItemChecked(4, true);
                listBoxAccess.SetItemChecked(5, true);*/
            }
        }
        private void AccessPage_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            loadMember(db);
            loadAccessList(db);
        }
        private void loadMember(AppDbContext db)
        {
            var memberService = new MemberService(db);
            memberBindingSource.DataSource = memberService.SetDropdown();
            comboMember.DisplayMember = "DisplayName";
            comboMember.ValueMember = "Id";
        }

        private void loadAccessList(AppDbContext db)
        {
            var accessService = new AccessService(db);
            accessBindingSource.DataSource = accessService.setGridView();
            dataGridViewAccess.Columns[0].DataPropertyName = "Id";
            dataGridViewAccess.Columns[0].Visible = false;
            dataGridViewAccess.Columns[1].DataPropertyName = "DisplayMember";
            dataGridViewAccess.Columns[2].DataPropertyName = "AccessList";
            dataGridViewAccess.Columns[2].Width = 220;
            dataGridViewAccess.Columns[3].DataPropertyName = "updateOn";
        }
        private void comboMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService memberService = new MemberService(db);
            int id = comboMember.SelectedValue as int? ?? 0;
            Member? member = id != 0 ? memberService.FindById(id) : null;
            if (member != null)
            {
                lblFullName.Text = member.FullName;
                lblAddress.Text = member.Address;
                lblEmail.Text = member.Email;
                lblJoinDate.Text = member.JoinDate.ToString("f");
                lblPhone.Text = member.Phone;
                lblPhoneAlt.Text = member.PhoneAlt;
            }
            else
            {
                lblFullName.Text = "";
                lblAddress.Text = "";
                lblEmail.Text = "";
                lblJoinDate.Text = "";
                lblPhone.Text = "";
                lblPhoneAlt.Text = "";
            }
        }

        private void dataGridViewAccess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int accessId = int.Parse(dataGridViewAccess.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                AccessService accessService = new AccessService(db);
                Access? access = accessService.findById(accessId);
                if (access != null)
                {
                    comboMember.SelectedValue = access.MemberId;
                    string[] accessList = access.AccessList.Split(",");
                    for (int i = 0; i < accessList.Length; i++)
                    {
                        if (accessList[i].Trim() == "Grant All")
                            clbAccess.SetItemChecked(0, true);
                        if (accessList[i].Trim() == "Loan")
                            clbAccess.SetItemChecked(1, true);
                        if (accessList[i].Trim() == "Saving")
                            clbAccess.SetItemChecked(2, true);
                        if (accessList[i].Trim() == "Transfer - Inhouse")
                            clbAccess.SetItemChecked(3, true);
                        if (accessList[i].Trim() == "Transfer - Across")
                            clbAccess.SetItemChecked(4, true);
                        if (accessList[i].Trim() == "Exchange")
                            clbAccess.SetItemChecked(5, true);
                    }
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService memberService = new MemberService(db);
            AccessService accessService = new AccessService(db);
            string accessList = string.Join(",", clbAccess.CheckedItems.Cast<string>());
            int id = comboMember.SelectedValue as int? ?? 0;
            Member? member = id != 0 ? memberService.FindById(id) : null;
            if (member != null)
            {
                Access? access = accessService.findByMember(member.Id);
                if (access != null)
                {
                    await accessService.update(access, accessList);
                }
                else
                {
                    await accessService.newOne(access, member, accessList);
                }
                loadAccessList(db);
                clearField();
            }
            else
            {
                MessageBox.Show("Invalid Member", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearField()
        {
            for (int i = 0; i < clbAccess.Items.Count; i++)
            {
                // Access.SetItemChecked(i, false);
            }

            comboMember.SelectedItem = null;
            lblFullName.Text = "";
            lblAddress.Text = "";
            lblEmail.Text = "";
            lblJoinDate.Text = "";
            lblPhone.Text = "";
            lblPhoneAlt.Text = "";
        }

        private void clbAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool n = clbAccess.GetItemChecked(0);
            if (n)
            {
                for (int i = 1; i < clbAccess.Items.Count; i++)
                {
                    clbAccess.SetItemChecked(i, true);
                }
                /*listBoxAccess.SetItemChecked(1, true);
                listBoxAccess.SetItemChecked(2, true);
                listBoxAccess.SetItemChecked(3, true);
                listBoxAccess.SetItemChecked(4, true);
                listBoxAccess.SetItemChecked(5, true);*/
            }
        }
        private void AccessPage_Load(object sender, EventArgs e)
        {
            using var db = new AppDbContext();
            loadMember(db);
            loadAccessList(db);
        }
        private void loadMember(AppDbContext db)
        {
            var memberService = new MemberService(db);
            memberBindingSource.DataSource = memberService.SetDropdown();
            comboMember.DisplayMember = "DisplayName";
            comboMember.ValueMember = "Id";
        }

        private void loadAccessList(AppDbContext db)
        {
            var accessService = new AccessService(db);
            accessBindingSource.DataSource = accessService.setGridView();
            dataGridViewAccess.Columns[0].DataPropertyName = "Id";
            dataGridViewAccess.Columns[0].Visible = false;
            dataGridViewAccess.Columns[1].DataPropertyName = "DisplayMember";
            dataGridViewAccess.Columns[2].DataPropertyName = "AccessList";
            dataGridViewAccess.Columns[2].Width = 220;
            dataGridViewAccess.Columns[3].DataPropertyName = "updateOn";
        }
        private void comboMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService memberService = new MemberService(db);
            int id = comboMember.SelectedValue as int? ?? 0;
            Member? member = id != 0 ? memberService.FindById(id) : null;
            if (member != null)
            {
                lblFullName.Text = member.FullName;
                lblAddress.Text = member.Address;
                lblEmail.Text = member.Email;
                lblJoinDate.Text = member.JoinDate.ToString("f");
                lblPhone.Text = member.Phone;
                lblPhoneAlt.Text = member.PhoneAlt;
            }
            else
            {
                lblFullName.Text = "";
                lblAddress.Text = "";
                lblEmail.Text = "";
                lblJoinDate.Text = "";
                lblPhone.Text = "";
                lblPhoneAlt.Text = "";
            }
        }

        private void dataGridViewAccess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int accessId = int.Parse(dataGridViewAccess.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                AccessService accessService = new AccessService(db);
                Access? access = accessService.findById(accessId);
                if (access != null)
                {
                    comboMember.SelectedValue = access.MemberId;
                    string[] accessList = access.AccessList.Split(",");
                    for (int i = 0; i < accessList.Length; i++)
                    {
                        if (accessList[i].Trim() == "Grant All")
                            clbAccess.SetItemChecked(0, true);
                        if (accessList[i].Trim() == "Loan")
                            clbAccess.SetItemChecked(1, true);
                        if (accessList[i].Trim() == "Saving")
                            clbAccess.SetItemChecked(2, true);
                        if (accessList[i].Trim() == "Transfer - Inhouse")
                            clbAccess.SetItemChecked(3, true);
                        if (accessList[i].Trim() == "Transfer - Across")
                            clbAccess.SetItemChecked(4, true);
                        if (accessList[i].Trim() == "Exchange")
                            clbAccess.SetItemChecked(5, true);
                    }
                }
            }
        }

        private void dataGridViewAccess_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
