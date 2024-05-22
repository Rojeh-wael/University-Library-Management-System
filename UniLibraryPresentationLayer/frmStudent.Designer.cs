namespace UniLibraryPresentationLayer
{
    partial class frmStudent
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
            this.lblforname = new System.Windows.Forms.Label();
            this.dgvAllStudent = new System.Windows.Forms.DataGridView();
            this.lblforBookID = new System.Windows.Forms.Label();
            this.txtforBookID = new System.Windows.Forms.TextBox();
            this.btnforborrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblforname
            // 
            this.lblforname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforname.AutoSize = true;
            this.lblforname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforname.Location = new System.Drawing.Point(12, 25);
            this.lblforname.Name = "lblforname";
            this.lblforname.Size = new System.Drawing.Size(79, 29);
            this.lblforname.TabIndex = 0;
            this.lblforname.Text = "label1";
            // 
            // dgvAllStudent
            // 
            this.dgvAllStudent.AllowUserToAddRows = false;
            this.dgvAllStudent.AllowUserToDeleteRows = false;
            this.dgvAllStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvAllStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStudent.Location = new System.Drawing.Point(17, 330);
            this.dgvAllStudent.Name = "dgvAllStudent";
            this.dgvAllStudent.ReadOnly = true;
            this.dgvAllStudent.RowHeadersWidth = 51;
            this.dgvAllStudent.RowTemplate.Height = 24;
            this.dgvAllStudent.Size = new System.Drawing.Size(846, 239);
            this.dgvAllStudent.TabIndex = 1;
            // 
            // lblforBookID
            // 
            this.lblforBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforBookID.AutoSize = true;
            this.lblforBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforBookID.Location = new System.Drawing.Point(12, 164);
            this.lblforBookID.Name = "lblforBookID";
            this.lblforBookID.Size = new System.Drawing.Size(457, 29);
            this.lblforBookID.TabIndex = 2;
            this.lblforBookID.Text = "Enter BookID for book you want to borrow";
            // 
            // txtforBookID
            // 
            this.txtforBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtforBookID.Location = new System.Drawing.Point(535, 171);
            this.txtforBookID.Name = "txtforBookID";
            this.txtforBookID.Size = new System.Drawing.Size(255, 22);
            this.txtforBookID.TabIndex = 3;
            // 
            // btnforborrow
            // 
            this.btnforborrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnforborrow.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnforborrow.Location = new System.Drawing.Point(347, 250);
            this.btnforborrow.Name = "btnforborrow";
            this.btnforborrow.Size = new System.Drawing.Size(165, 35);
            this.btnforborrow.TabIndex = 4;
            this.btnforborrow.Text = "Borrow";
            this.btnforborrow.UseVisualStyleBackColor = false;
            this.btnforborrow.Click += new System.EventHandler(this.btnforborrow_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.btnforborrow);
            this.Controls.Add(this.txtforBookID);
            this.Controls.Add(this.lblforBookID);
            this.Controls.Add(this.dgvAllStudent);
            this.Controls.Add(this.lblforname);
            this.Name = "frmStudent";
            this.Text = "Student Interface";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblforname;
        private System.Windows.Forms.DataGridView dgvAllStudent;
        private System.Windows.Forms.Label lblforBookID;
        private System.Windows.Forms.TextBox txtforBookID;
        private System.Windows.Forms.Button btnforborrow;
    }
}