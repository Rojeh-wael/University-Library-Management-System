namespace UniLibraryPresentationLayer
{
    partial class frmEditAdminandStudent
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
            this.lblForID = new System.Windows.Forms.Label();
            this.lblForFirstName = new System.Windows.Forms.Label();
            this.lblForLastName = new System.Windows.Forms.Label();
            this.lblForEmail = new System.Windows.Forms.Label();
            this.lblForGender = new System.Windows.Forms.Label();
            this.txtForFirstName = new System.Windows.Forms.TextBox();
            this.txtForLastName = new System.Windows.Forms.TextBox();
            this.txtForEmail = new System.Windows.Forms.TextBox();
            this.btnForEdit = new System.Windows.Forms.Button();
            this.cmFroGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblForID
            // 
            this.lblForID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForID.AutoSize = true;
            this.lblForID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForID.Location = new System.Drawing.Point(191, 47);
            this.lblForID.Name = "lblForID";
            this.lblForID.Size = new System.Drawing.Size(79, 29);
            this.lblForID.TabIndex = 0;
            this.lblForID.Text = "label1";
            // 
            // lblForFirstName
            // 
            this.lblForFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForFirstName.AutoSize = true;
            this.lblForFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForFirstName.Location = new System.Drawing.Point(81, 124);
            this.lblForFirstName.Name = "lblForFirstName";
            this.lblForFirstName.Size = new System.Drawing.Size(137, 29);
            this.lblForFirstName.TabIndex = 1;
            this.lblForFirstName.Text = "First Name ";
            // 
            // lblForLastName
            // 
            this.lblForLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForLastName.AutoSize = true;
            this.lblForLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForLastName.Location = new System.Drawing.Point(81, 241);
            this.lblForLastName.Name = "lblForLastName";
            this.lblForLastName.Size = new System.Drawing.Size(134, 29);
            this.lblForLastName.TabIndex = 2;
            this.lblForLastName.Text = "Last Name ";
            // 
            // lblForEmail
            // 
            this.lblForEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForEmail.AutoSize = true;
            this.lblForEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForEmail.Location = new System.Drawing.Point(81, 335);
            this.lblForEmail.Name = "lblForEmail";
            this.lblForEmail.Size = new System.Drawing.Size(74, 29);
            this.lblForEmail.TabIndex = 3;
            this.lblForEmail.Text = "Email";
            // 
            // lblForGender
            // 
            this.lblForGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForGender.AutoSize = true;
            this.lblForGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForGender.Location = new System.Drawing.Point(81, 425);
            this.lblForGender.Name = "lblForGender";
            this.lblForGender.Size = new System.Drawing.Size(94, 29);
            this.lblForGender.TabIndex = 4;
            this.lblForGender.Text = "Gender";
            // 
            // txtForFirstName
            // 
            this.txtForFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForFirstName.Location = new System.Drawing.Point(338, 131);
            this.txtForFirstName.Name = "txtForFirstName";
            this.txtForFirstName.Size = new System.Drawing.Size(145, 22);
            this.txtForFirstName.TabIndex = 5;
            // 
            // txtForLastName
            // 
            this.txtForLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForLastName.Location = new System.Drawing.Point(338, 248);
            this.txtForLastName.Name = "txtForLastName";
            this.txtForLastName.Size = new System.Drawing.Size(145, 22);
            this.txtForLastName.TabIndex = 6;
            // 
            // txtForEmail
            // 
            this.txtForEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForEmail.Location = new System.Drawing.Point(338, 342);
            this.txtForEmail.Name = "txtForEmail";
            this.txtForEmail.Size = new System.Drawing.Size(145, 22);
            this.txtForEmail.TabIndex = 7;
            // 
            // btnForEdit
            // 
            this.btnForEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForEdit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnForEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForEdit.Location = new System.Drawing.Point(219, 525);
            this.btnForEdit.Name = "btnForEdit";
            this.btnForEdit.Size = new System.Drawing.Size(118, 45);
            this.btnForEdit.TabIndex = 9;
            this.btnForEdit.Text = "Edit ";
            this.btnForEdit.UseVisualStyleBackColor = false;
            this.btnForEdit.Click += new System.EventHandler(this.btnForEdit_Click);
            // 
            // cmFroGender
            // 
            this.cmFroGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmFroGender.FormattingEnabled = true;
            this.cmFroGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmFroGender.Location = new System.Drawing.Point(338, 425);
            this.cmFroGender.Name = "cmFroGender";
            this.cmFroGender.Size = new System.Drawing.Size(145, 24);
            this.cmFroGender.TabIndex = 10;
            // 
            // frmEditAdminandStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 690);
            this.Controls.Add(this.cmFroGender);
            this.Controls.Add(this.btnForEdit);
            this.Controls.Add(this.txtForEmail);
            this.Controls.Add(this.txtForLastName);
            this.Controls.Add(this.txtForFirstName);
            this.Controls.Add(this.lblForGender);
            this.Controls.Add(this.lblForEmail);
            this.Controls.Add(this.lblForLastName);
            this.Controls.Add(this.lblForFirstName);
            this.Controls.Add(this.lblForID);
            this.Name = "frmEditAdminandStudent";
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.frmEditAdminandStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForID;
        private System.Windows.Forms.Label lblForFirstName;
        private System.Windows.Forms.Label lblForLastName;
        private System.Windows.Forms.Label lblForEmail;
        private System.Windows.Forms.Label lblForGender;
        private System.Windows.Forms.TextBox txtForFirstName;
        private System.Windows.Forms.TextBox txtForLastName;
        private System.Windows.Forms.TextBox txtForEmail;
        private System.Windows.Forms.Button btnForEdit;
        private System.Windows.Forms.ComboBox cmFroGender;
    }
}