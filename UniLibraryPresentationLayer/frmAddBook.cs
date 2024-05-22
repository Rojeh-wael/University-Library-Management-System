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
    public partial class frmAddBook : Form
    {
        clsBook book;
        int adminid;
        int bookID;
        public frmAddBook(int id,int bookid =-1  )
        {
            InitializeComponent();
            bookID = bookid;
            if (bookID == -1)
            {
                book = new clsBook();
            }
            else
            {
                book = clsBook.find(bookid);
            }
           adminid = id;
        }

       private bool NotEmptytextbox()
        {
            return !(string.IsNullOrEmpty(txtforISNB.Text) || string.IsNullOrEmpty(txtForTitle.Text) ||
                string.IsNullOrEmpty(txtforCategory.Text) || string.IsNullOrEmpty(txtforCopies.Text) ||
                string.IsNullOrEmpty(txtforAuther.Text) || string.IsNullOrEmpty(txtProd_year.Text) ||
                string.IsNullOrEmpty(txtforPubisher.Text));
        }

        private void btnforAdd_Click(object sender, EventArgs e)
        {
            if (NotEmptytextbox())
            {
                book.ISNB = Convert.ToInt32( txtforISNB.Text);
                book.Title = txtForTitle.Text;
                book.Category= txtforCategory.Text;
                book.AutherID= Convert.ToInt32(txtforAuther.Text);
                book.PubisherID= Convert.ToInt32(txtforPubisher.Text); 
                book.Prod_year = txtProd_year.Text;
                book.Copies = Convert.ToInt32(txtforCopies.Text);

                if (book.Save())
                {
                    MessageBox.Show("Book data Saved with ID = " + book.BookID.ToString(), "Thank You", MessageBoxButtons.OK);
                    clsManage manage = new clsManage(book.BookID,adminid);
                    if (manage.Save())
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Book data not Saved ", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        
    }
}
