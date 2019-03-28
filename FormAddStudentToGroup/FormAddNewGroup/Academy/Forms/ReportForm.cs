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

namespace P208_Academy.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Cedveli student list ile doldurulmasi
            dgwStudents.DataSource = StudentList.Students;

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

            cmbGroups.Items.Add("All");  // ALL hissesinin elave edilmesi

            // qruplarin ComboBox-a elave edilmesi
            cmbGroups.Items.AddRange(comboSource.ToArray());
        }

        // ComboBox-sun event yerinde olan cmbGroups_SelectedIndexChanged yerine click eliyib
        //  yeni event elave edirik
        private void cmbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            string groupName = cmbGroups.Text; // qruplarin adin groupname-e veririk

            // Student cedvelinin Columns-da Group eyrinin indexsini veririk index deyishenine
            int index = dgwStudents.Columns["Group"].Index;

            // Student cedvelinin siralarinin dovre salinmasi
            foreach (DataGridViewRow item in dgwStudents.Rows)
            {
                // eger siradaki qrupun adi combobox-daki qrupun adina beraberdirse
                if (item.Cells[index].Value.ToString() == groupName)
                {
                    // siranin Default Bakground rengini yashil ele
                    item.DefaultCellStyle.BackColor = Color.Green;
                    //item.DefaultCellStyle.Font = new System.Drawing.Font("Showcard", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    // eks halda siranin Default Bakground rengini aq ele
                    item.DefaultCellStyle.BackColor = Color.White;
                    //item.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
    }
}
