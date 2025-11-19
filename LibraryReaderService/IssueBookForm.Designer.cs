namespace LibraryReaderService
{
    partial class IssueBookForm
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
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblReader = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbReaders
            // 
            this.cbReaders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaders.FormattingEnabled = true;
            this.cbReaders.Location = new System.Drawing.Point(105, 19);
            this.cbReaders.Name = "cbReaders";
            this.cbReaders.Size = new System.Drawing.Size(176, 23);
            this.cbReaders.TabIndex = 0;
            // 
            // cbBooks
            // 
            this.cbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBooks.FormattingEnabled = true;
            this.cbBooks.Location = new System.Drawing.Point(105, 56);
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(176, 23);
            this.cbBooks.TabIndex = 1;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(105, 94);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(176, 23);
            this.dtpIssueDate.TabIndex = 2;
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.White;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIssue.Location = new System.Drawing.Point(105, 131);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(175, 38);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // lblReader
            // 
            this.lblReader.AutoSize = true;
            this.lblReader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReader.ForeColor = System.Drawing.Color.White;
            this.lblReader.Location = new System.Drawing.Point(12, 19);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(54, 19);
            this.lblReader.TabIndex = 4;
            this.lblReader.Text = "Reader:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBook.ForeColor = System.Drawing.Color.White;
            this.lblBook.Location = new System.Drawing.Point(12, 56);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(43, 19);
            this.lblBook.TabIndex = 5;
            this.lblBook.Text = "Book:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIssueDate.ForeColor = System.Drawing.Color.White;
            this.lblIssueDate.Location = new System.Drawing.Point(12, 94);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(76, 19);
            this.lblIssueDate.TabIndex = 6;
            this.lblIssueDate.Text = "Issue Date:";
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(350, 188);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblReader);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.cbReaders);
            this.Name = "IssueBookForm";
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbReaders;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblIssueDate;
    }
}
