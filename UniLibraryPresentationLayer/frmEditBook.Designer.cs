namespace UniLibraryPresentationLayer
{
    partial class frmEditBook
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
            this.btnforAdd = new System.Windows.Forms.Button();
            this.txtforAuther = new System.Windows.Forms.TextBox();
            this.txtforPubisher = new System.Windows.Forms.TextBox();
            this.txtProd_year = new System.Windows.Forms.TextBox();
            this.txtforCopies = new System.Windows.Forms.TextBox();
            this.txtforCategory = new System.Windows.Forms.TextBox();
            this.txtForTitle = new System.Windows.Forms.TextBox();
            this.txtforISNB = new System.Windows.Forms.TextBox();
            this.lblforAuther = new System.Windows.Forms.Label();
            this.lblforPubisher = new System.Windows.Forms.Label();
            this.lblForTitle = new System.Windows.Forms.Label();
            this.lblforProd_year = new System.Windows.Forms.Label();
            this.lblforCopies = new System.Windows.Forms.Label();
            this.lblforCategory = new System.Windows.Forms.Label();
            this.lblforISNB = new System.Windows.Forms.Label();
            this.lblforBookID = new System.Windows.Forms.Label();
            this.lblforAuthorName = new System.Windows.Forms.Label();
            this.lblForPubisherName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnforAdd
            // 
            this.btnforAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnforAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnforAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforAdd.Location = new System.Drawing.Point(349, 681);
            this.btnforAdd.Name = "btnforAdd";
            this.btnforAdd.Size = new System.Drawing.Size(233, 48);
            this.btnforAdd.TabIndex = 30;
            this.btnforAdd.Text = "Edit";
            this.btnforAdd.UseVisualStyleBackColor = false;
            this.btnforAdd.Click += new System.EventHandler(this.btnforAdd_Click);
            // 
            // txtforAuther
            // 
            this.txtforAuther.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtforAuther.Location = new System.Drawing.Point(327, 576);
            this.txtforAuther.Name = "txtforAuther";
            this.txtforAuther.Size = new System.Drawing.Size(127, 22);
            this.txtforAuther.TabIndex = 29;
            // 
            // txtforPubisher
            // 
            this.txtforPubisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtforPubisher.Location = new System.Drawing.Point(741, 436);
            this.txtforPubisher.Name = "txtforPubisher";
            this.txtforPubisher.Size = new System.Drawing.Size(173, 22);
            this.txtforPubisher.TabIndex = 28;
            // 
            // txtProd_year
            // 
            this.txtProd_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProd_year.Location = new System.Drawing.Point(327, 434);
            this.txtProd_year.Name = "txtProd_year";
            this.txtProd_year.Size = new System.Drawing.Size(127, 22);
            this.txtProd_year.TabIndex = 27;
            // 
            // txtforCopies
            // 
            this.txtforCopies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtforCopies.Location = new System.Drawing.Point(741, 281);
            this.txtforCopies.Name = "txtforCopies";
            this.txtforCopies.Size = new System.Drawing.Size(173, 22);
            this.txtforCopies.TabIndex = 26;
            // 
            // txtforCategory
            // 
            this.txtforCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtforCategory.Location = new System.Drawing.Point(327, 288);
            this.txtforCategory.Name = "txtforCategory";
            this.txtforCategory.Size = new System.Drawing.Size(127, 22);
            this.txtforCategory.TabIndex = 25;
            // 
            // txtForTitle
            // 
            this.txtForTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForTitle.Location = new System.Drawing.Point(741, 161);
            this.txtForTitle.Name = "txtForTitle";
            this.txtForTitle.Size = new System.Drawing.Size(173, 22);
            this.txtForTitle.TabIndex = 24;
            // 
            // txtforISNB
            // 
            this.txtforISNB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtforISNB.Location = new System.Drawing.Point(327, 168);
            this.txtforISNB.Name = "txtforISNB";
            this.txtforISNB.Size = new System.Drawing.Size(127, 22);
            this.txtforISNB.TabIndex = 23;
            // 
            // lblforAuther
            // 
            this.lblforAuther.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforAuther.AutoSize = true;
            this.lblforAuther.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforAuther.Location = new System.Drawing.Point(101, 569);
            this.lblforAuther.Name = "lblforAuther";
            this.lblforAuther.Size = new System.Drawing.Size(111, 29);
            this.lblforAuther.TabIndex = 22;
            this.lblforAuther.Text = "Author ID";
            // 
            // lblforPubisher
            // 
            this.lblforPubisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforPubisher.AutoSize = true;
            this.lblforPubisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforPubisher.Location = new System.Drawing.Point(563, 434);
            this.lblforPubisher.Name = "lblforPubisher";
            this.lblforPubisher.Size = new System.Drawing.Size(150, 29);
            this.lblforPubisher.TabIndex = 21;
            this.lblforPubisher.Text = "Publisher ID ";
            // 
            // lblForTitle
            // 
            this.lblForTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForTitle.AutoSize = true;
            this.lblForTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForTitle.Location = new System.Drawing.Point(563, 161);
            this.lblForTitle.Name = "lblForTitle";
            this.lblForTitle.Size = new System.Drawing.Size(67, 29);
            this.lblForTitle.TabIndex = 20;
            this.lblForTitle.Text = "Title ";
            // 
            // lblforProd_year
            // 
            this.lblforProd_year.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforProd_year.AutoSize = true;
            this.lblforProd_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforProd_year.Location = new System.Drawing.Point(101, 427);
            this.lblforProd_year.Name = "lblforProd_year";
            this.lblforProd_year.Size = new System.Drawing.Size(181, 29);
            this.lblforProd_year.TabIndex = 19;
            this.lblforProd_year.Text = "Production year";
            // 
            // lblforCopies
            // 
            this.lblforCopies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforCopies.AutoSize = true;
            this.lblforCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforCopies.Location = new System.Drawing.Point(565, 281);
            this.lblforCopies.Name = "lblforCopies";
            this.lblforCopies.Size = new System.Drawing.Size(90, 29);
            this.lblforCopies.TabIndex = 18;
            this.lblforCopies.Text = "Copies";
            // 
            // lblforCategory
            // 
            this.lblforCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforCategory.AutoSize = true;
            this.lblforCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforCategory.Location = new System.Drawing.Point(101, 281);
            this.lblforCategory.Name = "lblforCategory";
            this.lblforCategory.Size = new System.Drawing.Size(110, 29);
            this.lblforCategory.TabIndex = 17;
            this.lblforCategory.Text = "Category";
            // 
            // lblforISNB
            // 
            this.lblforISNB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblforISNB.AutoSize = true;
            this.lblforISNB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforISNB.Location = new System.Drawing.Point(101, 161);
            this.lblforISNB.Name = "lblforISNB";
            this.lblforISNB.Size = new System.Drawing.Size(69, 29);
            this.lblforISNB.TabIndex = 16;
            this.lblforISNB.Text = "ISNB";
            // 
            // lblforBookID
            // 
            this.lblforBookID.AutoSize = true;
            this.lblforBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforBookID.Location = new System.Drawing.Point(176, 51);
            this.lblforBookID.Name = "lblforBookID";
            this.lblforBookID.Size = new System.Drawing.Size(109, 38);
            this.lblforBookID.TabIndex = 31;
            this.lblforBookID.Text = "label1";
            // 
            // lblforAuthorName
            // 
            this.lblforAuthorName.AutoSize = true;
            this.lblforAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforAuthorName.Location = new System.Drawing.Point(649, 526);
            this.lblforAuthorName.Name = "lblforAuthorName";
            this.lblforAuthorName.Size = new System.Drawing.Size(53, 20);
            this.lblforAuthorName.TabIndex = 32;
            this.lblforAuthorName.Text = "label1";
            // 
            // lblForPubisherName
            // 
            this.lblForPubisherName.AutoSize = true;
            this.lblForPubisherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForPubisherName.Location = new System.Drawing.Point(649, 600);
            this.lblForPubisherName.Name = "lblForPubisherName";
            this.lblForPubisherName.Size = new System.Drawing.Size(53, 20);
            this.lblForPubisherName.TabIndex = 33;
            this.lblForPubisherName.Text = "label2";
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1015, 768);
            this.Controls.Add(this.lblForPubisherName);
            this.Controls.Add(this.lblforAuthorName);
            this.Controls.Add(this.lblforBookID);
            this.Controls.Add(this.btnforAdd);
            this.Controls.Add(this.txtforAuther);
            this.Controls.Add(this.txtforPubisher);
            this.Controls.Add(this.txtProd_year);
            this.Controls.Add(this.txtforCopies);
            this.Controls.Add(this.txtforCategory);
            this.Controls.Add(this.txtForTitle);
            this.Controls.Add(this.txtforISNB);
            this.Controls.Add(this.lblforAuther);
            this.Controls.Add(this.lblforPubisher);
            this.Controls.Add(this.lblForTitle);
            this.Controls.Add(this.lblforProd_year);
            this.Controls.Add(this.lblforCopies);
            this.Controls.Add(this.lblforCategory);
            this.Controls.Add(this.lblforISNB);
            this.Name = "frmEditBook";
            this.Text = "Edit Book";
            this.Load += new System.EventHandler(this.frmEditBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnforAdd;
        private System.Windows.Forms.TextBox txtforAuther;
        private System.Windows.Forms.TextBox txtforPubisher;
        private System.Windows.Forms.TextBox txtProd_year;
        private System.Windows.Forms.TextBox txtforCopies;
        private System.Windows.Forms.TextBox txtforCategory;
        private System.Windows.Forms.TextBox txtForTitle;
        private System.Windows.Forms.TextBox txtforISNB;
        private System.Windows.Forms.Label lblforAuther;
        private System.Windows.Forms.Label lblforPubisher;
        private System.Windows.Forms.Label lblForTitle;
        private System.Windows.Forms.Label lblforProd_year;
        private System.Windows.Forms.Label lblforCopies;
        private System.Windows.Forms.Label lblforCategory;
        private System.Windows.Forms.Label lblforISNB;
        private System.Windows.Forms.Label lblforBookID;
        private System.Windows.Forms.Label lblforAuthorName;
        private System.Windows.Forms.Label lblForPubisherName;
    }
}