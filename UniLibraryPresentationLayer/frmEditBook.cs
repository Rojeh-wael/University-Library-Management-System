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
    public partial class frmEditBook : Form
    {
        clsBook book;
        public frmEditBook(int bookID)
        {
            InitializeComponent();
            book = clsBook.find(bookID);
        }
        private void _load()
        {
            lblforBookID.Text = "Edit Book With ID = "+book.BookID;
            txtforISNB.Text   = book.ISNB.ToString();
            txtForTitle.Text = book.Title;
            txtProd_year.Text =book.Prod_year;
            txtforCategory.Text =book.Category; 
            txtforCopies.Text = book.Copies.ToString();
            txtforAuther.Text = book.AutherID.ToString();
            txtforPubisher.Text = book.PubisherID.ToString();
            lblForPubisherName.Text ="Publisher Name :" + book.Pubisher.ToString();
            lblforAuthorName.Text = "Auther Name :" + book.Auther.ToString();

        }
        private bool NotEmptytextbox()
        {
            return !(string.IsNullOrEmpty(txtforISNB.Text) || string.IsNullOrEmpty(txtForTitle.Text) ||
                string.IsNullOrEmpty(txtforCategory.Text) || string.IsNullOrEmpty(txtforCopies.Text) ||
                string.IsNullOrEmpty(txtforAuther.Text) || string.IsNullOrEmpty(txtProd_year.Text) ||
                string.IsNullOrEmpty(txtforPubisher.Text));
        }
        private void frmEditBook_Load(object sender, EventArgs e)
        {
            _load();
        }

        private void btnforAdd_Click(object sender, EventArgs e)
        { 
            if (NotEmptytextbox())
            {
                book.ISNB = Convert.ToInt32(txtforISNB.Text);
                book.Title = txtForTitle.Text;
                book.Category= txtforCategory.Text;
                book.AutherID= Convert.ToInt32(txtforAuther.Text);
                book.PubisherID= Convert.ToInt32(txtforPubisher.Text); 
                book.Prod_year = txtProd_year.Text;
                book.Copies = Convert.ToInt32(txtforCopies.Text);

                if (book.Save())
                    {
                    
                    MessageBox.Show("Book data Saved with ID = " + book.BookID.ToString(), "Thank You", MessageBoxButtons.OK);
                        this.Close();
                     
                    }
                else
                    {
                     MessageBox.Show("Book data not Saved ", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

            }
        }



    }
}
