namespace UniLibraryPresentationLayer
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.lblforAdminName = new System.Windows.Forms.Label();
            this.dgvForAllAdminandBooks = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnforAdmin = new System.Windows.Forms.Button();
            this.btnForStudent = new System.Windows.Forms.Button();
            this.btnforBrowsingbooks = new System.Windows.Forms.Button();
            this.btntoAddAdmin = new System.Windows.Forms.Button();
            this.btntoAddStudent = new System.Windows.Forms.Button();
            this.btnToAddBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForAllAdminandBooks)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblforAdminName
            // 
            this.lblforAdminName.AutoSize = true;
            this.lblforAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforAdminName.Location = new System.Drawing.Point(12, 22);
            this.lblforAdminName.Name = "lblforAdminName";
            this.lblforAdminName.Size = new System.Drawing.Size(109, 38);
            this.lblforAdminName.TabIndex = 0;
            this.lblforAdminName.Text = "label1";
            // 
            // dgvForAllAdminandBooks
            // 
            this.dgvForAllAdminandBooks.AllowUserToAddRows = false;
            this.dgvForAllAdminandBooks.AllowUserToDeleteRows = false;
            this.dgvForAllAdminandBooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvForAllAdminandBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForAllAdminandBooks.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvForAllAdminandBooks.Location = new System.Drawing.Point(19, 274);
            this.dgvForAllAdminandBooks.Name = "dgvForAllAdminandBooks";
            this.dgvForAllAdminandBooks.ReadOnly = true;
            this.dgvForAllAdminandBooks.RowHeadersWidth = 51;
            this.dgvForAllAdminandBooks.RowTemplate.Height = 24;
            this.dgvForAllAdminandBooks.Size = new System.Drawing.Size(608, 291);
            this.dgvForAllAdminandBooks.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.tsmDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(122, 24);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(122, 24);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // btnforAdmin
            // 
            this.btnforAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnforAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnforAdmin.Location = new System.Drawing.Point(493, 228);
            this.btnforAdmin.Name = "btnforAdmin";
            this.btnforAdmin.Size = new System.Drawing.Size(121, 40);
            this.btnforAdmin.TabIndex = 3;
            this.btnforAdmin.Text = "Get All Admin";
            this.btnforAdmin.UseVisualStyleBackColor = false;
            this.btnforAdmin.Click += new System.EventHandler(this.btnforAdmin_Click);
            // 
            // btnForStudent
            // 
            this.btnForStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnForStudent.Location = new System.Drawing.Point(226, 228);
            this.btnForStudent.Name = "btnForStudent";
            this.btnForStudent.Size = new System.Drawing.Size(168, 35);
            this.btnForStudent.TabIndex = 5;
            this.btnForStudent.Text = "Get All Student";
            this.btnForStudent.UseVisualStyleBackColor = false;
            this.btnForStudent.Click += new System.EventHandler(this.btnForStudent_Click);
            // 
            // btnforBrowsingbooks
            // 
            this.btnforBrowsingbooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnforBrowsingbooks.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnforBrowsingbooks.Location = new System.Drawing.Point(19, 226);
            this.btnforBrowsingbooks.Name = "btnforBrowsingbooks";
            this.btnforBrowsingbooks.Size = new System.Drawing.Size(119, 37);
            this.btnforBrowsingbooks.TabIndex = 2;
            this.btnforBrowsingbooks.Text = "Browsing books ";
            this.btnforBrowsingbooks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnforBrowsingbooks.UseVisualStyleBackColor = false;
            this.btnforBrowsingbooks.Click += new System.EventHandler(this.btnforBrowsingbooks_Click);
            // 
            // btntoAddAdmin
            // 
            this.btntoAddAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntoAddAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btntoAddAdmin.Location = new System.Drawing.Point(748, 274);
            this.btntoAddAdmin.Name = "btntoAddAdmin";
            this.btntoAddAdmin.Size = new System.Drawing.Size(142, 52);
            this.btntoAddAdmin.TabIndex = 6;
            this.btntoAddAdmin.Text = "Add Admin";
            this.btntoAddAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btntoAddAdmin.UseVisualStyleBackColor = false;
            this.btntoAddAdmin.Click += new System.EventHandler(this.btntoAddAdmin_Click);
            // 
            // btntoAddStudent
            // 
            this.btntoAddStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntoAddStudent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btntoAddStudent.Location = new System.Drawing.Point(748, 513);
            this.btntoAddStudent.Name = "btntoAddStudent";
            this.btntoAddStudent.Size = new System.Drawing.Size(142, 52);
            this.btntoAddStudent.TabIndex = 7;
            this.btntoAddStudent.Text = "Add Student";
            this.btntoAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btntoAddStudent.UseVisualStyleBackColor = false;
            this.btntoAddStudent.Click += new System.EventHandler(this.btntoAddStudent_Click);
            // 
            // btnToAddBook
            // 
            this.btnToAddBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToAddBook.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnToAddBook.Location = new System.Drawing.Point(748, 42);
            this.btnToAddBook.Name = "btnToAddBook";
            this.btnToAddBook.Size = new System.Drawing.Size(142, 52);
            this.btnToAddBook.TabIndex = 8;
            this.btnToAddBook.Text = "Add Book";
            this.btnToAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnToAddBook.UseVisualStyleBackColor = false;
            this.btnToAddBook.Click += new System.EventHandler(this.btnToAddBook_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 603);
            this.Controls.Add(this.btnToAddBook);
            this.Controls.Add(this.btntoAddStudent);
            this.Controls.Add(this.btntoAddAdmin);
            this.Controls.Add(this.btnForStudent);
            this.Controls.Add(this.btnforAdmin);
            this.Controls.Add(this.btnforBrowsingbooks);
            this.Controls.Add(this.dgvForAllAdminandBooks);
            this.Controls.Add(this.lblforAdminName);
            this.Name = "frmAdmin";
            this.Text = "Admin Interface";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForAllAdminandBooks)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblforAdminName;
        private System.Windows.Forms.DataGridView dgvForAllAdminandBooks;
        private System.Windows.Forms.Button btnforAdmin;
        private System.Windows.Forms.Button btnForStudent;
        private System.Windows.Forms.Button btnforBrowsingbooks;
        private System.Windows.Forms.Button btntoAddAdmin;
        private System.Windows.Forms.Button btntoAddStudent;
        private System.Windows.Forms.Button btnToAddBook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
    }
}