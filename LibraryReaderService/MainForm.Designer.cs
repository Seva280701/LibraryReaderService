namespace LibraryReaderService
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnManageReaders;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnManageReaders = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();

            // 
            // btnManageReaders
            // 
            this.btnManageReaders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReaders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageReaders.Image = System.Drawing.Image.FromFile("C:\\Users\\seva2\\source\\imgForCode\\manage_readers.png");
            this.btnManageReaders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageReaders.Location = new System.Drawing.Point(10, 10);
            this.btnManageReaders.Margin = new System.Windows.Forms.Padding(10);
            this.btnManageReaders.Name = "btnManageReaders";
            this.btnManageReaders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageReaders.Size = new System.Drawing.Size(280, 50);
            this.btnManageReaders.TabIndex = 0;
            this.btnManageReaders.Text = " Manage Readers";
            this.btnManageReaders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageReaders.UseVisualStyleBackColor = true;
            this.btnManageReaders.Click += new System.EventHandler(this.btnManageReaders_Click);
            this.btnManageReaders.BackColor = System.Drawing.Color.White; 

            // 
            // btnManageBooks
            // 
            this.btnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageBooks.Image = System.Drawing.Image.FromFile("C:\\Users\\seva2\\source\\imgForCode\\manage_books.png");
            this.btnManageBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBooks.Location = new System.Drawing.Point(10, 80);
            this.btnManageBooks.Margin = new System.Windows.Forms.Padding(10);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageBooks.Size = new System.Drawing.Size(280, 50);
            this.btnManageBooks.TabIndex = 1;
            this.btnManageBooks.Text = " Manage Books";
            this.btnManageBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            this.btnManageBooks.BackColor = System.Drawing.Color.White; 

            // 
            // btnIssueBook
            // 
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIssueBook.Image = System.Drawing.Image.FromFile("C:\\Users\\seva2\\source\\imgForCode\\issue_book.png");
            this.btnIssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBook.Location = new System.Drawing.Point(10, 150);
            this.btnIssueBook.Margin = new System.Windows.Forms.Padding(10);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIssueBook.Size = new System.Drawing.Size(280, 50);
            this.btnIssueBook.TabIndex = 2;
            this.btnIssueBook.Text = " Issue Book";
            this.btnIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            this.btnIssueBook.BackColor = System.Drawing.Color.White; 

            // 
            // btnReturnBook
            // 
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturnBook.Image = System.Drawing.Image.FromFile("C:\\Users\\seva2\\source\\imgForCode\\return_book.png");
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(10, 220);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(10);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReturnBook.Size = new System.Drawing.Size(280, 50);
            this.btnReturnBook.TabIndex = 3;
            this.btnReturnBook.Text = " Return Book";
            this.btnReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            this.btnReturnBook.BackColor = System.Drawing.Color.White; 

            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(90, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(225, 41);
            this.lblHeader.TabIndex = 4;
            this.lblHeader.Text = "Library Services";

            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.btnManageReaders, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.btnManageBooks, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.btnIssueBook, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.btnReturnBook, 0, 3);
            this.tableLayoutPanel.Location = new System.Drawing.Point(60, 80);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(300, 300);
            this.tableLayoutPanel.TabIndex = 5;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(34, 57, 75); 
            this.ClientSize = new System.Drawing.Size(420, 420);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.lblHeader);
            this.Name = "MainForm";
            this.Text = "Library Reader Service";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
