namespace WindowsFormsAppDBTestDemo
{
    partial class AuthorForm
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
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.authorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSetAuthors = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonEditAuthor = new System.Windows.Forms.Button();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.authorsTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.AuthorsTableAdapter();
            this.libraryDBDataSetAuthorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetAuthorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AllowUserToDeleteRows = false;
            this.dataGridViewAuthors.AutoGenerateColumns = false;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridViewAuthors.DataSource = this.authorsBindingSource;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(25, 26);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.ReadOnly = true;
            this.dataGridViewAuthors.Size = new System.Drawing.Size(343, 150);
            this.dataGridViewAuthors.TabIndex = 0;
            // 
            // authorIDDataGridViewTextBoxColumn
            // 
            this.authorIDDataGridViewTextBoxColumn.DataPropertyName = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.HeaderText = "AuthorID";
            this.authorIDDataGridViewTextBoxColumn.Name = "authorIDDataGridViewTextBoxColumn";
            this.authorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorIDDataGridViewTextBoxColumn.Visible = false;
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
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDBDataSetAuthors;
            // 
            // libraryDBDataSetAuthors
            // 
            this.libraryDBDataSetAuthors.DataSetName = "LibraryDBDataSetAuthors";
            this.libraryDBDataSetAuthors.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(412, 254);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(8, 8);
            this.dataGridView2.TabIndex = 1;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(610, 41);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAuthor.TabIndex = 2;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.ButtonAddAuthor_Click);
            // 
            // buttonEditAuthor
            // 
            this.buttonEditAuthor.Location = new System.Drawing.Point(610, 82);
            this.buttonEditAuthor.Name = "buttonEditAuthor";
            this.buttonEditAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonEditAuthor.TabIndex = 3;
            this.buttonEditAuthor.Text = "Edit";
            this.buttonEditAuthor.UseVisualStyleBackColor = true;
            this.buttonEditAuthor.Click += new System.EventHandler(this.ButtonEditAuthor_Click);
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(610, 123);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAuthor.TabIndex = 4;
            this.buttonDeleteAuthor.Text = "Delete";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.ButtonDeleteAuthor_Click);
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteAuthor);
            this.Controls.Add(this.buttonEditAuthor);
            this.Controls.Add(this.buttonAddAuthor);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewAuthors);
            this.Name = "AuthorForm";
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSetAuthorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonEditAuthor;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private LibraryDBDataSet libraryDBDataSetAuthors;
        private System.Windows.Forms.BindingSource libraryDBDataSetAuthorsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}