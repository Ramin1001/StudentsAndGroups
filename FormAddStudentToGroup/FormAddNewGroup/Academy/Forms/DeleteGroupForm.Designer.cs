namespace P208_Academy.Forms
{
    partial class DeleteGroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddStudent = new System.Windows.Forms.Panel();
            this.cmbDel = new System.Windows.Forms.ComboBox();
            this.lblGroupID = new System.Windows.Forms.Label();
            this.btnDelGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddStudent
            // 
            this.pnlAddStudent.Controls.Add(this.cmbDel);
            this.pnlAddStudent.Controls.Add(this.lblGroupID);
            this.pnlAddStudent.Controls.Add(this.btnDelGroup);
            this.pnlAddStudent.Controls.Add(this.label2);
            this.pnlAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddStudent.Location = new System.Drawing.Point(0, 75);
            this.pnlAddStudent.Name = "pnlAddStudent";
            this.pnlAddStudent.Size = new System.Drawing.Size(434, 276);
            this.pnlAddStudent.TabIndex = 9;
            // 
            // cmbDel
            // 
            this.cmbDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDel.FormattingEnabled = true;
            this.cmbDel.Location = new System.Drawing.Point(46, 73);
            this.cmbDel.Name = "cmbDel";
            this.cmbDel.Size = new System.Drawing.Size(331, 32);
            this.cmbDel.TabIndex = 10;
            // 
            // lblGroupID
            // 
            this.lblGroupID.AutoSize = true;
            this.lblGroupID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupID.Location = new System.Drawing.Point(42, 554);
            this.lblGroupID.Name = "lblGroupID";
            this.lblGroupID.Size = new System.Drawing.Size(0, 22);
            this.lblGroupID.TabIndex = 9;
            // 
            // btnDelGroup
            // 
            this.btnDelGroup.BackColor = System.Drawing.Color.Maroon;
            this.btnDelGroup.FlatAppearance.BorderSize = 0;
            this.btnDelGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelGroup.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelGroup.Location = new System.Drawing.Point(46, 152);
            this.btnDelGroup.Name = "btnDelGroup";
            this.btnDelGroup.Size = new System.Drawing.Size(331, 72);
            this.btnDelGroup.TabIndex = 6;
            this.btnDelGroup.Text = "Delete Group";
            this.btnDelGroup.UseVisualStyleBackColor = false;
            this.btnDelGroup.Click += new System.EventHandler(this.btnDelGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Group:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 75);
            this.label1.TabIndex = 8;
            this.label1.Text = "Delete Group Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 332);
            this.Controls.Add(this.pnlAddStudent);
            this.Controls.Add(this.label1);
            this.Name = "DeleteGroupForm";
            this.Text = "DeleteGroupForm";
            this.Load += new System.EventHandler(this.DeleteGroupForm_Load);
            this.pnlAddStudent.ResumeLayout(false);
            this.pnlAddStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddStudent;
        private System.Windows.Forms.ComboBox cmbDel;
        private System.Windows.Forms.Label lblGroupID;
        private System.Windows.Forms.Button btnDelGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}