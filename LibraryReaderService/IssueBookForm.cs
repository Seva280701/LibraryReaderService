using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryReaderService
{
    public partial class IssueBookForm : Form
    {
        public IssueBookForm()
        {
            InitializeComponent();
        }

        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            LoadReaders();
            LoadAvailableBooks();
        }

        private void LoadReaders()
        {
            cbReaders.DisplayMember = "Name";
            cbReaders.ValueMember = "ReaderID";

            List<Reader> readers = new List<Reader>();
            string query = "SELECT ReaderID, Name FROM Readers";

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

        private void LoadAvailableBooks()
        {
            cbBooks.DisplayMember = "Title";
            cbBooks.ValueMember = "BookID";

            List<Book> books = new List<Book>();
            string query = "SELECT BookID, Title FROM Books WHERE AvailabilityStatus = 1";

            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
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

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (cbReaders.SelectedValue != null && cbBooks.SelectedValue != null)
            {
                int readerID = Convert.ToInt32(cbReaders.SelectedValue!);
                int bookID = Convert.ToInt32(cbBooks.SelectedValue!);
                DateTime issueDate = dtpIssueDate.Value;

                using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Trusted_Connection=True;"))
                {
                    /
                    string query = "INSERT INTO Transactions (ReaderID, BookID, IssueDate, Status) VALUES (@ReaderID, @BookID, @IssueDate, @Status)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ReaderID", readerID);
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                    cmd.Parameters.AddWithValue("@Status", 1); 

                    
                    string updateBookQuery = "UPDATE Books SET AvailabilityStatus = @AvailabilityStatus WHERE BookID = @BookID";
                    SqlCommand updateBookCmd = new SqlCommand(updateBookQuery, con);
                    updateBookCmd.Parameters.AddWithValue("@AvailabilityStatus", false);
                    updateBookCmd.Parameters.AddWithValue("@BookID", bookID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    updateBookCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Book issued successfully.");
                LoadAvailableBooks();  
            }
        }
    }
}
