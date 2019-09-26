using System;
using System.Data;
using System.Data.SqlClient;

public class DBQuery
{
    public SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    SqlConnection connection;
    public DBQuery()
    {
        builder.DataSource = "LAPTOP\\SQLEXPRESS";
        builder.UserID = "user1";
        builder.Password = "user1";
        builder.InitialCatalog = "LibraryDB";
        connection = new SqlConnection(builder.ConnectionString);
    }
    public bool DBLogin(string username, string password)
    {
        try
        {


            String sql = "SELECT FirstName, LastName FROM Personel where Username=@username and Password=@password;";
            connection.Open();
            string firstname = "";
            string lastname = "";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        firstname = reader.GetString(0);
                        lastname = reader.GetString(1);
                    }
                }
            }
            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }


    }
    public DataTable DBTableFill(string table)
    {
        try
        {
            String sql = "SELECT * FROM "+ table +";";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            return dt;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return null;
        }

    }

    public DataTable DBTablesBooksUsersJoin()
    {
        try
        {
            String sql = "SELECT B.BookID,B.Title,B.ISBN, B.Availability,BU.LendDate,BU.ReturnDate,BU.LibraryUserID FROM Books B INNER JOIN BooksUsers BU ON B.BookID = BU.BookID;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            return dt;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return null;
        }

    }

    public bool DBInsertBook(string Title, string ISBN)
    {
        try
        {
            String sql = "INSERT INTO Books (Title,ISBN,Availability) values(@Title,@ISBN,1);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdateBook(string oldTitle, string oldISBN, string newTitle,string newISBN)
    {
        try
        {
            String sql = "UPDATE Books SET Title = @newTitle, ISBN = @newISBN WHERE Title = @oldTitle AND ISBN = @oldISBN;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@newTitle", newTitle);
            command.Parameters.AddWithValue("@newISBN", newISBN);
            command.Parameters.AddWithValue("@oldTitle", oldTitle);
            command.Parameters.AddWithValue("@oldISBN", oldISBN);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBDeleteBook(string Title, string ISBN)
    {
        try
        {
            String sql = "DELETE FROM Books WHERE Title=@Title AND ISBN=@ISBN;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBInsertAuthor(string FirstName, string LastName)
    {
        try
        {
            String sql = "INSERT INTO Authors (FirstName,LastName) values(@FirstName,@LastName);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdateAuthor(string oldFirstName, string oldLastName, string newFirstName, string newLastName)
    {
        try
        {
            String sql = "UPDATE Authors SET FirstName = @newFirstName, LastName = @newLastName WHERE FirstName = @oldFirstName AND LastName = @oldLastName;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@newFirstName", newFirstName);
            command.Parameters.AddWithValue("@newLastName", newLastName);
            command.Parameters.AddWithValue("@oldFirstName", oldFirstName);
            command.Parameters.AddWithValue("@oldLastName", oldLastName);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBDeleteAuthor(string FirstName, string LastName)
    {
        try
        {
            String sql = "DELETE FROM Authors WHERE FirstName=@FirstName AND LastName=@LastName;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBInsertPublisher(string Name, string Mark)
    {
        try
        {
            String sql = "INSERT INTO Publishers (Name,Mark) values(@Name,@Mark);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Mark", Mark);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdatePublisher(string oldName, string oldMark, string newName, string newMark)
    {
        try
        {
            String sql = "UPDATE Publishers SET Name = @newName, Mark = @newMark WHERE Name = @oldName AND Mark = @oldMark;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@newMark", newMark);
            command.Parameters.AddWithValue("@oldName", oldName);
            command.Parameters.AddWithValue("@oldMark", oldMark);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBDeletePublisher(string Name, string Mark)
    {
        try
        {
            String sql = "DELETE FROM Publishers WHERE Name=@Name AND Mark=@Mark;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Mark", Mark);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBInsertCategory(string Name, string Description)
    {
        try
        {
            String sql = "INSERT INTO Categories (Name,Description) values(@Name,@Description);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Description", Description);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdateCategory(string oldName, string oldDescription, string newName, string newDescription)
    {
        try
        {
            String sql = "UPDATE Categories SET Name = @newName, Description = @newDescription WHERE Name = @oldName AND Description = @oldDescription;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@newName", newName);
            command.Parameters.AddWithValue("@newDescription", newDescription);
            command.Parameters.AddWithValue("@oldName", oldName);
            command.Parameters.AddWithValue("@oldDescription", oldDescription);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBDeleteCategory(string Name, string Description)
    {
        try
        {
            String sql = "DELETE FROM Categories WHERE Name=@Name AND Description=@Description;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Description", Description);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBInsertLibraryUser(string FirstName, string LastName, string OIB)
    {
        try
        {
            String sql = "INSERT INTO LibraryUsers (FirstName,LastName,OIB) values(@FirstName,@LastName,@OIB);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@OIB", OIB);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdateLibraryUser(string oldFirstName, string oldLastName, string oldOIB, string newFirstName, string newLastName, string newOIB)
    {
        try
        {
            String sql = "UPDATE LibraryUsers SET FirstName = @newFirstName, LastName = @newLastName, OIB=@newOIB WHERE FirstName = @oldFirstName AND LastName = @oldLastName AND OIB=@oldOIB;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@newFirstName", newFirstName);
            command.Parameters.AddWithValue("@newLastName", newLastName);
            command.Parameters.AddWithValue("@oldFirstName", oldFirstName);
            command.Parameters.AddWithValue("@oldLastName", oldLastName);
            command.Parameters.AddWithValue("@newOIB", newOIB);
            command.Parameters.AddWithValue("@oldOIB", oldOIB);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBDeleteLibraryUser(string FirstName, string LastName, string OIB)
    {
        try
        {
            String sql = "DELETE FROM LibraryUsers WHERE FirstName = @FirstName AND LastName = @LastName AND OIB=@OIB;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@OIB", OIB);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBInsertBookUser(int BookID, int LibraryUserID)
    {
        DateTime LendDate = DateTime.Now;
        try
        {
            String sql = "INSERT INTO BooksUsers (BookID,LibraryUserID,LendDate) values(@BookID,@LibraryUserID,@LendDate);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@LibraryUserID", LibraryUserID);
            command.Parameters.AddWithValue("@LendDate", LendDate);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public int DBGetBookID(string Title, string ISBN, int Availability)
    {
        int BookID=-1;
        try
        {
            String sql = "SELECT top 1 BookID FROM Books WHERE Title = @Title AND ISBN = @ISBN AND Availability=@Availability;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@Availability", Availability);
            connection.Open();
            SqlDataReader sqldr = command.ExecuteReader();
            while (sqldr.Read())
            {
                BookID = sqldr.GetInt32(0);
            }
            connection.Close();
            return BookID;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return BookID;
        }
    }

    public int DBGetBookIDByTitleISBN(string Title, string ISBN)
    {
        int BookID = -1;
        try
        {
            String sql = "SELECT top 1 BookID FROM Books WHERE Title = @Title AND ISBN = @ISBN;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            connection.Open();
            SqlDataReader sqldr = command.ExecuteReader();
            while (sqldr.Read())
            {
                BookID = sqldr.GetInt32(0);
            }
            connection.Close();
            return BookID;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return BookID;
        }
    }

    public bool DBMakeBookUnavailable(int BookID)
    {
        try
        {
            String sql = "UPDATE Books SET Availability = 0 WHERE BookID = @BookID;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@BookID", BookID);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBMakeBookAvailable(int BookID)
    {
        try
        {
            String sql = "UPDATE Books SET Availability = 1 WHERE BookID = @BookID;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@BookID", BookID);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdateBookUser(int BookID, int LibraryUserID)
    {
        DateTime ReturnDate = DateTime.Now;
        try
        {
            String sql = "Update BooksUsers SET ReturnDate=@ReturnDate WHERE BookID=@BookID AND LibraryUserID=@LibraryUserID;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@LibraryUserID", LibraryUserID);
            command.Parameters.AddWithValue("@ReturnDate", ReturnDate);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public DataTable DBTablesAuthorsBooksJoin()
    {
        try
        {
            String sql = "SELECT A.AuthorID,A.FirstName,A.LastName, AB.BookID FROM Authors A INNER JOIN AuthorsBooks AB ON A.AuthorID = AB.AuthorID;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            return dt;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return null;
        }

    }

    public DataTable DBTablesPublishersBooksJoin()
    {
        try
        {
            String sql = "SELECT P.PublisherID,P.Name,P.Mark, BP.BookID FROM Publishers P INNER JOIN BooksPublishers BP ON P.PublisherID = BP.PublisherID;;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            return dt;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return null;
        }

    }

    public DataTable DBTablesBooksCategoriesJoin()
    {
        try
        {
            String sql = "SELECT C.CategoryID,C.Name,C.Description, BC.BookID FROM Categories C INNER JOIN BooksCategories BC ON C.CategoryID = BC.CategoryID;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            return dt;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return null;
        }

    }

    public DataTable DBGetAuthorFullName()
    {
        try
        {
            String sql = "SELECT AuthorID, (LastName + ' ' + FirstName) AS FullName FROM Authors;";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            connection.Close();
            return dt;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return null;
        }

    }

    public bool DBUpdateOrInsertAuthorsBooks(int AuthorID, int BookID)
    {
        DateTime ReturnDate = DateTime.Now;
        try
        {
            String sql = "IF EXISTS (SELECT * FROM AuthorsBooks WHERE BookID=@BookID) UPDATE AuthorsBooks SET AuthorID =@AuthorID where BookID = @BookID ELSE INSERT INTO AuthorsBooks(AuthorID,BookID) values(@AuthorID,@BookID);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdateOrInsertBooksCategories(int BookID, int CategoryID)
    {
        DateTime ReturnDate = DateTime.Now;
        try
        {
            String sql = "IF EXISTS (SELECT * FROM BooksCategories WHERE BookID=@BookID) UPDATE BooksCategories SET CategoryID =@CategoryID where BookID = @BookID ELSE INSERT INTO BooksCategories(CategoryID,BookID) values(@CategoryID,@BookID);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }

    public bool DBUpdateOrInsertBooksPublishers(int BookID, int PublisherID)
    {
        DateTime ReturnDate = DateTime.Now;
        try
        {
            String sql = "IF EXISTS (SELECT * FROM BooksPublishers WHERE BookID=@BookID) UPDATE BooksPublishers SET PublisherID =@PublisherID where BookID = @BookID ELSE INSERT INTO BooksPublishers(PublisherID,BookID) values(@PublisherID,@BookID);";
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PublisherID", PublisherID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.ExecuteReader();
            connection.Close();
            return true;
        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
            return false;
        }
    }
}
