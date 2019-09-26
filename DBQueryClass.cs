using System;
using System.Data.SqlClient;

public class DBQuery
{
	public DBConnect()
	{
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "LAPTOP\\SQLEXPRESS";   // update me
            builder.UserID = "user1";              // update me
            builder.Password = "user1";      // update me
            builder.InitialCatalog = "master";

            Console.Write("Connecting to SQL Server ... ");
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                Console.WriteLine("Done.");
            }

        }
        catch (SqlException exception)
        {
            Console.WriteLine(exception.ToString());
        }
    }
}
