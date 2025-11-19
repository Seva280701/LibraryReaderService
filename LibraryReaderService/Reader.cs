using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LibraryReaderService
{
    public class Reader
    {
        public int ReaderID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public Reader() { }

        public Reader(string name, string address, string phoneNumber, string email)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void AddReader()
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "INSERT INTO Readers (Name, Address, PhoneNumber, Email) VALUES (@Name, @Address, @PhoneNumber, @Email)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", this.Name);
                cmd.Parameters.AddWithValue("@Address", this.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", this.Email);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateReader()
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "UPDATE Readers SET Name=@Name, Address=@Address, PhoneNumber=@PhoneNumber, Email=@Email WHERE ReaderID=@ReaderID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReaderID", this.ReaderID);
                cmd.Parameters.AddWithValue("@Name", this.Name);
                cmd.Parameters.AddWithValue("@Address", this.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                cmd.Parameters.AddWithValue("@Email", this.Email);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static Reader? GetReaderById(int readerID)
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Readers WHERE ReaderID = @ReaderID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReaderID", readerID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Reader
                    {
                        ReaderID = Convert.ToInt32(reader["ReaderID"]),
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        PhoneNumber = reader["PhoneNumber"]?.ToString() ?? string.Empty,
                        Email = reader["Email"]?.ToString() ?? string.Empty
                    };
                }
            }
            return null;
        }

        public static void DeleteReader(int readerID)
        {
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "DELETE FROM Readers WHERE ReaderID = @ReaderID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ReaderID", readerID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static List<Reader> GetReaders()
        {
            List<Reader> readers = new List<Reader>();
            using (SqlConnection con = new SqlConnection("Server=localhost\\sqlexpress;Database=LibraryDB;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Readers";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    readers.Add(new Reader
                    {
                        ReaderID = Convert.ToInt32(reader["ReaderID"]),
                        Name = reader["Name"]?.ToString() ?? string.Empty,
                        Address = reader["Address"]?.ToString() ?? string.Empty,
                        PhoneNumber = reader["PhoneNumber"]?.ToString() ?? string.Empty,
                        Email = reader["Email"]?.ToString() ?? string.Empty
                    });
                }
            }
            return readers;
        }
    }
}
