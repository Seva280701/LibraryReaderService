namespace LibraryReaderService
{
    partial class ReturnBookForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cbReaders = new System.Windows.Forms.ComboBox();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.lblReader = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbReaders
            // 
            this.cbReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaders.FormattingEnabled = true;
            this.cbReaders.Location = new System.Drawing.Point(120, 30);
            this.cbReaders.Name = "cbReaders";
            this.cbReaders.Size = new System.Drawing.Size(200, 24);
            this.cbReaders.TabIndex = 0;
            this.cbReaders.SelectedIndexChanged += new System.EventHandler(this.cbReaders_SelectedIndexChanged);
            // 
            // cbBooks
            // 
            this.cbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(120, 70);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(200, 24);
            this.cbBooks.TabIndex = 1;
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReader.ForeColor = System.Drawing.Color.White;
            this.lblReader.Location = new System.Drawing.Point(30, 30);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(70, 23);
            this.lblReader.TabIndex = 2;
            this.lblReader.Text = "Reader:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBook.ForeColor = System.Drawing.Color.White;
            this.lblBook.Location = new System.Drawing.Point(30, 70);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(54, 23);
            this.lblBook.TabIndex = 3;
            this.lblBook.Text = "Book:";
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(120, 110);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            this.btnReturn.BackColor = System.Drawing.Color.White;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(34, 57, 75); 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblReader);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.cbReaders);
            this.Name = "ReturnBookForm";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbReaders;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnReturn;
    }
}
