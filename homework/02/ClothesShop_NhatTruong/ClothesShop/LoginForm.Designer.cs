namespace ClothesShop
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
            txtGmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPass = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(276, 126);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(276, 27);
            txtGmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(183, 128);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 1;
            label1.Text = "Gmail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 212);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "PassWord";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(276, 210);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(276, 27);
            txtPass.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(299, 34);
            label3.Name = "label3";
            label3.Size = new Size(103, 38);
            label3.TabIndex = 4;
            label3.Text = "LOGIN";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(400, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(186, 300);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(118, 29);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(711, 426);
            Controls.Add(btnQuit);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Controls.Add(txtGmail);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "Login Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGmail;
        private Label label1;
        private Label label2;
        private TextBox txtPass;
        private Label label3;
        private Button btnLogin;
        private Button btnQuit;
    }
}
