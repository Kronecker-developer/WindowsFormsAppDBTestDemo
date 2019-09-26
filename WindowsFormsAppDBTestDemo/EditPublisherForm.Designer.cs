namespace WindowsFormsAppDBTestDemo
{
    partial class EditPublisherForm
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
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.labelPublisherMark = new System.Windows.Forms.Label();
            this.textBoxPublisherName = new System.Windows.Forms.TextBox();
            this.textBoxPublisherMark = new System.Windows.Forms.TextBox();
            this.buttonConfirmPublisherEdit = new System.Windows.Forms.Button();
            this.buttonCancelPublisherEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Location = new System.Drawing.Point(24, 29);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(53, 13);
            this.labelPublisherName.TabIndex = 0;
            this.labelPublisherName.Text = "Publisher:";
            // 
            // labelPublisherMark
            // 
            this.labelPublisherMark.AutoSize = true;
            this.labelPublisherMark.Location = new System.Drawing.Point(24, 74);
            this.labelPublisherMark.Name = "labelPublisherMark";
            this.labelPublisherMark.Size = new System.Drawing.Size(34, 13);
            this.labelPublisherMark.TabIndex = 1;
            this.labelPublisherMark.Text = "Mark:";
            // 
            // textBoxPublisherName
            // 
            this.textBoxPublisherName.Location = new System.Drawing.Point(90, 29);
            this.textBoxPublisherName.Name = "textBoxPublisherName";
            this.textBoxPublisherName.Size = new System.Drawing.Size(200, 20);
            this.textBoxPublisherName.TabIndex = 2;
            // 
            // textBoxPublisherMark
            // 
            this.textBoxPublisherMark.Location = new System.Drawing.Point(90, 67);
            this.textBoxPublisherMark.Name = "textBoxPublisherMark";
            this.textBoxPublisherMark.Size = new System.Drawing.Size(200, 20);
            this.textBoxPublisherMark.TabIndex = 3;
            // 
            // buttonConfirmPublisherEdit
            // 
            this.buttonConfirmPublisherEdit.Location = new System.Drawing.Point(90, 109);
            this.buttonConfirmPublisherEdit.Name = "buttonConfirmPublisherEdit";
            this.buttonConfirmPublisherEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmPublisherEdit.TabIndex = 4;
            this.buttonConfirmPublisherEdit.Text = "Confirm";
            this.buttonConfirmPublisherEdit.UseVisualStyleBackColor = true;
            this.buttonConfirmPublisherEdit.Click += new System.EventHandler(this.ButtonConfirmPublisherEdit_Click);
            // 
            // buttonCancelPublisherEdit
            // 
            this.buttonCancelPublisherEdit.Location = new System.Drawing.Point(215, 109);
            this.buttonCancelPublisherEdit.Name = "buttonCancelPublisherEdit";
            this.buttonCancelPublisherEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelPublisherEdit.TabIndex = 5;
            this.buttonCancelPublisherEdit.Text = "Cancel";
            this.buttonCancelPublisherEdit.UseVisualStyleBackColor = true;
            this.buttonCancelPublisherEdit.Click += new System.EventHandler(this.ButtonCancelPublisherEdit_Click);
            // 
            // EditPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelPublisherEdit);
            this.Controls.Add(this.buttonConfirmPublisherEdit);
            this.Controls.Add(this.textBoxPublisherMark);
            this.Controls.Add(this.textBoxPublisherName);
            this.Controls.Add(this.labelPublisherMark);
            this.Controls.Add(this.labelPublisherName);
            this.Name = "EditPublisherForm";
            this.Text = "Edit Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.Label labelPublisherMark;
        private System.Windows.Forms.Button buttonConfirmPublisherEdit;
        private System.Windows.Forms.Button buttonCancelPublisherEdit;
        public System.Windows.Forms.TextBox textBoxPublisherName;
        public System.Windows.Forms.TextBox textBoxPublisherMark;
    }
}