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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if ( radiobtn_forAdmin.Checked && !string.IsNullOrEmpty( txtbox_forID.Text ))
            {
                clsAdmin admin = clsAdmin.find(Convert.ToInt32(txtbox_forID.Text));
                if ( admin != null )
                {
                    Form form = new frmAdmin(Convert.ToInt32(txtbox_forID.Text));
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Admin not Found ... try again please", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if (radiobtn_forStudent.Checked && !string.IsNullOrEmpty(txtbox_forID.Text))
            {
                clsStudent student = clsStudent.find(Convert.ToInt32(txtbox_forID.Text));
                if (student != null)
                {
                    Form form = new frmStudent(Convert.ToInt32(txtbox_forID.Text));
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Student not Found ... try again please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            if( radiobtn_forAdmin.Checked)
            {
                Form form = new frmAddAdminandStudent(true);
                form.ShowDialog();  
            }
            if (radiobtn_forStudent.Checked)
            {
                Form form = new frmAddAdminandStudent(false);
                form.ShowDialog();
            }
        }
    }
}
