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
    public partial class frmStudent : Form
    {
        clsStudent student;
        public frmStudent(int id)
        {
            InitializeComponent();
            student = clsStudent.find(id);
        }
        private void _load()
        {
            lblforname.Text = "Hello " + student.FirstName; 
            dgvAllStudent.DataSource = clsBook.GetAllBooks();
        }

        private void btnforborrow_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(dgvAllStudent.CurrentRow.Cells[0].Value);
            clsBorrow borrow = new clsBorrow(bookid,student.ID);

            if ( borrow.Save() )
            {
                MessageBox.Show("Done ", "Thank You ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Not Done ", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            _load();
        }
    }
}
