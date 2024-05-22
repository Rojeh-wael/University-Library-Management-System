namespace UniLibraryPresentationLayer
{
    partial class frmAddAdminandStudent
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
            this.btntoAddnewUser = new System.Windows.Forms.Button();
            this.txtForFirstNAme = new System.Windows.Forms.TextBox();
            this.txtForLAstName = new System.Windows.Forms.TextBox();
            this.txtForEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblforLastName = new System.Windows.Forms.Label();
            this.lblforEmail = new System.Windows.Forms.Label();
            this.lblForGender = new System.Windows.Forms.Label();
            this.cbFroGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btntoAddnewUser
            // 
            this.btntoAddnewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntoAddnewUser.BackColor = System.Drawing.Color.Gold;
            this.btntoAddnewUser.Location = new System.Drawing.Point(345, 436);
            this.btntoAddnewUser.Name = "btntoAddnewUser";
            this.btntoAddnewUser.Size = new System.Drawing.Size(131, 45);
            this.btntoAddnewUser.TabIndex = 0;
            this.btntoAddnewUser.Text = "Add ";
            this.btntoAddnewUser.UseVisualStyleBackColor = false;
            this.btntoAddnewUser.Click += new System.EventHandler(this.btntoAddnewUser_Click);
            // 
            // txtForFirstNAme
            // 
            this.txtForFirstNAme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForFirstNAme.Location = new System.Drawing.Point(345, 60);
            this.txtForFirstNAme.Name = "txtForFirstNAme";
            this.txtForFirstNAme.Size = new System.Drawing.Size(145, 22);
            this.txtForFirstNAme.TabIndex = 1;
            // 
            // txtForLAstName
            // 
            this.txtForLAstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForLAstName.Location = new System.Drawing.Point(345, 156);
            this.txtForLAstName.Name = "txtForLAstName";
            this.txtForLAstName.Size = new System.Drawing.Size(145, 22);
            this.txtForLAstName.TabIndex = 3;
            // 
            // txtForEmail
            // 
            this.txtForEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForEmail.Location = new System.Drawing.Point(345, 245);
            this.txtForEmail.Name = "txtForEmail";
            this.txtForEmail.Size = new System.Drawing.Size(145, 22);
            this.txtForEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // lblforLastName
            // 
            this.lblforLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforLastName.AutoSize = true;
            this.lblforLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforLastName.Location = new System.Drawing.Point(142, 156);
            this.lblforLastName.Name = "lblforLastName";
            this.lblforLastName.Size = new System.Drawing.Size(128, 29);
            this.lblforLastName.TabIndex = 6;
            this.lblforLastName.Text = "Last Name";
            // 
            // lblforEmail
            // 
            this.lblforEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforEmail.AutoSize = true;
            this.lblforEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforEmail.Location = new System.Drawing.Point(142, 245);
            this.lblforEmail.Name = "lblforEmail";
            this.lblforEmail.Size = new System.Drawing.Size(74, 29);
            this.lblforEmail.TabIndex = 7;
            this.lblforEmail.Text = "Email";
            // 
            // lblForGender
            // 
            this.lblForGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForGender.AutoSize = true;
            this.lblForGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForGender.Location = new System.Drawing.Point(142, 323);
            this.lblForGender.Name = "lblForGender";
            this.lblForGender.Size = new System.Drawing.Size(94, 29);
            this.lblForGender.TabIndex = 8;
            this.lblForGender.Text = "Gender";
            // 
            // cbFroGender
            // 
            this.cbFroGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFroGender.FormattingEnabled = true;
            this.cbFroGender.Items.AddRange(new object[] {
            "Male\t",
            "Female"});
            this.cbFroGender.Location = new System.Drawing.Point(336, 327);
            this.cbFroGender.Name = "cbFroGender";
            this.cbFroGender.Size = new System.Drawing.Size(154, 24);
            this.cbFroGender.TabIndex = 10;
            // 
            // frmAddAdminandStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 553);
            this.Controls.Add(this.cbFroGender);
            this.Controls.Add(this.lblForGender);
            this.Controls.Add(this.lblforEmail);
            this.Controls.Add(this.lblforLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtForEmail);
            this.Controls.Add(this.txtForLAstName);
            this.Controls.Add(this.txtForFirstNAme);
            this.Controls.Add(this.btntoAddnewUser);
            this.Name = "frmAddAdminandStudent";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddAdminandStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntoAddnewUser;
        private System.Windows.Forms.TextBox txtForFirstNAme;
        private System.Windows.Forms.TextBox txtForLAstName;
        private System.Windows.Forms.TextBox txtForEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblforLastName;
        private System.Windows.Forms.Label lblforEmail;
        private System.Windows.Forms.Label lblForGender;
        private System.Windows.Forms.ComboBox cbFroGender;
    }
}