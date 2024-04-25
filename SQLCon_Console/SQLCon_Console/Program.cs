using System;
using System.Data;
using System.Data.SqlClient;


class SqlConnectionDemo
{
    static void Main()
    {
        // 1. Instantiate the connection
        SqlConnection conn = new SqlConnection("Data Source = DESKTOP-608NF4U\\SQLEXPRESS; Initial Catalog = Emp; Integrated Security = SSPI");

        SqlDataReader rdr = null;

        try
        {
            // 2. Open the connection
            conn.Open();

            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("select * from Employee", conn);

            // 4. Use the connection

            // get query results
            rdr = cmd.ExecuteReader();

            // print the CustomerID of each record
            while (rdr.Read())
            {
                Console.WriteLine("Eid " + rdr[0] + " Name " + rdr[1] + " Salary " + rdr[2]);
            }

            Console.ReadKey();
        }
        finally
        {
            // close the reader
            if (rdr != null)
            {
                rdr.Close();
            }

            // 5. Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
};

