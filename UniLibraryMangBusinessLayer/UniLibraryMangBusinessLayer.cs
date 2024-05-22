
using System;
using System.Data;
using UniLibraryMangDataAccessLayer;

namespace UniLibraryMangBusinessLayer
{
    public class clsAdmin
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
    




    public clsAdmin()

    {
        this.ID = -1;
        this.FirstName = "";
        this.LastName = "";
        this.Email = "";

            Mode = enMode.AddNew;
            
    }

    private clsAdmin(int id, string firstname, string lastname,
        string email)

    {
        this.ID = id;
        this.FirstName = firstname;
        this.LastName = lastname;
        this.Email = email;

        Mode = enMode.Update;

    }

    private bool _addnewadmin()
    {
        //call dataaccess layer 

       this.ID = clsAdminDataAccess.AddNewAdmin(this.FirstName, this.LastName, this.Email);

        return (this.ID != -1);
    }

        private bool _updateadmin()
        {
            //call dataaccess layer 
            return clsAdminDataAccess.UpdateAdmin(this.ID, this.FirstName, this.LastName, this.Email);

        }

        public static clsAdmin find(int id)
    {

        string firstname = "", lastname = "", email = "";


        if (clsAdminDataAccess.GetAdminInfoByID(id, ref firstname, ref lastname,
                      ref email))

            return new clsAdmin(id, firstname, lastname,
                       email);
        else
            return null;

    }

    public bool Save()
    {


        switch (Mode)
        {
            case enMode.AddNew:
                if (_addnewadmin())
                {

                    Mode = enMode.Update;
                    return true;
                }
                else
                {
                    return false;
                }

            case enMode.Update:
                    return _updateadmin();

            }

        return false;
    }

        public static DataTable GetAllAdmin()
        {
            return clsAdminDataAccess.GetAllAdmin();

        }



        public static bool IsAdminExist(int id)
        {
            return clsAdminDataAccess.IsAdminExist(id);
        }

        public static bool DeleteAdmin(int ID)
        {
            return clsAdminDataAccess.DeleteAdmin(ID);
        }
    }

    public class clsStudent
    {

        public enum enmode { addnew = 0, update = 1 };
        public enmode Mode = enmode.addnew;

        public int ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }

        public string Gender { set; get; }

        public clsStudent()

        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Gender = "";
            Mode = enmode.addnew;

        }

        private clsStudent(int id, string firstname, string lastname,
            string email, string gender)

        {
            this.ID = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Gender = gender;
            Mode = enmode.update;

        }

        private bool _addnewstudent()
        {
            //call dataaccess layer 

            this.ID = clsStudentDataAccess.AddNewStudent(this.FirstName, this.LastName, this.Email, this.Gender);

            return (this.ID != -1);
        }

        private bool _updatestudent()
        {
            //call dataaccess layer 

            return clsStudentDataAccess.UpdateStudent(this.ID, this.FirstName, this.LastName, this.Email, this.Gender);

        }

        public static clsStudent find(int id)
        {

            string firstname = "", lastname = "", email = "", gender = "";


            if (clsStudentDataAccess.GetStudentInfoByID(id, ref firstname, ref lastname,
                          ref email, ref gender))

                return new clsStudent(id, firstname, lastname,
                           email, gender);
            else
                return null;

        }

        public bool Save()
        {


            switch (Mode)
            {
                case enmode.addnew:
                    if (_addnewstudent())
                    {

                        Mode = enmode.update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enmode.update:

                    return _updatestudent();

            }




            return false;
        }

        public static DataTable GetAllStudent()
        {
            return clsStudentDataAccess.GetAllStudent();

        }



        public static bool IsStudentExist(int id)
        {
            return clsStudentDataAccess.IsStudentExist(id);
        }

        public static bool DeleteStudent(int ID)
        {
            return clsStudentDataAccess.DeleteStudent(ID);
        }

    }

    public class clsBook
    {

        public enum enmode { addnew = 0, update = 1 };
        public enmode Mode = enmode.addnew;
            
        public int BookID {  get; set; }
        public int ISNB { set; get; }
        public string Title { set; get; }
        public string Category { set; get; }
        public int Copies { set; get; }
        public string Prod_year { set; get; }
        public string Auther { set; get; }
        public string Pubisher { set; get; }  
        public  int AutherID {  set; get; }
        public int PubisherID {  set; get; }
        public clsBook()

        {
            this.BookID = -1;
            this.ISNB = -1;
            this.Title = "";
            this.Category = "";
            this.Copies = -1;
            this.Prod_year = "";
            this.Auther = "";
            this.Pubisher = "";
            this.AutherID =-1;
            this.PubisherID = -1;
            Mode = enmode.addnew;

        }

        private clsBook(int BookiD ,int ISNB, string title, string category,
            int copies, string prod_year, string auther , string Pubisher, int AutherID , int PubisherID)
        {
            this.BookID = BookiD;
            this.ISNB = ISNB;
            this.Title = title;
            this.Category = category;
            this.Copies = copies;
            this.Prod_year = prod_year;
            this.Auther = auther;
            this.Pubisher = Pubisher;
            this.AutherID = AutherID;
            this.PubisherID=PubisherID;
            Mode = enmode.update;

        }

        private bool _addnewBook()
        {
            //call dataaccess layer 
            
         this.BookID = clsBookDataAccess.AddNewBook(this.ISNB,this.Title, this.Category, this.Copies, this.Prod_year, this.AutherID, this.PubisherID);

            return (this.BookID != -1);
        }

        private bool _updateBook()
        {
            //call dataaccess layer 
            return clsBookDataAccess.UpdateBook(this.ISNB, this.Title, this.Category, this.Copies, this.Prod_year, this.AutherID, this.PubisherID);

        }

        public static clsBook find(int ID)
        {

            string title = "", category = "", auther = "", prod_year = "", Pubisher = "";
              int   PubisherID= -1 , AutherID= -1;
            int copies = -1 ,ISNB = -1;
          
            if (clsBookDataAccess.GetBookInfoByID(ID,ref ISNB, ref title, ref category,
                          ref copies, ref prod_year, ref auther,ref Pubisher,ref AutherID ,ref PubisherID))

                return new clsBook(ID,ISNB, title, category,
                           copies, prod_year, auther, Pubisher, AutherID, PubisherID);
            else
                return null;

        }
         
        public bool Save()
        {
            switch (Mode)
            {
                case enmode.addnew:
                    if (_addnewBook())
                    {

                        Mode = enmode.update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enmode.update:

                    return _updateBook();

            }

            return false;
        }

        public static DataTable GetAllBooks()
        {
            return clsBookDataAccess.GetAllBooks();

        }



        public static bool IsBoexist(int id)
        {
            return clsBookDataAccess.IsBookExist(id);
        }



        public static bool DeleteBookWithID(int ID)
        {
            return clsBookDataAccess.DeleteBook(ID);
        }

    }

    public class clsManage
    {

 
        public int ManageID { set; get; }
        public int BookID { set; get; }
        public int AdminID { set; get; }

        public string OpDate { set; get; }
        public string OpType { set; get; }


        public clsManage(int BookID, int AdminID)
        {
            this.ManageID = -1;
            this.BookID = BookID;
            this.AdminID = AdminID;
            this.OpDate = "";
            this.OpType = "Add";
        }

        private bool _addnewBookManage()
        {
            //call dataaccess layer 

            this.ManageID = clsManageDataAccess.AddNewBookRecored(this.BookID, this.AdminID, this.OpType);
         

            return (this.ManageID != -1);
        }

        public bool Save()
        {


                    if (_addnewBookManage())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

          
        }

        public static DataTable GetAllManageBook()
        {
            return clsManageDataAccess.GetAllManageBooks();

        }


    }

    public class clsBorrow
    {
        public int BorrowID { set; get;}
        public int BookID { set; get;}  
        public int StudentID { set; get;}  
        public string BorrowDate { set; get;}  
        public string ReturnDate { set; get;}  

       public clsBorrow(int bookID , int StudentID) {
            this.BookID = bookID;
            this.StudentID = StudentID;
            this.BorrowDate = "";
            this.ReturnDate = "";
        }
        private bool _addnewBookBorrow()
        {
            //call dataaccess layer 

            this.BorrowID = clsBorrowDataAccess.AddNewBookBorrow(this.BookID, this.StudentID);

            return (this.BorrowID != -1);
        }

        public bool Save()
        {


            if (_addnewBookBorrow())
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static DataTable GetAllBorrowBook()
        {
            return clsBorrowDataAccess.GetAllBorrowBooks();

        }

    }

}