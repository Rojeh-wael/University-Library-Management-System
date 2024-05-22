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
    public partial class frmAdmin : Form
    {
        static clsAdmin admin;

        public enum eModeForCM {Admin = 0 , Student = 1 ,Book = 2}
        eModeForCM mode;
        public frmAdmin( int id )
        {
            InitializeComponent();

            admin = clsAdmin.find( id );
        }
        private void _Load()
        {
            lblforAdminName.Text = "Hello " + admin.FirstName.ToString();

            dgvForAllAdminandBooks.DataSource = clsAdmin.GetAllAdmin();
            mode = eModeForCM.Admin; 

        }

        private void _GoToEdit (int ID){
            switch (mode)
            {
                case eModeForCM.Admin:
                    Form form = new frmEditAdminandStudent(true , ID);
                    form.ShowDialog();
                    break;

                case eModeForCM.Student:
                    Form form1 = new frmEditAdminandStudent(false, ID);
                    form1.ShowDialog();
                    break;
                    case eModeForCM.Book:
                    //MessageBox.Show("You Cannot Edit Book With ID " + ID, "Sorry", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Form form2 = new frmEditBook(ID);
                    form2.ShowDialog();
                    break;
            }
        
        
        }
        private void _DeleteAdmin(int ID)
        {
            if (clsAdmin.DeleteAdmin(ID))
            {
                MessageBox.Show("Admin Deleted", "Thank You",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Admin not Deleted", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _DeleteStudent(int ID)
        {
            if (clsStudent.DeleteStudent(ID))
            {
                MessageBox.Show("Student Deleted", "Thank You", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Student not Deleted", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void _DeleteBook(int ID)
        {
            if (clsBook.DeleteBookWithID(ID) )
            {
                MessageBox.Show("Book Deleted", "Thank You", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Book not Deleted", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void _Delete(int ID)
        {
            switch (mode) {  
                case eModeForCM.Admin:
                    _DeleteAdmin(ID);
                   break; 
                case eModeForCM.Student:
                    _DeleteStudent(ID);
                    break;
                case eModeForCM.Book:
                    _DeleteBook(ID);
                    break;

            }
        }




        private void frmAdmin_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void btnforBrowsingbooks_Click(object sender, EventArgs e)
        {
            dgvForAllAdminandBooks.DataSource= clsBook.GetAllBooks();
            mode = eModeForCM.Book;
        }

        private void btnforAdmin_Click(object sender, EventArgs e)
        {
            dgvForAllAdminandBooks.DataSource = clsAdmin.GetAllAdmin();
            mode = eModeForCM.Admin;
        }

        

       

        private void btntoAddAdmin_Click(object sender, EventArgs e)
        {
            Form form = new frmAddAdminandStudent(true);
            form.ShowDialog();    
        }

        private void btntoAddStudent_Click(object sender, EventArgs e)
        {
            Form form = new frmAddAdminandStudent(false);
            form.ShowDialog();
        }

        private void btnForStudent_Click(object sender, EventArgs e)
        {
            dgvForAllAdminandBooks.DataSource = clsStudent.GetAllStudent();
            mode = eModeForCM.Student;
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case eModeForCM.Student:
                    _GoToEdit(Convert.ToInt32( dgvForAllAdminandBooks.CurrentRow.Cells[0].Value));
                    break; 
                case eModeForCM.Admin:
                    _GoToEdit(Convert.ToInt32(dgvForAllAdminandBooks.CurrentRow.Cells[0].Value));
                    break ;
                case eModeForCM.Book:
                    _GoToEdit(Convert.ToInt32(dgvForAllAdminandBooks.CurrentRow.Cells[0].Value));
                    break;

            }
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case eModeForCM.Student:
                    _Delete(Convert.ToInt32(dgvForAllAdminandBooks.CurrentRow.Cells[0].Value));
                    break;
                case eModeForCM.Admin:
                    _Delete(Convert.ToInt32(dgvForAllAdminandBooks.CurrentRow.Cells[0].Value));
                    break;
                case eModeForCM.Book:
                    _Delete(Convert.ToInt32(dgvForAllAdminandBooks.CurrentRow.Cells[0].Value));
                    break;

            }
        }

        private void btnToAddBook_Click(object sender, EventArgs e)
        {
            Form form = new frmAddBook(admin.ID);
            form.ShowDialog();
        }
    }
}
