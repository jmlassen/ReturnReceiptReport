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
        public void GetReceipts()
        {
            String connectionString = getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM [Products] WHERE [Plu_Number] = \'150\'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0].ToString());
                }
            }
        }

        private String getConnectionString()
        {
            // We are just pretending this works. That's what I get for trying to connect on my personal laptop.
            return "Server=00LSRV02;Database=StoreTender;Integrated Security=true";
        }
    }
}
