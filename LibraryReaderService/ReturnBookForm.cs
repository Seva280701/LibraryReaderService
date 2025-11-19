using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryReaderService
{
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            LoadReaders();
        }

        private void LoadReaders()
        {
            cbReaders.DisplayMember = "Name";
            cbReaders.ValueMember = "ReaderID";

            List<Reader> readers = new List<Reader>();
            string query = @"
                SELECT DISTINCT r.ReaderID, r.Name 
                FROM Readers r
                JOIN Transactions t ON r.ReaderID = t.ReaderID
                WHERE t.Status = 1"; 

            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    readers.Add(new Reader
                    {
                        ReaderID = Convert.ToInt32(reader["ReaderID"]),
                        Name = reader["Name"]?.ToString() ?? string.Empty
                    });
                }
            }

            cbReaders.DataSource = readers;
        }

        private void cbReaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReaders.SelectedValue != null)
            {
                int readerID = Convert.ToInt32(cbReaders.SelectedValue!);
                LoadIssuedBooks(readerID);
            }
        }

        private void LoadIssuedBooks(int readerID)
        {
            cbBooks.DisplayMember = "Title";
            cbBooks.ValueMember = "BookID";

            List<Book> books = new List<Book>();
            string query = @"
                SELECT b.BookID, b.Title 
                FROM Books b
                JOIN Transactions t ON b.BookID = t.BookID
                WHERE t.ReaderID = @ReaderID AND t.Status = 1"; 

            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReaderID", readerID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        BookID = Convert.ToInt32(reader["BookID"]),
                        Title = reader["Title"]?.ToString() ?? string.Empty
                    });
                }
            }

            cbBooks.DataSource = books;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cbReaders.SelectedValue != null && cbBooks.SelectedValue != null)
            {
                int readerID = Convert.ToInt32(cbReaders.SelectedValue!);
                int bookID = Convert.ToInt32(cbBooks.SelectedValue!);

                using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
                {
                    
                    string updateTransactionQuery = "UPDATE Transactions SET Status = 0 WHERE ReaderID = @ReaderID AND BookID = @BookID AND Status = 1";
                    SqlCommand updateTransactionCmd = new SqlCommand(updateTransactionQuery, con);
                    updateTransactionCmd.Parameters.AddWithValue("@ReaderID", readerID);
                    updateTransactionCmd.Parameters.AddWithValue("@BookID", bookID);

                    
                    string updateBookQuery = "UPDATE Books SET AvailabilityStatus = @AvailabilityStatus WHERE BookID = @BookID";
                    SqlCommand updateBookCmd = new SqlCommand(updateBookQuery, con);
                    updateBookCmd.Parameters.AddWithValue("@AvailabilityStatus", true);
                    updateBookCmd.Parameters.AddWithValue("@BookID", bookID);

                    con.Open();
                    updateTransactionCmd.ExecuteNonQuery();
                    updateBookCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Book returned successfully.");
                LoadReaders();  
                cbBooks.DataSource = null;  
            }
        }
    }
}
