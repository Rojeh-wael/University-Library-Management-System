namespace UniLibraryPresentationLayer
{
    partial class Login
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbox_forID = new System.Windows.Forms.TextBox();
            this.radiobtn_forAdmin = new System.Windows.Forms.RadioButton();
            this.radiobtn_forStudent = new System.Windows.Forms.RadioButton();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(220, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(409, 57);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter Your ID";
            // 
            // txtbox_forID
            // 
            this.txtbox_forID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_forID.Location = new System.Drawing.Point(228, 177);
            this.txtbox_forID.Name = "txtbox_forID";
            this.txtbox_forID.Size = new System.Drawing.Size(236, 22);
            this.txtbox_forID.TabIndex = 1;
            // 
            // radiobtn_forAdmin
            // 
            this.radiobtn_forAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radiobtn_forAdmin.AutoSize = true;
            this.radiobtn_forAdmin.Location = new System.Drawing.Point(228, 257);
            this.radiobtn_forAdmin.Name = "radiobtn_forAdmin";
            this.radiobtn_forAdmin.Size = new System.Drawing.Size(112, 20);
            this.radiobtn_forAdmin.TabIndex = 2;
            this.radiobtn_forAdmin.TabStop = true;
            this.radiobtn_forAdmin.Text = "I am an Admin";
            this.radiobtn_forAdmin.UseVisualStyleBackColor = true;
            // 
            // radiobtn_forStudent
            // 
            this.radiobtn_forStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radiobtn_forStudent.AutoSize = true;
            this.radiobtn_forStudent.Location = new System.Drawing.Point(365, 257);
            this.radiobtn_forStudent.Name = "radiobtn_forStudent";
            this.radiobtn_forStudent.Size = new System.Drawing.Size(115, 20);
            this.radiobtn_forStudent.TabIndex = 3;
            this.radiobtn_forStudent.TabStop = true;
            this.radiobtn_forStudent.Text = "I am  a Student";
            this.radiobtn_forStudent.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.Location = new System.Drawing.Point(228, 314);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(236, 33);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SignUp.Location = new System.Drawing.Point(228, 384);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(236, 33);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 546);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.radiobtn_forStudent);
            this.Controls.Add(this.radiobtn_forAdmin);
            this.Controls.Add(this.txtbox_forID);
            this.Controls.Add(this.lbl1);
            this.Name = "Login";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtbox_forID;
        private System.Windows.Forms.RadioButton radiobtn_forAdmin;
        private System.Windows.Forms.RadioButton radiobtn_forStudent;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_SignUp;
    }
}

