namespace WindowsFormsAppDBTestDemo
{
    partial class AddBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.buttonConfirmBookAdd = new System.Windows.Forms.Button();
            this.buttonCancelBookAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(134, 21);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxBookTitle.TabIndex = 2;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(134, 63);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(200, 20);
            this.textBoxISBN.TabIndex = 3;
            // 
            // buttonConfirmBookAdd
            // 
            this.buttonConfirmBookAdd.Location = new System.Drawing.Point(134, 120);
            this.buttonConfirmBookAdd.Name = "buttonConfirmBookAdd";
            this.buttonConfirmBookAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmBookAdd.TabIndex = 4;
            this.buttonConfirmBookAdd.Text = "Add";
            this.buttonConfirmBookAdd.UseVisualStyleBackColor = true;
            this.buttonConfirmBookAdd.Click += new System.EventHandler(this.ButtonConfirmBookAdd_Click);
            // 
            // buttonCancelBookAdd
            // 
            this.buttonCancelBookAdd.Location = new System.Drawing.Point(259, 120);
            this.buttonCancelBookAdd.Name = "buttonCancelBookAdd";
            this.buttonCancelBookAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelBookAdd.TabIndex = 5;
            this.buttonCancelBookAdd.Text = "Cancel";
            this.buttonCancelBookAdd.UseVisualStyleBackColor = true;
            this.buttonCancelBookAdd.Click += new System.EventHandler(this.ButtonCancelBookAdd_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelBookAdd);
            this.Controls.Add(this.buttonConfirmBookAdd);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.textBoxBookTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Button buttonConfirmBookAdd;
        private System.Windows.Forms.Button buttonCancelBookAdd;
    }
}