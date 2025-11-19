using System;
using System.Windows.Forms;

namespace LibraryReaderService
{
    public partial class AddUpdateReaderForm : Form
    {
        private Reader? _reader;

        public AddUpdateReaderForm()
        {
            InitializeComponent();
        }

        public AddUpdateReaderForm(Reader? reader = null)
        {
            InitializeComponent();
            _reader = reader;
            if (_reader != null)
            {
                txtName.Text = _reader.Name;
                txtAddress.Text = _reader.Address;
                txtPhoneNumber.Text = _reader.PhoneNumber;
                txtEmail.Text = _reader.Email;
            }
        }

        private void AddUpdateReaderForm_Load(object sender, EventArgs e)
        {
         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_reader == null)
            {
                Reader newReader = new Reader
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text
                };
                newReader.AddReader();
            }
            else
            {
                _reader.Name = txtName.Text;
                _reader.Address = txtAddress.Text;
                _reader.PhoneNumber = txtPhoneNumber.Text;
                _reader.Email = txtEmail.Text;
                _reader.UpdateReader();
            }
            MessageBox.Show("Reader saved successfully!");
            this.Close();
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
