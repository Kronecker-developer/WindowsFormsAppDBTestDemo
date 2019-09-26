namespace WindowsFormsAppDBTestDemo
{
    partial class AddCategoryForm
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
            this.buttonConfirmCategoryAdd = new System.Windows.Forms.Button();
            this.buttonCancelCategoryAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(25, 32);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(38, 13);
            this.labelCategoryName.TabIndex = 0;
            this.labelCategoryName.Text = "Name:";
            // 
            // labelCategoryDescription
            // 
            this.labelCategoryDescription.AutoSize = true;
            this.labelCategoryDescription.Location = new System.Drawing.Point(25, 81);
            this.labelCategoryDescription.Name = "labelCategoryDescription";
            this.labelCategoryDescription.Size = new System.Drawing.Size(63, 13);
            this.labelCategoryDescription.TabIndex = 1;
            this.labelCategoryDescription.Text = "Description:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(94, 32);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(200, 20);
            this.textBoxCategoryName.TabIndex = 2;
            // 
            // textBoxCategoryDescription
            // 
            this.textBoxCategoryDescription.Location = new System.Drawing.Point(94, 74);
            this.textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            this.textBoxCategoryDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxCategoryDescription.TabIndex = 3;
            // 
            // buttonConfirmCategoryAdd
            // 
            this.buttonConfirmCategoryAdd.Location = new System.Drawing.Point(94, 117);
            this.buttonConfirmCategoryAdd.Name = "buttonConfirmCategoryAdd";
            this.buttonConfirmCategoryAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmCategoryAdd.TabIndex = 4;
            this.buttonConfirmCategoryAdd.Text = "Confirm";
            this.buttonConfirmCategoryAdd.UseVisualStyleBackColor = true;
            this.buttonConfirmCategoryAdd.Click += new System.EventHandler(this.ButtonConfirmCategoryAdd_Click);
            // 
            // buttonCancelCategoryAdd
            // 
            this.buttonCancelCategoryAdd.Location = new System.Drawing.Point(219, 117);
            this.buttonCancelCategoryAdd.Name = "buttonCancelCategoryAdd";
            this.buttonCancelCategoryAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelCategoryAdd.TabIndex = 5;
            this.buttonCancelCategoryAdd.Text = "Cancel";
            this.buttonCancelCategoryAdd.UseVisualStyleBackColor = true;
            this.buttonCancelCategoryAdd.Click += new System.EventHandler(this.ButtonCancelCategoryAdd_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelCategoryAdd);
            this.Controls.Add(this.buttonConfirmCategoryAdd);
            this.Controls.Add(this.textBoxCategoryDescription);
            this.Controls.Add(this.textBoxCategoryName);
            this.Controls.Add(this.labelCategoryDescription);
            this.Controls.Add(this.labelCategoryName);
            this.Name = "AddCategoryForm";
            this.Text = "Add Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Label labelCategoryDescription;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryDescription;
        private System.Windows.Forms.Button buttonConfirmCategoryAdd;
        private System.Windows.Forms.Button buttonCancelCategoryAdd;
    }
}