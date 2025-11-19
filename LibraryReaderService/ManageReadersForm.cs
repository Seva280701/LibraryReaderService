using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace LibraryReaderService
{
    public partial class ManageReadersForm : Form
    {
        private DataView? readersDataView; // Make the DataView nullable
        private bool isSortAscending = true; // To toggle sorting order

        public ManageReadersForm()
        {
            InitializeComponent();
        }

        private void ManageReadersForm_Load(object sender, EventArgs e)
        {
            LoadReaders();
            SetupSearch();
        }

        private void LoadReaders()
        {
            List<Reader> readers = Reader.GetReaders();
            DataTable readersTable = ConvertToDataTable(readers);
            readersDataView = new DataView(readersTable);
            dgvReaders.DataSource = readersDataView;
        }

        private void SetupSearch()
        {
            cbSearchField.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (readersDataView != null)
            {
                string searchField = cbSearchField.SelectedItem.ToString()!;
                string searchValue = txtSearch.Text;
                readersDataView.RowFilter = $"{searchField} LIKE '%{searchValue}%'";
            }
        }

        private void dgvReaders_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (readersDataView != null)
            {
                string sortField = dgvReaders.Columns[e.ColumnIndex].DataPropertyName;
                readersDataView.Sort = $"{sortField} {(isSortAscending ? "ASC" : "DESC")}";
                isSortAscending = !isSortAscending; // Toggle the sort order for next click
            }
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            AddUpdateReaderForm form = new AddUpdateReaderForm();
            form.ShowDialog();
            LoadReaders();
        }

        private void btnUpdateReader_Click(object sender, EventArgs e)
        {
            if (dgvReaders.SelectedRows.Count > 0)
            {
                int readerID = Convert.ToInt32(dgvReaders.SelectedRows[0].Cells["ReaderID"].Value);
                Reader? reader = Reader.GetReaderById(readerID);

                if (reader != null)
                {
                    AddUpdateReaderForm form = new AddUpdateReaderForm(reader);
                    form.ShowDialog();
                    LoadReaders();
                }
                else
                {
                    MessageBox.Show("Reader not found.");
                }
            }
        }

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {
            if (dgvReaders.SelectedRows.Count > 0)
            {
                int readerID = Convert.ToInt32(dgvReaders.SelectedRows[0].Cells["ReaderID"].Value);
                Reader.DeleteReader(readerID);
                LoadReaders();
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
