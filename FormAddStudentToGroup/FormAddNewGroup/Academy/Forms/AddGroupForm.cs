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
    public partial class AddGroupForm : Form
    {
        public AddGroupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Group-un adinin hec bir boshluq buraxmadan yazilmasi
            // ve groupName-e verilmesi
            string groupName = txtGroupName.Text.Trim();

            // eger null veya boshdursa
            if (string.IsNullOrEmpty(groupName))
            {
                // ERROR mesajinin verilmersi
                MessageBox.Show("Group name is not valid", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // eger GroupListde bu ad varsa
            if (GroupList.ContainsGroupName(groupName))
            {
                // ERROR mesaji verilir 
                MessageBox.Show("Group name is duplicate", "Failed!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //user uyqun qrup adini daxil etdi ve bu addan yoxdur
            //bu halda yeni group-un Grouplist-e elave edilmesi
            GroupList.Add(new Group(groupName));

            // Elave edildikden sonra setrin bosh gorsedilmesi
            txtGroupName.Text = ""; 

            // Melumat mesajinin verilmesi
            MessageBox.Show("New Group was successfully added", "Success!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
