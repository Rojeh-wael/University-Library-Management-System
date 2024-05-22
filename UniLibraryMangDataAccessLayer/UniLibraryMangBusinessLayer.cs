using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;

namespace UniLibraryMangDataAccessLayer
{
    public class clsAdminDataAccess
    {
        public static bool GetAdminInfoByID(int ID ,ref string FirstName, ref string LastName,
                      ref string Email)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ADMIN WHERE AdminID = @AdminID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdminID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                  
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewAdmin(string FirstName, string LastName,
            string Email)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int AdminID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO ADMIN (FirstName, LastName, Email)
                             VALUES (@FirstName, @LastName, @Email);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);

      


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AdminID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return AdminID;
        }

        public static bool UpdateAdmin(int ID, string FirstName, string LastName,
            string Email)
        {
           
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  ADMIN  
                            set FirstName = @FirstName, 
                                LastName = @LastName, 
                                Email = @Email 
                                where AdminID = @AdminID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdminID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);



            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllAdmin()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM ADMIN";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool IsAdminExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM ADMIN WHERE AdminID = @AdminID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdminID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool DeleteAdmin(int AdminID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete MANAGE 
                                where AdminID = @AdminID;
                            Delete ADMIN 
                                where AdminID = @AdminID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AdminID", AdminID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                 Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
    }


    public class clsStudentDataAccess
    {
        public static bool GetStudentInfoByID(int ID, ref string FirstName, ref string LastName,
                      ref string Email,ref string Gender)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM STUDENT WHERE StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Email = (string)reader["Email"];
                    Gender = (string)reader["Gender"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int AddNewStudent(string FirstName, string LastName,
            string Email,string Gender)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int StudentID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO STUDENT (FirstName, LastName, Email,Gender)
                             VALUES (@FirstName, @LastName, @Email,@Gender);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    StudentID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return StudentID;
        }

        public static bool UpdateStudent(int ID, string FirstName, string LastName,
            string Email,string Gender)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  STUDENT  
                            set FirstName = @FirstName, 
                                LastName = @LastName, 
                                Email = @Email,
                                Gender = @Gender
                                where StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", ID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Gender", Gender);




            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllStudent()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM STUDENT";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool IsStudentExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM STUDENT WHERE StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool DeleteStudent(int StudentID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete BORROW 
                                where StudentID = @StudentID
                             Delete STUDENT 
                                where StudentID = @StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@StudentID", StudentID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
    }

    public class clsBookDataAccess
    {

        public static bool GetBookInfoByID(int id ,ref int ISBN, ref string title, ref string category,
                                    ref int copies, ref string prod_year, ref string author, ref string publisher , ref int AutherID ,ref int PubisherID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT BOOK.* ,AUTHOR.Name AS AutherName , PUBLISHER.Name As PublisherName FROM BOOK 
	                inner join PUBLISHER on BOOK.PubisherID = PUBLISHER.PublisherID 
	                inner join AUTHOR on BOOK.AutherID = AUTHOR.AutherID
	                where BookID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    ISBN = (int)reader["ISNB"];
                    title = (string)reader["Title"];
                    category = (string)reader["Category"];
                    copies = (int)reader["Copies"];
                    prod_year = (string)reader["PublicationYear"];
                    author = (string)reader["AutherName"];
                    publisher = (string)reader["PublisherName"];
                    AutherID = (int)reader["AutherID"];
                    PubisherID = (int)reader["PubisherID"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Handle or log the exception
                 Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static int AddNewBook(int ISNB , string Title, string Category, int Copies, string Prod_year, int AutherID, int PubisherID)
        {
            //this function will return the new contact id if succeeded and -1 if not.
           int bookID = -1;
            //int.TryParse(Auther, out int AutherID);
            //int.TryParse(Pubisher, out int PubisherID);
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"insert into BOOK (ISNB,Title,Category,Copies,PublicationYear,AutherID,PubisherID)
	                        values (@ISNB,@Title,@Category,@Copies,@PublicationYear,@AutherID,@PubisherID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ISNB", ISNB);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Category", Category);
            command.Parameters.AddWithValue("@Copies", Copies);
            command.Parameters.AddWithValue("@PublicationYear", Prod_year);
            command.Parameters.AddWithValue("@AutherID", AutherID);
            command.Parameters.AddWithValue("@PubisherID", PubisherID);

            
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    bookID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return bookID;
        }

        public static bool UpdateBook(int ISNB, string Title, string Category, int Copies, string Prod_year, int Auther, int Pubisher)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  BOOK  
                            set Title = @Title, 
                                Category = @Category, 
                                Copies = @Copies,
                                PublicationYear = @PublicationYear, 
                                AutherID = @AutherID, 
                                PubisherID = @PubisherID 
                                where ISNB = @ISNB ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ISNB", ISNB);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Category", Category);
            command.Parameters.AddWithValue("@Copies", Copies);
            command.Parameters.AddWithValue("@PublicationYear", Prod_year);
            command.Parameters.AddWithValue("@AutherID", Auther);
            command.Parameters.AddWithValue("@PubisherID", Pubisher);



            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static DataTable GetAllBooks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT BOOK.* ,AUTHOR.Name AS AutherName , PUBLISHER.Name As PublisherName FROM BOOK 
	                inner join PUBLISHER on BOOK.PubisherID = PUBLISHER.PublisherID 
	                inner join AUTHOR on BOOK.AutherID = AUTHOR.AutherID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static bool IsBookExist(int ID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM BOOK WHERE ISNB = @ISNB";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ISNB", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool DeleteBook(int BookID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from MANAGE 
							    where BookID = @BookID;
                             delete from BORROW 
							    where BookID = @BookID;
                             Delete BOOK 
                                where BookID = @BookID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                 Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }


    }

    public class clsManageDataAccess
    {
        public static int AddNewBookRecored(int BookID, int AdminID,
            string OpType)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int ManageID = -1;
        
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Manage (BookID, AdminID, OperationType,OperationDate)
                             VALUES (@BookID, @AdminID,@OperationType,FORMAT(GETDATE(),'dd/MM/yyyy'));
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@AdminID", AdminID);
            command.Parameters.AddWithValue("@OperationType", OpType);




            try
            {
                connection.Open();
              
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ManageID = insertedID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return ManageID;
        }

        public static DataTable GetAllManageBooks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select MANAGE.ManageID , MANAGE.AdminID ,MANAGE.BookID ,MANAGE.OperationDate ,BOOK.ISNB ,Admin.FirstName from MANAGE
                                inner join BOOK on MANAGE.BookID = BOOK.BookID 
                                inner join ADMIN on MANAGE.AdminID = ADMIN.AdminID ";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    }
    public class clsBorrowDataAccess {
        public static int AddNewBookBorrow(int BookID, int StudentID)
        {
            //this function will return the new contact id if succeeded and -1 if not.
            int BorrowID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO BORROW (BookID, StudentID,BorrowDate,ReturnDate)
                             VALUES (@BookID, @StudentID,FORMAT(GETDATE(),'dd/MM/yyyy'),FORMAT((GETDATE()+5),'dd/MM/yyyy'));
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@StudentID", StudentID);




            try
            {
                connection.Open();
              
                object result = command.ExecuteScalar();
             

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    BorrowID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }


            return BorrowID;
        }

        public static DataTable GetAllBorrowBooks()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select BORROW.* , BOOK.ISNB ,STUDENT.FirstName from BORROW 
                            inner join BOOK on BORROW.BookID = BOOK.BookID 
                            inner join STUDENT on STUDENT.StudentID = BORROW.StudentID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    }


}
