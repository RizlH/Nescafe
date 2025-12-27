using System.Windows.Forms;
using Nescafe.Data;
using Nescafe.Models;
using Nescafe.Services;
using System.Windows.Forms.VisualStyles;

namespace Nescafe.Forms.AdminMenus
{
    public partial class MemberPage : UserControl
    {
        public MemberPage()
        {
            InitializeComponent();
        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            loadGridMember();
            string? id = labelCardId.Text;
            if (id == null || id == "" || id == "...")
            {
                buttonUpdate.Visible = false;
            }
        }

        private void loadGridMember()
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
           // memberBindingSource.DataSource = service.SetGrid();
            dataGridViewMember.Columns[0].DataPropertyName = "Id";
            dataGridViewMember.Columns[0].Visible = false;
            dataGridViewMember.Columns[1].DataPropertyName = "MemberId";
            dataGridViewMember.Columns[2].DataPropertyName = "Fullname";
            dataGridViewMember.Columns[3].DataPropertyName = "ModDate";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            AppDbContext db = new AppDbContext();
            MemberService service = new MemberService(db);
            int memberId = int.Parse(labelMemberId.Text);
            Member? member = service.FindById(memberId);
            if (member != null)
            {
                if (comboBoxStatus.SelectedIndex == 0)
                    member.IsActive = true;
                else
                    member.IsActive = false;

                member.ModDate = DateTime.UtcNow;
                service.Update(member);
            }
            loadGridMember();
        }

        private void dataGridViewMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int memberId = int.Parse(dataGridViewMember.Rows[e.RowIndex].Cells[0].Value.ToString());
                AppDbContext db = new AppDbContext();
                MemberService service = new MemberService(db);
                Member? member = service.FindById(memberId);
                if (member != null)
                {
                    labelFullName.Text = member.FullName;
                    labelEmail.Text = member.Email;
                    labelPhone.Text = member.Phone;
                    labelPhoneAlt.Text = member.PhoneAlt;
                    labelAddress.Text = member.Address;
                    labelJoinDate.Text = member.JoinDate.ToString("f");
                    labelMemberId.Text = member.MemberId;
                    labelCardId.Text = member.IdCard;
                    labelMemberId.Text = member.Id.ToString();
                    if (member.IsActive)
                        comboBoxStatus.SelectedIndex = 0;
                    else
                        comboBoxStatus.SelectedIndex = 1;
                    buttonUpdate.Visible = true;
                }
                else
                {
                    buttonUpdate.Visible = false;
                }
            }
        }
    }
}