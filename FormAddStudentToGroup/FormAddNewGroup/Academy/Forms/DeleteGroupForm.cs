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
using P208_Academy.Forms;

namespace P208_Academy.Forms
{
    public partial class DeleteGroupForm : Form
    {
        public DeleteGroupForm()
        {
            InitializeComponent();
        }

        private void DeleteGroupForm_Load(object sender, EventArgs e)
        {
            // Qruplarin siyahisinin yenilenmesi ucun metodun caqirilmasi
            UpdateCombo();
        }

        private void btnDelGroup_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Are you sure?", "All book list in for this author will be deleted!", MessageBoxButtons.YesNo);

            if (question == DialogResult.Yes)
            {   //=========================  Group-un silinmesi ====================================
                // downcast edirik ve comboBoxda secilmish groupun ID nomresini groupID-ye veririk
                string groupID = ((GroupCombo)cmbDel.SelectedItem).Value;

                // GroupList-den secilmish qrupu ID-ye gore tapib veririk Group tipinde groupToDeleted-e
                // bir nov apcast olunur ki Group-un icinden lazim olana catsin
                Group groupToDeleted = GroupList.GetGroupById(groupID);

                // GroupList-den Group classina girib Groups siyahisindan 
                // ID-ci uyqun geleni silirik
                GroupList.Groups.Remove(groupToDeleted);
                //==================================================================================

                //=========== Silinen Group-un Student siyahisinin silinmesi =====================//

                // silinen group-un icindeki studentleri yeni List massivine yiqiriq
                List<Student> studentToBedeleted = StudentList.GetStudentsByGroup(groupToDeleted);

                // ve hemin massiv siralanir ve siyahidaki studentName-ler silinir
                foreach(Student studentName in studentToBedeleted)
                {
                    StudentList.Students.Remove(studentName);
                }

                // Group-larin siyahisi yenilenir
                UpdateCombo();
            }
            else
            {
                MessageBox.Show("You are cancelled deletion!");
            }
        }

        // Group-larin siyahisinin cixarilmasinin metod shekline salinmasi
        private void UpdateCombo()
        {
            // Qruplarin adlarinin qutusu tipinde yeni yerin ayrilmasi
            List<GroupCombo> comboSource = new List<GroupCombo>();

            // GroupList-de olan Groups massvinin dovre salinmasi 
            foreach (Group group in GroupList.Groups)
            {
                //her dovrede movcud olan qrup adlarinin siralanmasi
                // Yeeeni, studentin elave dilmesi zamani qruplarin siyahisi gosterilsin
                comboSource.Add(new GroupCombo
                {
                    Text = group.GroupName,
                    Value = group.GroupID
                });
            }

            // qrupun qutusunun kokune hemin qrup adlarinin elave edilmesi
            cmbDel.DataSource = comboSource;
        }

        
    }
}
