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
            using (SqlConnection connection = new SqlConnection("Server=00LSRV02;Database=StoreTender;Integrated Security=true"))
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
    }
}
