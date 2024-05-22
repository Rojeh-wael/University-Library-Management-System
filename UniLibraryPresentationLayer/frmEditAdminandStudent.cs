using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniLibraryMangBusinessLayer;

namespace UniLibraryPresentationLayer
{
    public partial class frmEditAdminandStudent : Form
    {
        //true for Admin - False for Student 
        bool ISAdmin;
        int ID;
        clsAdmin admin;
        clsStudent student;
        public frmEditAdminandStudent(bool ISadmin,int id)
        {
            InitializeComponent();
            ISAdmin = ISadmin;
            ID = id;
        }
        private void _Load()
        {
            if ( ISAdmin )
            {
                admin = clsAdmin.find(ID);
                lblForGender.Visible = false;
                cmFroGender.Visible = false;
                lblForID.Text = "Edit Admin WIth ID = " + admin.ID.ToString(); 
                txtForFirstName.Text = admin.FirstName;
                txtForLastName.Text = admin.LastName;
                txtForEmail.Text = admin.Email;
            }
            else
            {
                student = clsStudent.find(ID);
                lblForID.Text = "Edit Student WIth ID = " + student.ID.ToString();
                txtForFirstName.Text = student.FirstName;
                txtForLastName.Text = student.LastName;
                txtForEmail.Text = student.Email;
                if (student.Gender == "M"){
                    cmFroGender.SelectedIndex = 0;
                }
                else
                {
                    cmFroGender.SelectedIndex = 1;
                }

            }
        }
        private void frmEditAdminandStudent_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnForEdit_Click(object sender, EventArgs e)
        {
            bool NotEmpty = string.IsNullOrEmpty(lblForFirstName.Text) && string.IsNullOrEmpty(lblForLastName.Text)
                && string.IsNullOrEmpty(lblForEmail.Text);

            if (ISAdmin && !NotEmpty)
            {
                admin.FirstName = txtForFirstName.Text;
                admin.LastName = txtForLastName.Text;
                admin.Email = txtForEmail.Text;

                if (admin.Save())
                {
                    MessageBox.Show("Admin Edited", "Thank You ", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Admin not Edited", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ISAdmin == false && !NotEmpty)
            {
                student.FirstName = txtForFirstName.Text;
                student.LastName = txtForLastName.Text;
                student.Email = txtForEmail.Text;   
                if (cmFroGender.SelectedIndex == 0)
                {
                    student.Gender = "M";
                }
                else
                {
                    student.Gender = "F";
                }

                if (student.Save())
                {
                    MessageBox.Show("student Edited", "Thank You ", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("student not Edited", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
