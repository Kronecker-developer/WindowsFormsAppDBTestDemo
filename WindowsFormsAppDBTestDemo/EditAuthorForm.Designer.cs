namespace WindowsFormsAppDBTestDemo
{
    partial class EditAuthorForm
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
            this.labelEditAuthorFirstName = new System.Windows.Forms.Label();
            this.labelEditAuthorLastName = new System.Windows.Forms.Label();
            this.buttonConfirmAuthorEdit = new System.Windows.Forms.Button();
            this.buttonCancelAuthorEdit = new System.Windows.Forms.Button();
            this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
            this.libraryDBDataSet = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.AuthorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditAuthorFirstName
            // 
            this.labelEditAuthorFirstName.AutoSize = true;
            this.labelEditAuthorFirstName.Location = new System.Drawing.Point(24, 34);
            this.labelEditAuthorFirstName.Name = "labelEditAuthorFirstName";
            this.labelEditAuthorFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelEditAuthorFirstName.TabIndex = 0;
            this.labelEditAuthorFirstName.Text = "First name:";
            // 
            // labelEditAuthorLastName
            // 
            this.labelEditAuthorLastName.AutoSize = true;
            this.labelEditAuthorLastName.Location = new System.Drawing.Point(24, 66);
            this.labelEditAuthorLastName.Name = "labelEditAuthorLastName";
            this.labelEditAuthorLastName.Size = new System.Drawing.Size(59, 13);
            this.labelEditAuthorLastName.TabIndex = 1;
            this.labelEditAuthorLastName.Text = "Last name:";
            // 
            // buttonConfirmAuthorEdit
            // 
            this.buttonConfirmAuthorEdit.Location = new System.Drawing.Point(362, 34);
            this.buttonConfirmAuthorEdit.Name = "buttonConfirmAuthorEdit";
            this.buttonConfirmAuthorEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmAuthorEdit.TabIndex = 2;
            this.buttonConfirmAuthorEdit.Text = "Confirm";
            this.buttonConfirmAuthorEdit.UseVisualStyleBackColor = true;
            this.buttonConfirmAuthorEdit.Click += new System.EventHandler(this.ButtonConfirmAuthorEdit_Click);
            // 
            // buttonCancelAuthorEdit
            // 
            this.buttonCancelAuthorEdit.Location = new System.Drawing.Point(362, 66);
            this.buttonCancelAuthorEdit.Name = "buttonCancelAuthorEdit";
            this.buttonCancelAuthorEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAuthorEdit.TabIndex = 3;
            this.buttonCancelAuthorEdit.Text = "Cancel";
            this.buttonCancelAuthorEdit.UseVisualStyleBackColor = true;
            this.buttonCancelAuthorEdit.Click += new System.EventHandler(this.ButtonCancelAuthorEdit_Click);
            // 
            // textBoxAuthorFirstName
            // 
            this.textBoxAuthorFirstName.Location = new System.Drawing.Point(97, 34);
            this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            this.textBoxAuthorFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxAuthorFirstName.TabIndex = 4;
            // 
            // textBoxAuthorLastName
            // 
            this.textBoxAuthorLastName.Location = new System.Drawing.Point(97, 66);
            this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            this.textBoxAuthorLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxAuthorLastName.TabIndex = 5;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // EditAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAuthorLastName);
            this.Controls.Add(this.textBoxAuthorFirstName);
            this.Controls.Add(this.buttonCancelAuthorEdit);
            this.Controls.Add(this.buttonConfirmAuthorEdit);
            this.Controls.Add(this.labelEditAuthorLastName);
            this.Controls.Add(this.labelEditAuthorFirstName);
            this.Name = "EditAuthorForm";
            this.Text = "EditAuthorForm";
            this.Load += new System.EventHandler(this.EditAuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditAuthorFirstName;
        private System.Windows.Forms.Label labelEditAuthorLastName;
        private System.Windows.Forms.Button buttonConfirmAuthorEdit;
        private System.Windows.Forms.Button buttonCancelAuthorEdit;
        public System.Windows.Forms.TextBox textBoxAuthorFirstName;
        public System.Windows.Forms.TextBox textBoxAuthorLastName;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private LibraryDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
    }
}