namespace WindowsFormsAppDBTestDemo
{
    partial class BookReturnForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReturnBookLibraryUsersFirstName = new System.Windows.Forms.TextBox();
            this.textBoxReturnBookLibraryUsersLastName = new System.Windows.Forms.TextBox();
            this.textBoxReturnBookLibraryUsersOIB = new System.Windows.Forms.TextBox();
            this.dataGridViewReturnBookLibraryUsers = new System.Windows.Forms.DataGridView();
            this.libraryUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.libraryUsersTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.LibraryUsersTableAdapter();
            this.dataGridViewBooksUsersJoin = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.buttonBookReturn = new System.Windows.Forms.Button();
            this.buttonBookReturnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBookLibraryUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksUsersJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "OIB:";
            // 
            // textBoxReturnBookLibraryUsersFirstName
            // 
            this.textBoxReturnBookLibraryUsersFirstName.Location = new System.Drawing.Point(103, 6);
            this.textBoxReturnBookLibraryUsersFirstName.Name = "textBoxReturnBookLibraryUsersFirstName";
            this.textBoxReturnBookLibraryUsersFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxReturnBookLibraryUsersFirstName.TabIndex = 3;
            this.textBoxReturnBookLibraryUsersFirstName.TextChanged += new System.EventHandler(this.TextBoxReturnBookUserFirstName_TextChanged);
            // 
            // textBoxReturnBookLibraryUsersLastName
            // 
            this.textBoxReturnBookLibraryUsersLastName.Location = new System.Drawing.Point(103, 40);
            this.textBoxReturnBookLibraryUsersLastName.Name = "textBoxReturnBookLibraryUsersLastName";
            this.textBoxReturnBookLibraryUsersLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxReturnBookLibraryUsersLastName.TabIndex = 4;
            this.textBoxReturnBookLibraryUsersLastName.TextChanged += new System.EventHandler(this.TextBoxReturnBookLibraryUsersLastName_TextChanged);
            // 
            // textBoxReturnBookLibraryUsersOIB
            // 
            this.textBoxReturnBookLibraryUsersOIB.Location = new System.Drawing.Point(103, 71);
            this.textBoxReturnBookLibraryUsersOIB.Name = "textBoxReturnBookLibraryUsersOIB";
            this.textBoxReturnBookLibraryUsersOIB.Size = new System.Drawing.Size(200, 20);
            this.textBoxReturnBookLibraryUsersOIB.TabIndex = 5;
            this.textBoxReturnBookLibraryUsersOIB.TextChanged += new System.EventHandler(this.TextBoxReturnBookLibraryUsersOIB_TextChanged);
            // 
            // dataGridViewReturnBookLibraryUsers
            // 
            this.dataGridViewReturnBookLibraryUsers.AllowUserToAddRows = false;
            this.dataGridViewReturnBookLibraryUsers.AllowUserToDeleteRows = false;
            this.dataGridViewReturnBookLibraryUsers.AutoGenerateColumns = false;
            this.dataGridViewReturnBookLibraryUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturnBookLibraryUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libraryUserIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dataGridViewReturnBookLibraryUsers.DataSource = this.libraryUsersBindingSource;
            this.dataGridViewReturnBookLibraryUsers.Location = new System.Drawing.Point(324, 6);
            this.dataGridViewReturnBookLibraryUsers.Name = "dataGridViewReturnBookLibraryUsers";
            this.dataGridViewReturnBookLibraryUsers.ReadOnly = true;
            this.dataGridViewReturnBookLibraryUsers.Size = new System.Drawing.Size(464, 150);
            this.dataGridViewReturnBookLibraryUsers.TabIndex = 6;
            this.dataGridViewReturnBookLibraryUsers.SelectionChanged += new System.EventHandler(this.DataGridViewReturnBookLibraryUsers_SelectionChanged);
            // 
            // libraryUserIDDataGridViewTextBoxColumn
            // 
            this.libraryUserIDDataGridViewTextBoxColumn.DataPropertyName = "LibraryUserID";
            this.libraryUserIDDataGridViewTextBoxColumn.HeaderText = "LibraryUserID";
            this.libraryUserIDDataGridViewTextBoxColumn.Name = "libraryUserIDDataGridViewTextBoxColumn";
            this.libraryUserIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.libraryUserIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // libraryUsersBindingSource
            // 
            this.libraryUsersBindingSource.DataMember = "LibraryUsers";
            this.libraryUsersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryUsersTableAdapter
            // 
            this.libraryUsersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBooksUsersJoin
            // 
            this.dataGridViewBooksUsersJoin.AllowUserToAddRows = false;
            this.dataGridViewBooksUsersJoin.AllowUserToDeleteRows = false;
            this.dataGridViewBooksUsersJoin.AutoGenerateColumns = false;
            this.dataGridViewBooksUsersJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksUsersJoin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.LendDate,
            this.ReturnDate,
            this.LibraryUserID,
            this.Availability});
            this.dataGridViewBooksUsersJoin.DataSource = this.booksBindingSource;
            this.dataGridViewBooksUsersJoin.Location = new System.Drawing.Point(15, 170);
            this.dataGridViewBooksUsersJoin.Name = "dataGridViewBooksUsersJoin";
            this.dataGridViewBooksUsersJoin.ReadOnly = true;
            this.dataGridViewBooksUsersJoin.Size = new System.Drawing.Size(773, 165);
            this.dataGridViewBooksUsersJoin.TabIndex = 7;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LendDate
            // 
            this.LendDate.DataPropertyName = "LendDate";
            this.LendDate.HeaderText = "LendDate";
            this.LendDate.Name = "LendDate";
            this.LendDate.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // LibraryUserID
            // 
            this.LibraryUserID.DataPropertyName = "LibraryUserID";
            this.LibraryUserID.HeaderText = "LibraryUserID";
            this.LibraryUserID.Name = "LibraryUserID";
            this.LibraryUserID.ReadOnly = true;
            this.LibraryUserID.Visible = false;
            // 
            // Availability
            // 
            this.Availability.DataPropertyName = "Availability";
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            this.Availability.ReadOnly = true;
            this.Availability.Visible = false;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // buttonBookReturn
            // 
            this.buttonBookReturn.Location = new System.Drawing.Point(182, 357);
            this.buttonBookReturn.Name = "buttonBookReturn";
            this.buttonBookReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonBookReturn.TabIndex = 8;
            this.buttonBookReturn.Text = "Return";
            this.buttonBookReturn.UseVisualStyleBackColor = true;
            this.buttonBookReturn.Click += new System.EventHandler(this.ButtonBookReturn_Click);
            // 
            // buttonBookReturnCancel
            // 
            this.buttonBookReturnCancel.Location = new System.Drawing.Point(468, 357);
            this.buttonBookReturnCancel.Name = "buttonBookReturnCancel";
            this.buttonBookReturnCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonBookReturnCancel.TabIndex = 9;
            this.buttonBookReturnCancel.Text = "Cancel";
            this.buttonBookReturnCancel.UseVisualStyleBackColor = true;
            this.buttonBookReturnCancel.Click += new System.EventHandler(this.ButtonBookReturnCancel_Click);
            // 
            // BookReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBookReturnCancel);
            this.Controls.Add(this.buttonBookReturn);
            this.Controls.Add(this.dataGridViewBooksUsersJoin);
            this.Controls.Add(this.dataGridViewReturnBookLibraryUsers);
            this.Controls.Add(this.textBoxReturnBookLibraryUsersOIB);
            this.Controls.Add(this.textBoxReturnBookLibraryUsersLastName);
            this.Controls.Add(this.textBoxReturnBookLibraryUsersFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookReturnForm";
            this.Text = "Book Return";
            this.Load += new System.EventHandler(this.BookReturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturnBookLibraryUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksUsersJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReturnBookLibraryUsersFirstName;
        private System.Windows.Forms.TextBox textBoxReturnBookLibraryUsersLastName;
        private System.Windows.Forms.TextBox textBoxReturnBookLibraryUsersOIB;
        private System.Windows.Forms.DataGridView dataGridViewReturnBookLibraryUsers;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource libraryUsersBindingSource;
        private LibraryDBDataSetTableAdapters.LibraryUsersTableAdapter libraryUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewBooksUsersJoin;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.Button buttonBookReturn;
        private System.Windows.Forms.Button buttonBookReturnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibraryUserID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Availability;
    }
}