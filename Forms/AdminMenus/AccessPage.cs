using System.Data;
using Nescafe.Data;
using Nescafe.Models;
using Nescafe.Services;

namespace Nescafe.Forms.AdminMenus
{
    public partial class AccessPage : UserControl
    {
        private Member? loggedMember;
        public AccessPage(Member? member)
        {
            loggedMember = member;
            InitializeComponent();
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService memberService = new MemberService(db);
            AccessService accessService = new AccessService(db);
            string accessList = string.Join(", ", listBoxAccess.CheckedItems.Cast<string>());
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
            for (int i = 0; i < listBoxAccess.Items.Count; i++)
            {
                listBoxAccess.SetItemChecked(i, false);
            }

            comboMember.SelectedItem = null;
            labelFullName.Text = "";
            labelAddress.Text = "";
            labelEmail.Text = "";
            labelJoinDate.Text = "";
            labelPhone.Text = "";
            labelPhoneAlt.Text = "";
        }

        private void listBoxAccess_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool n = listBoxAccess.GetItemChecked(0);
            if (n)
            {
                for (int i = 1; i < listBoxAccess.Items.Count; i++)
                {
                    listBoxAccess.SetItemChecked(i, true);
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
                labelFullName.Text = member.FullName;
                labelAddress.Text = member.Address;
                labelEmail.Text = member.Email;
                labelJoinDate.Text = member.JoinDate.ToString("f");
                labelPhone.Text = member.Phone;
                labelPhoneAlt.Text = member.PhoneAlt;
            }
            else
            {
                labelFullName.Text = "";
                labelAddress.Text = "";
                labelEmail.Text = "";
                labelJoinDate.Text = "";
                labelPhone.Text = "";
                labelPhoneAlt.Text = "";
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
                            listBoxAccess.SetItemChecked(0, true);
                        if (accessList[i].Trim() == "Loan")
                            listBoxAccess.SetItemChecked(1, true);
                        if (accessList[i].Trim() == "Saving")
                            listBoxAccess.SetItemChecked(2, true);
                        if (accessList[i].Trim() == "Transfer - Inhouse")
                            listBoxAccess.SetItemChecked(3, true);
                        if (accessList[i].Trim() == "Transfer - Accross")
                            listBoxAccess.SetItemChecked(4, true);
                        if (accessList[i].Trim() == "Exchange")
                            listBoxAccess.SetItemChecked(5, true);
                    }
                }
            }
        }
    }
}
