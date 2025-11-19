using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryReaderService
{
    public partial class ManageBooksForm : Form
    {
        private DataView? booksDataView; // Make the DataView nullable
        private bool isSortAscending = true; // To toggle sorting order

        public ManageBooksForm()
        {
            InitializeComponent();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
            SetupSearch();
        }

        private void LoadBooks()
        {
            List<Book> books = Book.GetBooks();
            DataTable booksTable = ConvertToDataTable(books);
            booksDataView = new DataView(booksTable);
            dgvBooks.DataSource = booksDataView;
        }

        private void SetupSearch()
        {
            cbSearchField.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (booksDataView != null)
            {
                string searchField = cbSearchField.SelectedItem.ToString()!;
                string searchValue = txtSearch.Text;
                booksDataView.RowFilter = $"{searchField} LIKE '%{searchValue}%'";
            }
        }

        private void dgvBooks_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (booksDataView != null)
            {
                string sortField = dgvBooks.Columns[e.ColumnIndex].DataPropertyName;
                booksDataView.Sort = $"{sortField} {(isSortAscending ? "ASC" : "DESC")}";
                isSortAscending = !isSortAscending; // Toggle the sort order for next click
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddUpdateBookForm form = new AddUpdateBookForm();
            form.ShowDialog();
            LoadBooks();
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);
                Book? book = Book.GetBookById(bookID);

                if (book != null)
                {
                    AddUpdateBookForm form = new AddUpdateBookForm(book);
                    form.ShowDialog();
                    LoadBooks();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);
                Book.DeleteBook(bookID);
                LoadBooks();
            }
        }

        private DataTable ConvertToDataTable<T>(List<T> items)
        {
            var dataTable = new DataTable(typeof(T).Name);
            var props = typeof(T).GetProperties();

            foreach (var prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in items)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
