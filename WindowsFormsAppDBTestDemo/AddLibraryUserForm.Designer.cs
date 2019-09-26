namespace WindowsFormsAppDBTestDemo
{
    partial class AddLibraryUserForm
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
            this.labelLibraryUserFirstName = new System.Windows.Forms.Label();
            this.labelLibraryUserLastName = new System.Windows.Forms.Label();
            this.labelLibraryUserOIB = new System.Windows.Forms.Label();
            this.textBoxLibraryUserFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLibraryUserLastName = new System.Windows.Forms.TextBox();
            this.textBoxLibraryUserOIB = new System.Windows.Forms.TextBox();
            this.buttonConfirmLibraryUserAdd = new System.Windows.Forms.Button();
            this.buttonCancelLibraryUserAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLibraryUserFirstName
            // 
            this.labelLibraryUserFirstName.AutoSize = true;
            this.labelLibraryUserFirstName.Location = new System.Drawing.Point(12, 25);
            this.labelLibraryUserFirstName.Name = "labelLibraryUserFirstName";
            this.labelLibraryUserFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelLibraryUserFirstName.TabIndex = 0;
            this.labelLibraryUserFirstName.Text = "First Name:";
            // 
            // labelLibraryUserLastName
            // 
            this.labelLibraryUserLastName.AutoSize = true;
            this.labelLibraryUserLastName.Location = new System.Drawing.Point(12, 65);
            this.labelLibraryUserLastName.Name = "labelLibraryUserLastName";
            this.labelLibraryUserLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLibraryUserLastName.TabIndex = 1;
            this.labelLibraryUserLastName.Text = "Last Name:";
            // 
            // labelLibraryUserOIB
            // 
            this.labelLibraryUserOIB.AutoSize = true;
            this.labelLibraryUserOIB.Location = new System.Drawing.Point(12, 102);
            this.labelLibraryUserOIB.Name = "labelLibraryUserOIB";
            this.labelLibraryUserOIB.Size = new System.Drawing.Size(28, 13);
            this.labelLibraryUserOIB.TabIndex = 2;
            this.labelLibraryUserOIB.Text = "OIB:";
            // 
            // textBoxLibraryUserFirstName
            // 
            this.textBoxLibraryUserFirstName.Location = new System.Drawing.Point(79, 25);
            this.textBoxLibraryUserFirstName.Name = "textBoxLibraryUserFirstName";
            this.textBoxLibraryUserFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUserFirstName.TabIndex = 3;
            // 
            // textBoxLibraryUserLastName
            // 
            this.textBoxLibraryUserLastName.Location = new System.Drawing.Point(79, 65);
            this.textBoxLibraryUserLastName.Name = "textBoxLibraryUserLastName";
            this.textBoxLibraryUserLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUserLastName.TabIndex = 4;
            // 
            // textBoxLibraryUserOIB
            // 
            this.textBoxLibraryUserOIB.Location = new System.Drawing.Point(79, 102);
            this.textBoxLibraryUserOIB.MaxLength = 11;
            this.textBoxLibraryUserOIB.Name = "textBoxLibraryUserOIB";
            this.textBoxLibraryUserOIB.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibraryUserOIB.TabIndex = 5;
            // 
            // buttonConfirmLibraryUserAdd
            // 
            this.buttonConfirmLibraryUserAdd.Location = new System.Drawing.Point(79, 141);
            this.buttonConfirmLibraryUserAdd.Name = "buttonConfirmLibraryUserAdd";
            this.buttonConfirmLibraryUserAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmLibraryUserAdd.TabIndex = 6;
            this.buttonConfirmLibraryUserAdd.Text = "Confirm";
            this.buttonConfirmLibraryUserAdd.UseVisualStyleBackColor = true;
            this.buttonConfirmLibraryUserAdd.Click += new System.EventHandler(this.ButtonConfirmLibraryUserAdd_Click);
            // 
            // buttonCancelLibraryUserAdd
            // 
            this.buttonCancelLibraryUserAdd.Location = new System.Drawing.Point(204, 141);
            this.buttonCancelLibraryUserAdd.Name = "buttonCancelLibraryUserAdd";
            this.buttonCancelLibraryUserAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelLibraryUserAdd.TabIndex = 7;
            this.buttonCancelLibraryUserAdd.Text = "Cancel";
            this.buttonCancelLibraryUserAdd.UseVisualStyleBackColor = true;
            this.buttonCancelLibraryUserAdd.Click += new System.EventHandler(this.ButtonCancelLibraryUserAdd_Click);
            // 
            // AddLibraryUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelLibraryUserAdd);
            this.Controls.Add(this.buttonConfirmLibraryUserAdd);
            this.Controls.Add(this.textBoxLibraryUserOIB);
            this.Controls.Add(this.textBoxLibraryUserLastName);
            this.Controls.Add(this.textBoxLibraryUserFirstName);
            this.Controls.Add(this.labelLibraryUserOIB);
            this.Controls.Add(this.labelLibraryUserLastName);
            this.Controls.Add(this.labelLibraryUserFirstName);
            this.Name = "AddLibraryUserForm";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLibraryUserFirstName;
        private System.Windows.Forms.Label labelLibraryUserLastName;
        private System.Windows.Forms.Label labelLibraryUserOIB;
        private System.Windows.Forms.TextBox textBoxLibraryUserFirstName;
        private System.Windows.Forms.TextBox textBoxLibraryUserLastName;
        private System.Windows.Forms.TextBox textBoxLibraryUserOIB;
        private System.Windows.Forms.Button buttonConfirmLibraryUserAdd;
        private System.Windows.Forms.Button buttonCancelLibraryUserAdd;
    }
}