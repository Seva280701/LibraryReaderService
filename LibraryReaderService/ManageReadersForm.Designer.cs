namespace LibraryReaderService
{
    partial class ManageReadersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReaders;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnUpdateReader;
        private System.Windows.Forms.Button btnDeleteReader;
        private System.Windows.Forms.ComboBox cbSearchField;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;

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
            this.dgvReaders = new System.Windows.Forms.DataGridView();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnUpdateReader = new System.Windows.Forms.Button();
            this.btnDeleteReader = new System.Windows.Forms.Button();
            this.cbSearchField = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReaders
            // 
            this.dgvReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReaders.Location = new System.Drawing.Point(12, 60);
            this.dgvReaders.Name = "dgvReaders";
            this.dgvReaders.RowHeadersWidth = 51;
            this.dgvReaders.RowTemplate.Height = 24;
            this.dgvReaders.Size = new System.Drawing.Size(760, 400);
            this.dgvReaders.TabIndex = 0;
            this.dgvReaders.BackgroundColor = System.Drawing.Color.White;
            this.dgvReaders.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReaders_ColumnHeaderMouseClick);
            // 
            // btnAddReader
            // 
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddReader.Location = new System.Drawing.Point(12, 470);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(200, 40);
            this.btnAddReader.TabIndex = 1;
            this.btnAddReader.Text = "Add Reader";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            this.btnAddReader.BackColor = System.Drawing.Color.White;
            // 
            // btnUpdateReader
            // 
            this.btnUpdateReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateReader.Location = new System.Drawing.Point(220, 470);
            this.btnUpdateReader.Name = "btnUpdateReader";
            this.btnUpdateReader.Size = new System.Drawing.Size(200, 40);
            this.btnUpdateReader.TabIndex = 2;
            this.btnUpdateReader.Text = "Update Reader";
            this.btnUpdateReader.UseVisualStyleBackColor = true;
            this.btnUpdateReader.Click += new System.EventHandler(this.btnUpdateReader_Click);
            this.btnUpdateReader.BackColor = System.Drawing.Color.White;
            // 
            // btnDeleteReader
            // 
            this.btnDeleteReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteReader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteReader.Location = new System.Drawing.Point(430, 470);
            this.btnDeleteReader.Name = "btnDeleteReader";
            this.btnDeleteReader.Size = new System.Drawing.Size(200, 40);
            this.btnDeleteReader.TabIndex = 3;
            this.btnDeleteReader.Text = "Delete Reader";
            this.btnDeleteReader.UseVisualStyleBackColor = true;
            this.btnDeleteReader.Click += new System.EventHandler(this.btnDeleteReader_Click);
            this.btnDeleteReader.BackColor = System.Drawing.Color.White;
            // 
            // cbSearchField
            // 
            this.cbSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchField.FormattingEnabled = true;
            this.cbSearchField.Items.AddRange(new object[] {
            "Name",
            "Address",
            "PhoneNumber",
            "Email"});
            this.cbSearchField.Location = new System.Drawing.Point(90, 20);
            this.cbSearchField.Name = "cbSearchField";
            this.cbSearchField.Size = new System.Drawing.Size(121, 24);
            this.cbSearchField.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(220, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(64, 23);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(380, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.BackColor = System.Drawing.Color.White;
            // 
            // ManageReadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(34, 57, 75); // Indigo background color
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbSearchField);
            this.Controls.Add(this.btnDeleteReader);
            this.Controls.Add(this.btnUpdateReader);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.dgvReaders);
            this.Name = "ManageReadersForm";
            this.Text = "Manage Readers";
            this.Load += new System.EventHandler(this.ManageReadersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
