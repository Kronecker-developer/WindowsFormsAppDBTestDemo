namespace WindowsFormsAppDBTestDemo
{
    partial class EditBookForm
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
            this.labelEditBookTitle = new System.Windows.Forms.Label();
            this.labelEditBookISBN = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.AuthorsTableAdapter();
            this.publishersTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.PublishersTableAdapter();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditBookTitle
            // 
            this.labelEditBookTitle.AutoSize = true;
            this.labelEditBookTitle.Location = new System.Drawing.Point(41, 36);
            this.labelEditBookTitle.Name = "labelEditBookTitle";
            this.labelEditBookTitle.Size = new System.Drawing.Size(30, 13);
            this.labelEditBookTitle.TabIndex = 0;
            this.labelEditBookTitle.Text = "Title:";
            // 
            // labelEditBookISBN
            // 
            this.labelEditBookISBN.AutoSize = true;
            this.labelEditBookISBN.Location = new System.Drawing.Point(41, 77);
            this.labelEditBookISBN.Name = "labelEditBookISBN";
            this.labelEditBookISBN.Size = new System.Drawing.Size(35, 13);
            this.labelEditBookISBN.TabIndex = 1;
            this.labelEditBookISBN.Text = "ISBN:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(99, 36);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(99, 77);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(200, 20);
            this.textBoxISBN.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(404, 36);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(404, 77);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.AllowDrop = true;
            this.comboBoxAuthor.DataSource = this.authorsBindingSource;
            this.comboBoxAuthor.DisplayMember = "LastName";
            this.comboBoxAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(44, 146);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAuthor.TabIndex = 6;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.AllowDrop = true;
            this.comboBoxPublisher.DataSource = this.publishersBindingSource;
            this.comboBoxPublisher.DisplayMember = "Name";
            this.comboBoxPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(239, 146);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPublisher.TabIndex = 7;
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.AllowDrop = true;
            this.comboBoxCategory.DataSource = this.categoriesBindingSource;
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(465, 146);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategory.TabIndex = 8;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxPublisher);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelEditBookISBN);
            this.Controls.Add(this.labelEditBookTitle);
            this.Name = "EditBookForm";
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditBookTitle;
        private System.Windows.Forms.Label labelEditBookISBN;
        public System.Windows.Forms.TextBox textBoxTitle;
        public System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LibraryDBDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private LibraryDBDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        public System.Windows.Forms.ComboBox comboBoxAuthor;
        public System.Windows.Forms.ComboBox comboBoxPublisher;
        public System.Windows.Forms.ComboBox comboBoxCategory;
    }
}