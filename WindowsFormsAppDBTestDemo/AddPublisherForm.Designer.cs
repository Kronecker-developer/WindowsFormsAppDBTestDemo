namespace WindowsFormsAppDBTestDemo
{
    partial class AddPublisherForm
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
            this.buttonConfirmPublisherAdd = new System.Windows.Forms.Button();
            this.buttonCancelPublisherAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Location = new System.Drawing.Point(26, 35);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(38, 13);
            this.labelPublisherName.TabIndex = 0;
            this.labelPublisherName.Text = "Name:";
            // 
            // labelPublisherMark
            // 
            this.labelPublisherMark.AutoSize = true;
            this.labelPublisherMark.Location = new System.Drawing.Point(26, 72);
            this.labelPublisherMark.Name = "labelPublisherMark";
            this.labelPublisherMark.Size = new System.Drawing.Size(34, 13);
            this.labelPublisherMark.TabIndex = 1;
            this.labelPublisherMark.Text = "Mark:";
            // 
            // textBoxPublisherName
            // 
            this.textBoxPublisherName.Location = new System.Drawing.Point(89, 35);
            this.textBoxPublisherName.Name = "textBoxPublisherName";
            this.textBoxPublisherName.Size = new System.Drawing.Size(200, 20);
            this.textBoxPublisherName.TabIndex = 2;
            // 
            // textBoxPublisherMark
            // 
            this.textBoxPublisherMark.Location = new System.Drawing.Point(89, 69);
            this.textBoxPublisherMark.Name = "textBoxPublisherMark";
            this.textBoxPublisherMark.Size = new System.Drawing.Size(200, 20);
            this.textBoxPublisherMark.TabIndex = 3;
            // 
            // buttonConfirmPublisherAdd
            // 
            this.buttonConfirmPublisherAdd.Location = new System.Drawing.Point(89, 118);
            this.buttonConfirmPublisherAdd.Name = "buttonConfirmPublisherAdd";
            this.buttonConfirmPublisherAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmPublisherAdd.TabIndex = 4;
            this.buttonConfirmPublisherAdd.Text = "Confirm";
            this.buttonConfirmPublisherAdd.UseVisualStyleBackColor = true;
            this.buttonConfirmPublisherAdd.Click += new System.EventHandler(this.ButtonConfirmPublisherAdd_Click);
            // 
            // buttonCancelPublisherAdd
            // 
            this.buttonCancelPublisherAdd.Location = new System.Drawing.Point(214, 118);
            this.buttonCancelPublisherAdd.Name = "buttonCancelPublisherAdd";
            this.buttonCancelPublisherAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelPublisherAdd.TabIndex = 5;
            this.buttonCancelPublisherAdd.Text = "Cancel";
            this.buttonCancelPublisherAdd.UseVisualStyleBackColor = true;
            this.buttonCancelPublisherAdd.Click += new System.EventHandler(this.ButtonCancelPublisherAdd_Click);
            // 
            // AddPublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelPublisherAdd);
            this.Controls.Add(this.buttonConfirmPublisherAdd);
            this.Controls.Add(this.textBoxPublisherMark);
            this.Controls.Add(this.textBoxPublisherName);
            this.Controls.Add(this.labelPublisherMark);
            this.Controls.Add(this.labelPublisherName);
            this.Name = "AddPublisherForm";
            this.Text = "Add Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.Label labelPublisherMark;
        private System.Windows.Forms.TextBox textBoxPublisherName;
        private System.Windows.Forms.TextBox textBoxPublisherMark;
        private System.Windows.Forms.Button buttonConfirmPublisherAdd;
        private System.Windows.Forms.Button buttonCancelPublisherAdd;
    }
}