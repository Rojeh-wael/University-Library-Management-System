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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniLibraryPresentationLayer
{
    public partial class frmAddAdminandStudent : Form
    {
        //true for ADmin - False For Student 
        bool ISAdmin;
        public frmAddAdminandStudent(bool ISadmin)
        {
            InitializeComponent();
            ISAdmin = ISadmin; 
        }
        private void _Load()
        {
            if (ISAdmin)
            {
                lblForGender.Visible = false;   
                cbFroGender.Visible = false;
            }
        }
        private void frmAddAdminandStudent_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btntoAddnewUser_Click(object sender, EventArgs e)
        {

            bool NotEmpty = string.IsNullOrWhiteSpace(txtForFirstNAme.Text) || string.IsNullOrWhiteSpace(txtForLAstName.Text)
                  || string.IsNullOrWhiteSpace(txtForEmail.Text);
            if (ISAdmin &&   ! NotEmpty )
            {
              clsAdmin admin = new clsAdmin();  
                admin.FirstName = txtForFirstNAme.Text;
                admin.LastName = txtForLAstName.Text;
                admin.Email = txtForEmail.Text;
                if (admin.Save())
                {
                    MessageBox.Show("Admin Data Saved Successfully with id =  " + admin.ID.ToString(), "Data Saved", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("Admin Data not Saved ", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ISAdmin == false && !NotEmpty)
            {
                clsStudent student = new clsStudent();
                student.FirstName = txtForFirstNAme.Text;
                student.LastName = txtForLAstName.Text;
                student.Email = txtForEmail.Text;
                if (cbFroGender.SelectedIndex== 0)
                    student.Gender = "M";
                else
                    student.Gender = "F";

                if (student.Save())
                {
                    MessageBox.Show("student Data Saved Successfully with id =  " + student.ID.ToString(), "Data Saved", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("student Data not Saved ", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
