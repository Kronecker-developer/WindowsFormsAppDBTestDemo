namespace WindowsFormsAppDBTestDemo
{
    partial class LibraryUserForm
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
            this.dataGridViewLibraryUsers = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.libraryUsersTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.LibraryUsersTableAdapter();
            this.buttonAddLibraryUser = new System.Windows.Forms.Button();
            this.buttonEditLibraryUser = new System.Windows.Forms.Button();
            this.buttonDeleteLibraryUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibraryUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLibraryUsers
            // 
            this.dataGridViewLibraryUsers.AllowUserToAddRows = false;
            this.dataGridViewLibraryUsers.AllowUserToDeleteRows = false;
            this.dataGridViewLibraryUsers.AutoGenerateColumns = false;
            this.dataGridViewLibraryUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibraryUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn});
            this.dataGridViewLibraryUsers.DataSource = this.libraryUsersBindingSource;
            this.dataGridViewLibraryUsers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewLibraryUsers.Name = "dataGridViewLibraryUsers";
            this.dataGridViewLibraryUsers.ReadOnly = true;
            this.dataGridViewLibraryUsers.Size = new System.Drawing.Size(448, 150);
            this.dataGridViewLibraryUsers.TabIndex = 0;
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
            // buttonAddLibraryUser
            // 
            this.buttonAddLibraryUser.Location = new System.Drawing.Point(588, 29);
            this.buttonAddLibraryUser.Name = "buttonAddLibraryUser";
            this.buttonAddLibraryUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLibraryUser.TabIndex = 1;
            this.buttonAddLibraryUser.Text = "Add User";
            this.buttonAddLibraryUser.UseVisualStyleBackColor = true;
            this.buttonAddLibraryUser.Click += new System.EventHandler(this.ButtonAddLibraryUser_Click);
            // 
            // buttonEditLibraryUser
            // 
            this.buttonEditLibraryUser.Location = new System.Drawing.Point(588, 70);
            this.buttonEditLibraryUser.Name = "buttonEditLibraryUser";
            this.buttonEditLibraryUser.Size = new System.Drawing.Size(75, 23);
            this.buttonEditLibraryUser.TabIndex = 2;
            this.buttonEditLibraryUser.Text = "Edit";
            this.buttonEditLibraryUser.UseVisualStyleBackColor = true;
            this.buttonEditLibraryUser.Click += new System.EventHandler(this.ButtonEditLibraryUser_Click);
            // 
            // buttonDeleteLibraryUser
            // 
            this.buttonDeleteLibraryUser.Location = new System.Drawing.Point(588, 111);
            this.buttonDeleteLibraryUser.Name = "buttonDeleteLibraryUser";
            this.buttonDeleteLibraryUser.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteLibraryUser.TabIndex = 3;
            this.buttonDeleteLibraryUser.Text = "Delete";
            this.buttonDeleteLibraryUser.UseVisualStyleBackColor = true;
            this.buttonDeleteLibraryUser.Click += new System.EventHandler(this.ButtonDeleteLibraryUser_Click);
            // 
            // LibraryUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteLibraryUser);
            this.Controls.Add(this.buttonEditLibraryUser);
            this.Controls.Add(this.buttonAddLibraryUser);
            this.Controls.Add(this.dataGridViewLibraryUsers);
            this.Name = "LibraryUserForm";
            this.Text = "User";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibraryUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLibraryUsers;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource libraryUsersBindingSource;
        private LibraryDBDataSetTableAdapters.LibraryUsersTableAdapter libraryUsersTableAdapter;
        private System.Windows.Forms.Button buttonAddLibraryUser;
        private System.Windows.Forms.Button buttonEditLibraryUser;
        private System.Windows.Forms.Button buttonDeleteLibraryUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
    }
}