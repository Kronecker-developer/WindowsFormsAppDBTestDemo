namespace WindowsFormsAppDBTestDemo
{
    partial class AddAuthorForm
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
            this.labelAuthorFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
            this.buttonConfirmAuthorAdd = new System.Windows.Forms.Button();
            this.buttonCancelAuthorAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthorFirstName
            // 
            this.labelAuthorFirstName.AutoSize = true;
            this.labelAuthorFirstName.Location = new System.Drawing.Point(32, 27);
            this.labelAuthorFirstName.Name = "labelAuthorFirstName";
            this.labelAuthorFirstName.Size = new System.Drawing.Size(58, 13);
            this.labelAuthorFirstName.TabIndex = 0;
            this.labelAuthorFirstName.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // textBoxAuthorFirstName
            // 
            this.textBoxAuthorFirstName.Location = new System.Drawing.Point(122, 27);
            this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            this.textBoxAuthorFirstName.Size = new System.Drawing.Size(200, 20);
            this.textBoxAuthorFirstName.TabIndex = 2;
            // 
            // textBoxAuthorLastName
            // 
            this.textBoxAuthorLastName.Location = new System.Drawing.Point(122, 67);
            this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            this.textBoxAuthorLastName.Size = new System.Drawing.Size(200, 20);
            this.textBoxAuthorLastName.TabIndex = 3;
            // 
            // buttonConfirmAuthorAdd
            // 
            this.buttonConfirmAuthorAdd.Location = new System.Drawing.Point(122, 118);
            this.buttonConfirmAuthorAdd.Name = "buttonConfirmAuthorAdd";
            this.buttonConfirmAuthorAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmAuthorAdd.TabIndex = 4;
            this.buttonConfirmAuthorAdd.Text = "Add";
            this.buttonConfirmAuthorAdd.UseVisualStyleBackColor = true;
            this.buttonConfirmAuthorAdd.Click += new System.EventHandler(this.ButtonConfirmAuthorAdd_Click);
            // 
            // buttonCancelAuthorAdd
            // 
            this.buttonCancelAuthorAdd.Location = new System.Drawing.Point(247, 118);
            this.buttonCancelAuthorAdd.Name = "buttonCancelAuthorAdd";
            this.buttonCancelAuthorAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelAuthorAdd.TabIndex = 5;
            this.buttonCancelAuthorAdd.Text = "Cancel";
            this.buttonCancelAuthorAdd.UseVisualStyleBackColor = true;
            this.buttonCancelAuthorAdd.Click += new System.EventHandler(this.ButtonCancelAuthorAdd_Click);
            // 
            // AddAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelAuthorAdd);
            this.Controls.Add(this.buttonConfirmAuthorAdd);
            this.Controls.Add(this.textBoxAuthorLastName);
            this.Controls.Add(this.textBoxAuthorFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAuthorFirstName);
            this.Name = "AddAuthorForm";
            this.Text = "Add Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuthorFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAuthorFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorLastName;
        private System.Windows.Forms.Button buttonConfirmAuthorAdd;
        private System.Windows.Forms.Button buttonCancelAuthorAdd;
    }
}