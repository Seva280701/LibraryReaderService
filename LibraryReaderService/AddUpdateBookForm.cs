using System;
using System.Windows.Forms;

namespace LibraryReaderService
{
    public partial class AddUpdateBookForm : Form
    {
        private Book? _book;

        public AddUpdateBookForm()
        {
            InitializeComponent();
        }

        public AddUpdateBookForm(Book? book = null)
        {
            InitializeComponent();
            _book = book;
            if (_book != null)
            {
                txtTitle.Text = _book.Title;
                txtAuthor.Text = _book.Author;
                txtGenre.Text = _book.Genre;
                chkAvailability.Checked = _book.AvailabilityStatus;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_book == null)
            {
                Book newBook = new Book
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Genre = txtGenre.Text,
                    AvailabilityStatus = chkAvailability.Checked
                };
                newBook.AddBook();
            }
            else
            {
                _book.Title = txtTitle.Text;
                _book.Author = txtAuthor.Text;
                _book.Genre = txtGenre.Text;
                _book.AvailabilityStatus = chkAvailability.Checked;
                _book.UpdateBook();
            }
            MessageBox.Show("Book saved successfully!");
            this.Close();
        }
    }
}
