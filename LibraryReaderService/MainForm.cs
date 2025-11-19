using System;
using System.Windows.Forms;

namespace LibraryReaderService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnManageReaders_Click(object sender, EventArgs e)
        {
            ManageReadersForm form = new ManageReadersForm();
            form.ShowDialog();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooksForm form = new ManageBooksForm();
            form.ShowDialog();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            IssueBookForm form = new IssueBookForm();
            form.ShowDialog();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm form = new ReturnBookForm();
            form.ShowDialog();
        }
    }
}
