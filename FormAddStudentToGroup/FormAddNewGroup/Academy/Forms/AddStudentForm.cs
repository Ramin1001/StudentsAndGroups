using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P208_Academy.Data;

namespace P208_Academy
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
           
            // Qruplarin adlarinin qutusu tipinde yeni yerin ayrilmasi
            List<GroupCombo> comboSource = new List<GroupCombo>();

            // GroupList-de olan Groups massvinin dovre salinmasi 
            foreach (Group group in GroupList.Groups)
            {
                //her dovrede movcud olan qrup adlarinin siralanmasi
                // Yeeeni, studentin elave edilmesi zamani qruplarin siyahisi gosterilsin
                comboSource.Add(new GroupCombo
                {
                    Text = group.GroupName,
                    Value = group.GroupID
                });
            }

            // qrupun qutusunun kokune hemin qrup adlarinin elave edilmesi
            cmbGroups.DataSource = comboSource;  
        }

        // Add Student duymesine basildiqda bash verenler
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Add student forumundaki inputlara daxil edilenlerin yerlerine oyulmasi
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string email = txtEmail.Text;
            // secilmish qrupun ID nomresinin  groupID-ye verilmesi
            string groupId = ((GroupCombo)cmbGroups.SelectedItem).Value;

            // Group tipinden deyishen yaradiriq
            // ve Qrup siyahisinin ID-lerinden secilmishini deyishene veririk
            Group selectedGroup = GroupList.GetGroupById(groupId);

            if(selectedGroup == null) // eger secilmish qrup yoxdursa
            {
                MessageBox.Show("Group doesn't exist");
                return;
            }

            // Studentlerin siyahisina yeni studentin elave elave edilmesi
            StudentList.Add(new Student 
            {
                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                Group = selectedGroup
            });

            //txtFirstname.Text = "";
            //txtLastname.Text = "";
            //txtEmail.Text = "";
            
        }
    }
}
