namespace WindowsFormsAppDBTestDemo
{
    partial class PublisherForm
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
            this.dataGridViewPublishers = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new WindowsFormsAppDBTestDemo.LibraryDBDataSet();
            this.publishersTableAdapter = new WindowsFormsAppDBTestDemo.LibraryDBDataSetTableAdapters.PublishersTableAdapter();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.buttonEditPublisher = new System.Windows.Forms.Button();
            this.buttonDeletePublisher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPublishers
            // 
            this.dataGridViewPublishers.AllowUserToAddRows = false;
            this.dataGridViewPublishers.AllowUserToDeleteRows = false;
            this.dataGridViewPublishers.AutoGenerateColumns = false;
            this.dataGridViewPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPublishers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn});
            this.dataGridViewPublishers.DataSource = this.publishersBindingSource;
            this.dataGridViewPublishers.Location = new System.Drawing.Point(12, 21);
            this.dataGridViewPublishers.Name = "dataGridViewPublishers";
            this.dataGridViewPublishers.Size = new System.Drawing.Size(350, 150);
            this.dataGridViewPublishers.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Mark";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Location = new System.Drawing.Point(582, 21);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(88, 23);
            this.buttonAddPublisher.TabIndex = 1;
            this.buttonAddPublisher.Text = "Add Publisher";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.ButtonAddPublisher_Click);
            // 
            // buttonEditPublisher
            // 
            this.buttonEditPublisher.Location = new System.Drawing.Point(582, 62);
            this.buttonEditPublisher.Name = "buttonEditPublisher";
            this.buttonEditPublisher.Size = new System.Drawing.Size(88, 23);
            this.buttonEditPublisher.TabIndex = 2;
            this.buttonEditPublisher.Text = "Edit";
            this.buttonEditPublisher.UseVisualStyleBackColor = true;
            this.buttonEditPublisher.Click += new System.EventHandler(this.ButtonEditPublisher_Click);
            // 
            // buttonDeletePublisher
            // 
            this.buttonDeletePublisher.Location = new System.Drawing.Point(582, 100);
            this.buttonDeletePublisher.Name = "buttonDeletePublisher";
            this.buttonDeletePublisher.Size = new System.Drawing.Size(88, 23);
            this.buttonDeletePublisher.TabIndex = 3;
            this.buttonDeletePublisher.Text = "Delete";
            this.buttonDeletePublisher.UseVisualStyleBackColor = true;
            this.buttonDeletePublisher.Click += new System.EventHandler(this.ButtonDeletePublisher_Click);
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeletePublisher);
            this.Controls.Add(this.buttonEditPublisher);
            this.Controls.Add(this.buttonAddPublisher);
            this.Controls.Add(this.dataGridViewPublishers);
            this.Name = "PublisherForm";
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.PublisherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPublishers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPublishers;
        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private LibraryDBDataSetTableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAddPublisher;
        private System.Windows.Forms.Button buttonEditPublisher;
        private System.Windows.Forms.Button buttonDeletePublisher;
    }
}