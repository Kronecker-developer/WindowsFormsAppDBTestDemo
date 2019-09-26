namespace WindowsFormsAppDBTestDemo
{
    partial class BookForm
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSetBooks = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSetBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonLendBook = new System.Windows.Forms.Button();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.textBoxFilterByBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxFilterByBookISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.booksTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.dataGridViewBooksAuthorsJoin = new System.Windows.Forms.DataGridView();
            this.authorBookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsBooksTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.AuthorsBooksTableAdapter();
            this.dataGridViewBooksPublishersJoin = new System.Windows.Forms.DataGridView();
            this.publisherIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherMark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksPublishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publishersTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.PublishersTableAdapter();
            this.booksPublishersTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.BooksPublishersTableAdapter();
            this.dataGridViewBooksCategoriesJoin = new System.Windows.Forms.DataGridView();
            this.bookCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksCategoriesTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.BooksCategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksAuthorsJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksPublishersJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksPublishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksCategoriesJoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksCategoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AutoGenerateColumns = false;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.availabilityDataGridViewCheckBoxColumn,
            this.BookID});
            this.dataGridViewBooks.DataSource = this.booksBindingSource1;
            this.dataGridViewBooks.Location = new System.Drawing.Point(36, 58);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.Size = new System.Drawing.Size(450, 190);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.DataGridViewBooks_SelectionChanged);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // availabilityDataGridViewCheckBoxColumn
            // 
            this.availabilityDataGridViewCheckBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewCheckBoxColumn.Name = "availabilityDataGridViewCheckBoxColumn";
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDBDataSetBooks;
            // 
            // libraryDBDataSetBooks
            // 
            this.libraryDBDataSetBooks.DataSetName = "LibraryDBDataSetBooks";
            this.libraryDBDataSetBooks.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBDataSetBooks;
            // 
            // libraryDBDataSetBooksBindingSource
            // 
            this.libraryDBDataSetBooksBindingSource.DataSource = this.libraryDBDataSetBooks;
            this.libraryDBDataSetBooksBindingSource.Position = 0;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(639, 52);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.ButtonAddBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(639, 90);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(75, 23);
            this.buttonEditBook.TabIndex = 2;
            this.buttonEditBook.Text = "Edit";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(639, 138);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteBook.TabIndex = 3;
            this.buttonDeleteBook.Text = "Delete";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.ButtonDeleteBook_Click);
            // 
            // buttonLendBook
            // 
            this.buttonLendBook.Location = new System.Drawing.Point(639, 186);
            this.buttonLendBook.Name = "buttonLendBook";
            this.buttonLendBook.Size = new System.Drawing.Size(75, 23);
            this.buttonLendBook.TabIndex = 4;
            this.buttonLendBook.Text = "Lend";
            this.buttonLendBook.UseVisualStyleBackColor = true;
            this.buttonLendBook.Click += new System.EventHandler(this.ButtonLendBook_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(639, 225);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(75, 23);
            this.buttonReturnBook.TabIndex = 5;
            this.buttonReturnBook.Text = "Return";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.ButtonReturnBook_Click);
            // 
            // textBoxFilterByBookTitle
            // 
            this.textBoxFilterByBookTitle.Location = new System.Drawing.Point(75, 6);
            this.textBoxFilterByBookTitle.Name = "textBoxFilterByBookTitle";
            this.textBoxFilterByBookTitle.Size = new System.Drawing.Size(250, 20);
            this.textBoxFilterByBookTitle.TabIndex = 7;
            this.textBoxFilterByBookTitle.TextChanged += new System.EventHandler(this.TextBoxFilterByBookTitle_TextChanged);
            // 
            // textBoxFilterByBookISBN
            // 
            this.textBoxFilterByBookISBN.Location = new System.Drawing.Point(75, 32);
            this.textBoxFilterByBookISBN.Name = "textBoxFilterByBookISBN";
            this.textBoxFilterByBookISBN.Size = new System.Drawing.Size(250, 20);
            this.textBoxFilterByBookISBN.TabIndex = 8;
            this.textBoxFilterByBookISBN.TextChanged += new System.EventHandler(this.TextBoxFilterByBookISBN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ISBN:";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBooksAuthorsJoin
            // 
            this.dataGridViewBooksAuthorsJoin.AllowUserToAddRows = false;
            this.dataGridViewBooksAuthorsJoin.AllowUserToDeleteRows = false;
            this.dataGridViewBooksAuthorsJoin.AutoGenerateColumns = false;
            this.dataGridViewBooksAuthorsJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksAuthorsJoin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorBookIDDataGridViewTextBoxColumn,
            this.authorIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.FirstName,
            this.LastName});
            this.dataGridViewBooksAuthorsJoin.DataSource = this.authorsBooksBindingSource;
            this.dataGridViewBooksAuthorsJoin.Location = new System.Drawing.Point(39, 263);
            this.dataGridViewBooksAuthorsJoin.Name = "dataGridViewBooksAuthorsJoin";
            this.dataGridViewBooksAuthorsJoin.ReadOnly = true;
            this.dataGridViewBooksAuthorsJoin.Size = new System.Drawing.Size(246, 150);
            this.dataGridViewBooksAuthorsJoin.TabIndex = 11;
            // 
            // authorBookIDDataGridViewTextBoxColumn
            // 
            this.authorBookIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorBookID";
            this.authorBookIDDataGridViewTextBoxColumn.HeaderText = "AuthorBookID";
            this.authorBookIDDataGridViewTextBoxColumn.Name = "authorBookIDDataGridViewTextBoxColumn";
            this.authorBookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorBookIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // authorsBooksBindingSource
            // 
            this.authorsBooksBindingSource.DataMember = "AuthorsBooks";
            this.authorsBooksBindingSource.DataSource = this.libraryDBDataSetBooks;
            // 
            // authorsBooksTableAdapter
            // 
            this.authorsBooksTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBooksPublishersJoin
            // 
            this.dataGridViewBooksPublishersJoin.AllowUserToAddRows = false;
            this.dataGridViewBooksPublishersJoin.AllowUserToDeleteRows = false;
            this.dataGridViewBooksPublishersJoin.AutoGenerateColumns = false;
            this.dataGridViewBooksPublishersJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksPublishersJoin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.publisherIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.PublisherName,
            this.PublisherMark});
            this.dataGridViewBooksPublishersJoin.DataSource = this.booksPublishersBindingSource;
            this.dataGridViewBooksPublishersJoin.Location = new System.Drawing.Point(324, 263);
            this.dataGridViewBooksPublishersJoin.Name = "dataGridViewBooksPublishersJoin";
            this.dataGridViewBooksPublishersJoin.ReadOnly = true;
            this.dataGridViewBooksPublishersJoin.Size = new System.Drawing.Size(250, 150);
            this.dataGridViewBooksPublishersJoin.TabIndex = 12;
            // 
            // publisherIDDataGridViewTextBoxColumn
            // 
            this.publisherIDDataGridViewTextBoxColumn.DataPropertyName = "PublisherID";
            this.publisherIDDataGridViewTextBoxColumn.HeaderText = "PublisherID";
            this.publisherIDDataGridViewTextBoxColumn.Name = "publisherIDDataGridViewTextBoxColumn";
            this.publisherIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.publisherIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "Name";
            this.PublisherName.HeaderText = "Name";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.ReadOnly = true;
            // 
            // PublisherMark
            // 
            this.PublisherMark.DataPropertyName = "Mark";
            this.PublisherMark.HeaderText = "Mark";
            this.PublisherMark.Name = "PublisherMark";
            this.PublisherMark.ReadOnly = true;
            // 
            // booksPublishersBindingSource
            // 
            this.booksPublishersBindingSource.DataMember = "BooksPublishers";
            this.booksPublishersBindingSource.DataSource = this.libraryDBDataSetBooks;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.libraryDBDataSetBooks;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // booksPublishersTableAdapter
            // 
            this.booksPublishersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBooksCategoriesJoin
            // 
            this.dataGridViewBooksCategoriesJoin.AllowUserToAddRows = false;
            this.dataGridViewBooksCategoriesJoin.AllowUserToDeleteRows = false;
            this.dataGridViewBooksCategoriesJoin.AutoGenerateColumns = false;
            this.dataGridViewBooksCategoriesJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooksCategoriesJoin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCategoryIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn1,
            this.categoryIDDataGridViewTextBoxColumn,
            this.CategoryName,
            this.CategoryDescription});
            this.dataGridViewBooksCategoriesJoin.DataSource = this.booksCategoriesBindingSource;
            this.dataGridViewBooksCategoriesJoin.Location = new System.Drawing.Point(39, 431);
            this.dataGridViewBooksCategoriesJoin.Name = "dataGridViewBooksCategoriesJoin";
            this.dataGridViewBooksCategoriesJoin.ReadOnly = true;
            this.dataGridViewBooksCategoriesJoin.Size = new System.Drawing.Size(535, 150);
            this.dataGridViewBooksCategoriesJoin.TabIndex = 13;
            // 
            // bookCategoryIDDataGridViewTextBoxColumn
            // 
            this.bookCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "BookCategoryID";
            this.bookCategoryIDDataGridViewTextBoxColumn.HeaderText = "BookCategoryID";
            this.bookCategoryIDDataGridViewTextBoxColumn.Name = "bookCategoryIDDataGridViewTextBoxColumn";
            this.bookCategoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookCategoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookIDDataGridViewTextBoxColumn1
            // 
            this.bookIDDataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn1.Name = "bookIDDataGridViewTextBoxColumn1";
            this.bookIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Name";
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // CategoryDescription
            // 
            this.CategoryDescription.DataPropertyName = "Description";
            this.CategoryDescription.HeaderText = "Description";
            this.CategoryDescription.Name = "CategoryDescription";
            this.CategoryDescription.ReadOnly = true;
            // 
            // booksCategoriesBindingSource
            // 
            this.booksCategoriesBindingSource.DataMember = "BooksCategories";
            this.booksCategoriesBindingSource.DataSource = this.libraryDBDataSetBooks;
            // 
            // booksCategoriesTableAdapter
            // 
            this.booksCategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 470);
            this.Controls.Add(this.dataGridViewBooksCategoriesJoin);
            this.Controls.Add(this.dataGridViewBooksPublishersJoin);
            this.Controls.Add(this.dataGridViewBooksAuthorsJoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilterByBookISBN);
            this.Controls.Add(this.textBoxFilterByBookTitle);
            this.Controls.Add(this.buttonReturnBook);
            this.Controls.Add(this.buttonLendBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "BookForm";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.BookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksAuthorsJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksPublishersJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksPublishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooksCategoriesJoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksCategoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource libraryDBDataSetBooksBindingSource;
        private LibraryDBDataSet libraryDBDataSetBooks;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonLendBook;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.TextBox textBoxFilterByBookTitle;
        private System.Windows.Forms.TextBox textBoxFilterByBookISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource authorsBooksBindingSource;
        private LibraryDBDataSetTableAdapters.AuthorsBooksTableAdapter authorsBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorBookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availabilityDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewBooksPublishersJoin;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LibraryDBDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.BindingSource booksPublishersBindingSource;
        private LibraryDBDataSetTableAdapters.BooksPublishersTableAdapter booksPublishersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherMark;
        private System.Windows.Forms.DataGridView dataGridViewBooksCategoriesJoin;
        private System.Windows.Forms.BindingSource booksCategoriesBindingSource;
        private LibraryDBDataSetTableAdapters.BooksCategoriesTableAdapter booksCategoriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCategoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDescription;
        private System.Windows.Forms.DataGridView dataGridViewBooksAuthorsJoin;
        public System.Windows.Forms.DataGridView dataGridViewBooks;
    }
}