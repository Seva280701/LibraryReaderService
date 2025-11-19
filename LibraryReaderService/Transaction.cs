using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryReaderService
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int ReaderID { get; set; }
        public int BookID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = string.Empty;

        public Transaction() { }

        public Transaction(int readerID, int bookID, DateTime issueDate, string status)
        {
            ReaderID = readerID;
            BookID = bookID;
            IssueDate = issueDate;
            Status = status;
        }

        public void AddTransaction()
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                string query = "INSERT INTO Transactions (ReaderID, BookID, IssueDate, Status) VALUES (@ReaderID, @BookID, @IssueDate, @Status)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReaderID", this.ReaderID);
                cmd.Parameters.AddWithValue("@BookID", this.BookID);
                cmd.Parameters.AddWithValue("@IssueDate", this.IssueDate);
                cmd.Parameters.AddWithValue("@Status", this.Status);

                con.Open();
                cmd.ExecuteNonQuery();

                
                UpdateBookAvailabilityStatus(this.BookID, false);
            }
        }

        public static Transaction? GetTransaction(int bookID, int readerID)
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                string query = "SELECT * FROM Transactions WHERE BookID = @BookID AND ReaderID = @ReaderID AND Status = 'Issued'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@ReaderID", readerID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Transaction
                    {
                        TransactionID = Convert.ToInt32(reader["TransactionID"]),
                        ReaderID = Convert.ToInt32(reader["ReaderID"]),
                        BookID = Convert.ToInt32(reader["BookID"]),
                        IssueDate = Convert.ToDateTime(reader["IssueDate"]),
                        ReturnDate = reader["ReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ReturnDate"]),
                        Status = reader["Status"]?.ToString() ?? string.Empty
                    };
                }
            }
            return null;
        }

        public void ReturnBook()
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                string query = "UPDATE Transactions SET ReturnDate = @ReturnDate, Status = 'Returned' WHERE TransactionID = @TransactionID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TransactionID", this.TransactionID);
                cmd.Parameters.AddWithValue("@ReturnDate", DateTime.Now);

                con.Open();
                cmd.ExecuteNonQuery();

               
                UpdateBookAvailabilityStatus(this.BookID, true);
            }
        }

        public static List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                string query = "SELECT * FROM Transactions";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transactions.Add(new Transaction
                    {
                        TransactionID = Convert.ToInt32(reader["TransactionID"]),
                        ReaderID = Convert.ToInt32(reader["ReaderID"]),
                        BookID = Convert.ToInt32(reader["BookID"]),
                        IssueDate = Convert.ToDateTime(reader["IssueDate"]),
                        ReturnDate = reader["ReturnDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["ReturnDate"]),
                        Status = reader["Status"]?.ToString() ?? string.Empty
                    });
                }
            }
            return transactions;
        }

        private void UpdateBookAvailabilityStatus(int bookID, bool isAvailable)
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                string query = "UPDATE Books SET AvailabilityStatus = @AvailabilityStatus WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AvailabilityStatus", isAvailable);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
