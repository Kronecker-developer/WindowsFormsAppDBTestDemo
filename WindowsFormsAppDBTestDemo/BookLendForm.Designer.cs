namespace WindowsFormsAppDBTestDemo
{
    partial class BookLendForm
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
            this.textBoxLendBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxLendBookISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLendBook = new System.Windows.Forms.Button();
            this.buttonCancelLendBook = new System.Windows.Forms.Button();
            this.dataGridViewLibraryUsers = new System.Windows.Forms.DataGridView();
            this.libraryDBDataSet = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.libraryUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryUsersTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.LibraryUsersTableAdapter();
            this.libraryUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLibraryUsersFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLibraryUsersLastName = new System.Windows.Forms.TextBox();
            this.textBoxLibraryUsersOIB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibraryUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLendBookTitle
            // 
            this.textBoxLendBookTitle.Location = new System.Drawing.Point(94, 23);
            this.textBoxLendBookTitle.Name = "textBoxLendBookTitle";
            this.textBoxLendBookTitle.ReadOnly = true;
            this.textBoxLendBookTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxLendBookTitle.TabIndex = 0;
            // 
            // textBoxLendBookISBN
            // 
            this.textBoxLendBookISBN.Location = new System.Drawing.Point(94, 62);
            this.textBoxLendBookISBN.Name = "textBoxLendBookISBN";
            this.textBoxLendBookISBN.ReadOnly = true;
            this.textBoxLendBookISBN.Size = new System.Drawing.Size(200, 20);
            this.textBoxLendBookISBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN:";
            // 
            // buttonLendBook
            // 
            this.buttonLendBook.Location = new System.Drawing.Point(94, 108);
            this.buttonLendBook.Name = "buttonLendBook";
            this.buttonLendBook.Size = new System.Drawing.Size(75, 23);
            this.buttonLendBook.TabIndex = 4;
            this.buttonLendBook.Text = "Lend";
            this.buttonLendBook.UseVisualStyleBackColor = true;
            this.buttonLendBook.Click += new System.EventHandler(this.ButtonLendBook_Click);
            // 
            // buttonCancelLendBook
            // 
            this.buttonCancelLendBook.Location = new System.Drawing.Point(219, 108);
            this.buttonCancelLendBook.Name = "buttonCancelLendBook";
            this.buttonCancelLendBook.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelLendBook.TabIndex = 5;
            this.buttonCancelLendBook.Text = "Cancel";
            this.buttonCancelLendBook.UseVisualStyleBackColor = true;
            this.buttonCancelLendBook.Click += new System.EventHandler(this.ButtonCancelLendBook_Click);
            // 
            // dataGridViewLibraryUsers
            // 
            this.dataGridViewLibraryUsers.AllowUserToAddRows = false;
            this.dataGridViewLibraryUsers.AllowUserToDeleteRows = false;
            this.dataGridViewLibraryUsers.AutoGenerateColumns = false;
            this.dataGridViewLibraryUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibraryUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libraryUserIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dataGridViewLibraryUsers.DataSource = this.libraryUsersBindingSource;
            this.dataGridViewLibraryUsers.Location = new System.Drawing.Point(338, 23);
            this.dataGridViewLibraryUsers.Name = "dataGridViewLibraryUsers";
            this.dataGridViewLibraryUsers.ReadOnly = true;
            this.dataGridViewLibraryUsers.Size = new System.Drawing.Size(432, 150);
            this.dataGridViewLibraryUsers.TabIndex = 6;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryUsersBindingSource
            // 
            this.libraryUsersBindingSource.DataMember = "LibraryUsers";
            this.libraryUsersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryUsersTableAdapter
            // 
            this.libraryUsersTableAdapter.ClearBeforeFill = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "OIB:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // textBoxLibraryUsersFirstName
            // 
            this.textBoxLibraryUsersFirstName.Location = new System.Drawing.Point(422, 198);
            this.textBoxLibraryUsersFirstName.Name = "textBoxLibraryUsersFirstName";
            this.textBoxLibraryUsersFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUsersFirstName.TabIndex = 10;
            this.textBoxLibraryUsersFirstName.TextChanged += new System.EventHandler(this.TextBoxLibraryUsersFirstName_TextChanged);
            // 
            // textBoxLibraryUsersLastName
            // 
            this.textBoxLibraryUsersLastName.Location = new System.Drawing.Point(422, 230);
            this.textBoxLibraryUsersLastName.Name = "textBoxLibraryUsersLastName";
            this.textBoxLibraryUsersLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUsersLastName.TabIndex = 11;
            this.textBoxLibraryUsersLastName.TextChanged += new System.EventHandler(this.TextBoxLibraryUsersLastName_TextChanged);
            // 
            // textBoxLibraryUsersOIB
            // 
            this.textBoxLibraryUsersOIB.Location = new System.Drawing.Point(422, 261);
            this.textBoxLibraryUsersOIB.Name = "textBoxLibraryUsersOIB";
            this.textBoxLibraryUsersOIB.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUsersOIB.TabIndex = 12;
            this.textBoxLibraryUsersOIB.TextChanged += new System.EventHandler(this.TextBoxLibraryUsersOIB_TextChanged);
            // 
            // BookLendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLibraryUsersOIB);
            this.Controls.Add(this.textBoxLibraryUsersLastName);
            this.Controls.Add(this.textBoxLibraryUsersFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewLibraryUsers);
            this.Controls.Add(this.buttonCancelLendBook);
            this.Controls.Add(this.buttonLendBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLendBookISBN);
            this.Controls.Add(this.textBoxLendBookTitle);
            this.Name = "BookLendForm";
            this.Text = "BookLendForm";
            this.Load += new System.EventHandler(this.BookLendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibraryUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLendBook;
        private System.Windows.Forms.Button buttonCancelLendBook;
        private System.Windows.Forms.DataGridView dataGridViewLibraryUsers;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource libraryUsersBindingSource;
        private LibraryDBDataSetTableAdapters.LibraryUsersTableAdapter libraryUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn libraryUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLibraryUsersFirstName;
        private System.Windows.Forms.TextBox textBoxLibraryUsersLastName;
        private System.Windows.Forms.TextBox textBoxLibraryUsersOIB;
        public System.Windows.Forms.TextBox textBoxLendBookTitle;
        public System.Windows.Forms.TextBox textBoxLendBookISBN;
    }
}