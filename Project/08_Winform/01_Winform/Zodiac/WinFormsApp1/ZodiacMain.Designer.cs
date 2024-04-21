namespace WinFormsApp1
{
    partial class ZodiacMain
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
            lblHeader = new Label();
            lblBirthDay = new Label();
            lblBirthMonth = new Label();
            lblResure = new Label();
            lblCopyRight = new Label();
            txtDay = new TextBox();
            txtMonth = new TextBox();
            btnCheck = new Button();
            binQuit = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Loma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Lime;
            lblHeader.Location = new Point(37, 43);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(339, 95);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "You Zodiac";
            lblHeader.Click += label1_Click;
            // 
            // lblBirthDay
            // 
            lblBirthDay.AutoSize = true;
            lblBirthDay.Font = new Font("Loma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthDay.ForeColor = Color.Lime;
            lblBirthDay.Location = new Point(60, 149);
            lblBirthDay.Margin = new Padding(4, 0, 4, 0);
            lblBirthDay.Name = "lblBirthDay";
            lblBirthDay.Size = new Size(127, 27);
            lblBirthDay.TabIndex = 1;
            lblBirthDay.Text = "Your Birth Day:";
            lblBirthDay.Click += label1_Click_1;
            // 
            // lblBirthMonth
            // 
            lblBirthMonth.AutoSize = true;
            lblBirthMonth.Font = new Font("Loma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthMonth.ForeColor = Color.Lime;
            lblBirthMonth.Location = new Point(38, 236);
            lblBirthMonth.Margin = new Padding(4, 0, 4, 0);
            lblBirthMonth.Name = "lblBirthMonth";
            lblBirthMonth.Size = new Size(143, 27);
            lblBirthMonth.TabIndex = 2;
            lblBirthMonth.Text = "Your Birht Month:";
            // 
            // lblResure
            // 
            lblResure.AutoSize = true;
            lblResure.Font = new Font("Loma", 15F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblResure.ForeColor = Color.Lime;
            lblResure.Location = new Point(60, 409);
            lblResure.Margin = new Padding(4, 0, 4, 0);
            lblResure.Name = "lblResure";
            lblResure.Size = new Size(342, 40);
            lblResure.TabIndex = 3;
            lblResure.Text = "Cung Hoang dao cua ban la:";
            lblResure.Click += lblResure_Click;
            // 
            // lblCopyRight
            // 
            lblCopyRight.AutoSize = true;
            lblCopyRight.Font = new Font("Lucida Calligraphy", 7.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblCopyRight.ForeColor = Color.Lime;
            lblCopyRight.Location = new Point(16, 753);
            lblCopyRight.Margin = new Padding(4, 0, 4, 0);
            lblCopyRight.Name = "lblCopyRight";
            lblCopyRight.Size = new Size(162, 17);
            lblCopyRight.TabIndex = 4;
            lblCopyRight.Text = "© 2024 NhatTruong";
            lblCopyRight.Click += label4_Click;
            // 
            // txtDay
            // 
            txtDay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDay.Location = new Point(214, 152);
            txtDay.Margin = new Padding(4);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(301, 30);
            txtDay.TabIndex = 5;
            // 
            // txtMonth
            // 
            txtMonth.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMonth.Location = new Point(214, 235);
            txtMonth.Margin = new Padding(4);
            txtMonth.Name = "txtMonth";
            txtMonth.Size = new Size(301, 30);
            txtMonth.TabIndex = 6;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(128, 255, 128);
            btnCheck.Location = new Point(60, 328);
            btnCheck.Margin = new Padding(4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(144, 45);
            btnCheck.TabIndex = 7;
            btnCheck.Text = "Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // binQuit
            // 
            binQuit.BackColor = Color.FromArgb(128, 255, 128);
            binQuit.Location = new Point(371, 328);
            binQuit.Margin = new Padding(4);
            binQuit.Name = "binQuit";
            binQuit.Size = new Size(144, 45);
            binQuit.TabIndex = 8;
            binQuit.Text = "Quit";
            binQuit.UseVisualStyleBackColor = false;
            binQuit.Click += binQuit_Click;
            // 
            // ZodiacMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1015, 548);
            Controls.Add(binQuit);
            Controls.Add(btnCheck);
            Controls.Add(txtMonth);
            Controls.Add(txtDay);
            Controls.Add(lblCopyRight);
            Controls.Add(lblResure);
            Controls.Add(lblBirthMonth);
            Controls.Add(lblBirthDay);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZodiacMain";
            Text = "Zodiac";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblBirthDay;
        private Label lblBirthMonth;
        private Label lblResure;
        private Label lblCopyRight;
        private TextBox txtDay;
        private TextBox txtMonth;
        private Button btnCheck;
        private Button binQuit;
    }
}
