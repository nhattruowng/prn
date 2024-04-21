namespace bai1
{
    partial class Main1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(495, 19);
            label1.TabIndex = 0;
            label1.Text = "You cannot take the exam if EOS runs under a virtual machine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 61);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 1;
            label2.Text = "Exam Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(95, 19);
            label3.TabIndex = 2;
            label3.Text = "User Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(91, 19);
            label4.TabIndex = 3;
            label4.Text = "PassWord";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(109, 53);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(356, 27);
            txtCode.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(109, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(356, 27);
            txtName.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(109, 151);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(356, 27);
            txtPass.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(109, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 29);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(293, 237);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(106, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(78, 307);
            label5.Name = "label5";
            label5.Size = new Size(363, 23);
            label5.TabIndex = 9;
            label5.Text = "Register the exam may take time, please wait!";
            // 
            // Main1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 339);
            Controls.Add(label5);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main1";
            Text = "EOS";
            Load += Main1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnExit;
        private Label label5;
    }
}
