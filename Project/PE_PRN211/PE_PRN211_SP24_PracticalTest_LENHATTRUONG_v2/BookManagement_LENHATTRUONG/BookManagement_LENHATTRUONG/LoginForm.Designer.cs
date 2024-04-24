namespace BookManagement_LENHATTRUONG
{
    partial class LoginForm
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
            txtHearder = new Label();
            lblGmail = new Label();
            lblPassword = new Label();
            txtGmail = new TextBox();
            txtPassWord = new TextBox();
            btnQuit = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtHearder
            // 
            txtHearder.AutoSize = true;
            txtHearder.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtHearder.Location = new Point(328, 46);
            txtHearder.Name = "txtHearder";
            txtHearder.Size = new Size(90, 38);
            txtHearder.TabIndex = 0;
            txtHearder.Text = "Login";
            // 
            // lblGmail
            // 
            lblGmail.AutoSize = true;
            lblGmail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGmail.Location = new Point(167, 150);
            lblGmail.Name = "lblGmail";
            lblGmail.Size = new Size(60, 25);
            lblGmail.TabIndex = 1;
            lblGmail.Text = "Gmail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(134, 218);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(93, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "PassWord";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(272, 148);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(313, 27);
            txtGmail.TabIndex = 3;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(272, 216);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(313, 27);
            txtPassWord.TabIndex = 4;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(203, 310);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(123, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(462, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(763, 440);
            Controls.Add(btnLogin);
            Controls.Add(btnQuit);
            Controls.Add(txtPassWord);
            Controls.Add(txtGmail);
            Controls.Add(lblPassword);
            Controls.Add(lblGmail);
            Controls.Add(txtHearder);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Login";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtHearder;
        private Label lblGmail;
        private Label lblPassword;
        private TextBox txtGmail;
        private TextBox txtPassWord;
        private Button btnQuit;
        private Button btnLogin;
    }
}