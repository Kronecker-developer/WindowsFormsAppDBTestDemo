namespace WindowsFormsAppDBTestDemo
{
    partial class EditLibraryUserForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLibraryUserFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLibraryUserOIB = new System.Windows.Forms.TextBox();
            this.textBoxLibraryUserLastName = new System.Windows.Forms.TextBox();
            this.buttonConfirmLibraryUserEdit = new System.Windows.Forms.Button();
            this.buttonCancelLibraryUserEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "OIB:";
            // 
            // textBoxLibraryUserFirstName
            // 
            this.textBoxLibraryUserFirstName.Location = new System.Drawing.Point(79, 23);
            this.textBoxLibraryUserFirstName.Name = "textBoxLibraryUserFirstName";
            this.textBoxLibraryUserFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUserFirstName.TabIndex = 3;
            // 
            // textBoxLibraryUserOIB
            // 
            this.textBoxLibraryUserOIB.Location = new System.Drawing.Point(79, 100);
            this.textBoxLibraryUserOIB.MaxLength = 11;
            this.textBoxLibraryUserOIB.Name = "textBoxLibraryUserOIB";
            this.textBoxLibraryUserOIB.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUserOIB.TabIndex = 4;
            this.textBoxLibraryUserOIB.TextChanged += new System.EventHandler(this.TextBoxLibraryUserOIB_TextChanged);
            // 
            // textBoxLibraryUserLastName
            // 
            this.textBoxLibraryUserLastName.Location = new System.Drawing.Point(79, 58);
            this.textBoxLibraryUserLastName.Name = "textBoxLibraryUserLastName";
            this.textBoxLibraryUserLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUserLastName.TabIndex = 5;
            // 
            // buttonConfirmLibraryUserEdit
            // 
            this.buttonConfirmLibraryUserEdit.Location = new System.Drawing.Point(79, 138);
            this.buttonConfirmLibraryUserEdit.Name = "buttonConfirmLibraryUserEdit";
            this.buttonConfirmLibraryUserEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmLibraryUserEdit.TabIndex = 6;
            this.buttonConfirmLibraryUserEdit.Text = "Confirm";
            this.buttonConfirmLibraryUserEdit.UseVisualStyleBackColor = true;
            this.buttonConfirmLibraryUserEdit.Click += new System.EventHandler(this.ButtonConfirmLibraryUserEdit_Click);
            // 
            // buttonCancelLibraryUserEdit
            // 
            this.buttonCancelLibraryUserEdit.Location = new System.Drawing.Point(204, 138);
            this.buttonCancelLibraryUserEdit.Name = "buttonCancelLibraryUserEdit";
            this.buttonCancelLibraryUserEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelLibraryUserEdit.TabIndex = 7;
            this.buttonCancelLibraryUserEdit.Text = "Cancel";
            this.buttonCancelLibraryUserEdit.UseVisualStyleBackColor = true;
            this.buttonCancelLibraryUserEdit.Click += new System.EventHandler(this.ButtonCancelLibraryUserEdit_Click);
            // 
            // EditLibraryUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelLibraryUserEdit);
            this.Controls.Add(this.buttonConfirmLibraryUserEdit);
            this.Controls.Add(this.textBoxLibraryUserLastName);
            this.Controls.Add(this.textBoxLibraryUserOIB);
            this.Controls.Add(this.textBoxLibraryUserFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLibraryUserForm";
            this.Text = "Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConfirmLibraryUserEdit;
        private System.Windows.Forms.Button buttonCancelLibraryUserEdit;
        public System.Windows.Forms.TextBox textBoxLibraryUserFirstName;
        public System.Windows.Forms.TextBox textBoxLibraryUserOIB;
        public System.Windows.Forms.TextBox textBoxLibraryUserLastName;
    }
}