using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryReaderService
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public bool AvailabilityStatus { get; set; }

        public Book() { }

        public Book(string title, string author, string genre, bool availabilityStatus)
        {
            Title = title;
            Author = author;
            Genre = genre;
            AvailabilityStatus = availabilityStatus;
        }

        public void AddBook()
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "INSERT INTO Books (Title, Author, Genre, AvailabilityStatus) VALUES (@Title, @Author, @Genre, @AvailabilityStatus)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Title", this.Title);
                cmd.Parameters.AddWithValue("@Author", this.Author);
                cmd.Parameters.AddWithValue("@Genre", this.Genre);
                cmd.Parameters.AddWithValue("@AvailabilityStatus", this.AvailabilityStatus);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBook()
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "UPDATE Books SET Title=@Title, Author=@Author, Genre=@Genre, AvailabilityStatus=@AvailabilityStatus WHERE BookID=@BookID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", this.BookID);
                cmd.Parameters.AddWithValue("@Title", this.Title);
                cmd.Parameters.AddWithValue("@Author", this.Author);
                cmd.Parameters.AddWithValue("@Genre", this.Genre);
                cmd.Parameters.AddWithValue("@AvailabilityStatus", this.AvailabilityStatus);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static Book? GetBookById(int bookID)  
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Books WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Book
                    {
                        BookID = Convert.ToInt32(reader["BookID"]),
                        Title = reader["Title"]?.ToString() ?? string.Empty,
                        Author = reader["Author"]?.ToString() ?? string.Empty,
                        Genre = reader["Genre"]?.ToString() ?? string.Empty,
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"])
                    };
                }
            }
            return null;
        }

        public static void DeleteBook(int bookID)
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "DELETE FROM Books WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Books";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        BookID = Convert.ToInt32(reader["BookID"]),
                        Title = reader["Title"]?.ToString() ?? string.Empty,
                        Author = reader["Author"]?.ToString() ?? string.Empty,
                        Genre = reader["Genre"]?.ToString() ?? string.Empty,
                        AvailabilityStatus = Convert.ToBoolean(reader["AvailabilityStatus"])
                    });
                }
            }
            return books;
        }
    }
}
