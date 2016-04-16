using System;
using System.Data.SqlClient;

namespace ReturnReceiptReport
{
    /// <summary>
    /// Grabs Receipts from the database.
    /// </summary>
    class ReceiptGrabber
    {
        /// <summary>
        /// Public method for getting receipts from the server database
        /// </summary>
        public void GetReceipts(String server, String database, String table)
        {
            String connectionString = getConnectionString(server, database);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(getCommandString(table), connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
                Console.WriteLine("Hi!");
            }
        }

        private String getConnectionString(String server, String database)
        {
            // We are just pretending this works. That's what I get for trying to connect on my personal laptop.
            return String.Format("Server={0};Database={1};Integrated Security=true", server, database);
        }

        private String getCommandString(String table)
        {
            return String.Format("SELECT * FROM {0} WHERE [Plu_Number] = \'150\'", table);
        }
    }
}
