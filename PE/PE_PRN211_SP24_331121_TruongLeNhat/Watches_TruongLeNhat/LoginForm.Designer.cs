namespace Watches_TruongLeNhat
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHearder = new Label();
            txtEmail = new TextBox();
            bkhab = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblHearder
            // 
            lblHearder.AutoSize = true;
            lblHearder.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHearder.Location = new Point(311, 51);
            lblHearder.Name = "lblHearder";
            lblHearder.Size = new Size(82, 31);
            lblHearder.TabIndex = 0;
            lblHearder.Text = "LOGIN";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(225, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(330, 27);
            txtEmail.TabIndex = 1;
            // 
            // bkhab
            // 
            bkhab.AutoSize = true;
            bkhab.Location = new Point(153, 147);
            bkhab.Name = "bkhab";
            bkhab.Size = new Size(46, 20);
            bkhab.TabIndex = 2;
            bkhab.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 200);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(225, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(330, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(461, 283);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(225, 283);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 405);
            Controls.Add(btnQuit);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(bkhab);
            Controls.Add(txtEmail);
            Controls.Add(lblHearder);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHearder;
        private TextBox txtEmail;
        private Label bkhab;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnQuit;
    }
}
