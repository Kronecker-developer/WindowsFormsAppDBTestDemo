namespace WindowsFormsAppDBTestDemo
{
    partial class EditCategoryForm
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
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.labelCategoryDescription = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.textBoxCategoryDescription = new System.Windows.Forms.TextBox();
            this.buttonConfirmCategoryEdit = new System.Windows.Forms.Button();
            this.buttonCancelCategoryEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(21, 29);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(38, 13);
            this.labelCategoryName.TabIndex = 0;
            this.labelCategoryName.Text = "Name:";
            // 
            // labelCategoryDescription
            // 
            this.labelCategoryDescription.AutoSize = true;
            this.labelCategoryDescription.Location = new System.Drawing.Point(21, 75);
            this.labelCategoryDescription.Name = "labelCategoryDescription";
            this.labelCategoryDescription.Size = new System.Drawing.Size(63, 13);
            this.labelCategoryDescription.TabIndex = 1;
            this.labelCategoryDescription.Text = "Description:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(103, 29);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCategoryName.TabIndex = 2;
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(103, 72);
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxCategoryDescription.TabIndex = 3;
            // 
            // buttonConfirmCategoryEdit
            // 
            this.buttonConfirmCategoryEdit.Location = new System.Drawing.Point(103, 116);
            this.buttonConfirmCategoryEdit.Name = "buttonConfirmCategoryEdit";
            this.buttonConfirmCategoryEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmCategoryEdit.TabIndex = 4;
            this.buttonConfirmCategoryEdit.Text = "Confirm";
            this.buttonConfirmCategoryEdit.UseVisualStyleBackColor = true;
            this.buttonConfirmCategoryEdit.Click += new System.EventHandler(this.ButtonConfirmCategoryEdit_Click);
            // 
            // buttonCancelCategoryEdit
            // 
            this.buttonCancelCategoryEdit.Location = new System.Drawing.Point(228, 116);
            this.buttonCancelCategoryEdit.Name = "buttonCancelCategoryEdit";
            this.buttonCancelCategoryEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelCategoryEdit.TabIndex = 5;
            this.buttonCancelCategoryEdit.Text = "Cancel";
            this.buttonCancelCategoryEdit.UseVisualStyleBackColor = true;
            this.buttonCancelCategoryEdit.Click += new System.EventHandler(this.ButtonCancelCategoryEdit_Click);
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelCategoryEdit);
            this.Controls.Add(this.buttonConfirmCategoryEdit);
            this.Controls.Add(this.textBoxCategoryDescription);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelCategoryDescription);
            this.Controls.Add(this.labelCategoryName);
            this.Name = "EditCategoryForm";
            this.Text = "Edit Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelCategoryDescription;
        private System.Windows.Forms.Button buttonConfirmCategoryEdit;
        private System.Windows.Forms.Button buttonCancelCategoryEdit;
        public System.Windows.Forms.TextBox textBoxCategoryName;
        public System.Windows.Forms.TextBox textBoxCategoryDescription;
    }
}