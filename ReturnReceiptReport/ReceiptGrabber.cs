using System;
using System.Data.SqlClient;

namespace ReturnReceiptReport
{
    /// <summary>
    /// Grabs Receipts from the database.
    /// </summary>
    class ReceiptGrabber
    {
        public SqlDataReader GetReceipts(String server, String database, String table)
        {
            String connectionString = getConnectionString(server, database);
            SqlCommand command;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                command = new SqlCommand(getCommandString(table), connection);
            }
            return command.ExecuteReader();
        }

        private String getConnectionString(String server, String database)
        {
            // We are just pretending this works. That's what I get for trying to connect on my personal laptop.
            return String.Format("Server={0};Database={1};Integrated Security=true", server, database);
        }

        private String getCommandString(String table, String transactionNumberField, String receiptTextField)
        {
            return String.Format("SELECT * " + 
                                 "FROM {0} WHERE {1} IN ( " +
                                 "   SELECT {1} " +
                                 "   FROM {0} " +
                                 "   WHERE "
                                 
                                 , table, transactionNumberField, receiptTextField);
        }
    }
}
