namespace WindowsFormsAppDBTestDemo
{
    partial class MainForm
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
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonAuthors = new System.Windows.Forms.Button();
            this.buttonPublishers = new System.Windows.Forms.Button();
            this.buttonCategories = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBooks
            // 
            this.buttonBooks.Location = new System.Drawing.Point(328, 52);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(97, 37);
            this.buttonBooks.TabIndex = 0;
            this.buttonBooks.Text = "Books";
            this.buttonBooks.UseVisualStyleBackColor = true;
            this.buttonBooks.Click += new System.EventHandler(this.ButtonBooks_Click);
            // 
            // buttonAuthors
            // 
            this.buttonAuthors.Location = new System.Drawing.Point(328, 116);
            this.buttonAuthors.Name = "buttonAuthors";
            this.buttonAuthors.Size = new System.Drawing.Size(97, 37);
            this.buttonAuthors.TabIndex = 1;
            this.buttonAuthors.Text = "Authors";
            this.buttonAuthors.UseVisualStyleBackColor = true;
            this.buttonAuthors.Click += new System.EventHandler(this.ButtonAuthors_Click);
            // 
            // buttonPublishers
            // 
            this.buttonPublishers.Location = new System.Drawing.Point(328, 180);
            this.buttonPublishers.Name = "buttonPublishers";
            this.buttonPublishers.Size = new System.Drawing.Size(97, 37);
            this.buttonPublishers.TabIndex = 2;
            this.buttonPublishers.Text = "Publishers";
            this.buttonPublishers.UseVisualStyleBackColor = true;
            this.buttonPublishers.Click += new System.EventHandler(this.ButtonPublishers_Click);
            // 
            // buttonCategories
            // 
            this.buttonCategories.Location = new System.Drawing.Point(328, 244);
            this.buttonCategories.Name = "buttonCategories";
            this.buttonCategories.Size = new System.Drawing.Size(97, 37);
            this.buttonCategories.TabIndex = 3;
            this.buttonCategories.Text = "Categories";
            this.buttonCategories.UseVisualStyleBackColor = true;
            this.buttonCategories.Click += new System.EventHandler(this.ButtonCategories_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(328, 308);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(97, 37);
            this.buttonUser.TabIndex = 4;
            this.buttonUser.Text = "Users";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.ButtonUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonCategories);
            this.Controls.Add(this.buttonPublishers);
            this.Controls.Add(this.buttonAuthors);
            this.Controls.Add(this.buttonBooks);
            this.Name = "MainForm";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Button buttonAuthors;
        private System.Windows.Forms.Button buttonPublishers;
        private System.Windows.Forms.Button buttonCategories;
        private System.Windows.Forms.Button buttonUser;
    }
}