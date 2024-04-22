namespace BookManagement_LENHATTRUONG
{
    partial class DetailBook
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
            lblHearder = new Label();
            btnSave = new Button();
            btnQuit = new Button();
            cboBookCategory = new ComboBox();
            SuspendLayout();
            // 
            // lblHearder
            // 
            lblHearder.AutoSize = true;
            lblHearder.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHearder.ForeColor = Color.FromArgb(255, 128, 128);
            lblHearder.Location = new Point(383, 28);
            lblHearder.Name = "lblHearder";
            lblHearder.Size = new Size(192, 52);
            lblHearder.TabIndex = 1;
            lblHearder.Text = "Add Book";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(458, 136);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSearch_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(458, 224);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(117, 29);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // cboBookCategory
            // 
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(53, 137);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(365, 28);
            cboBookCategory.TabIndex = 5;
            // 
            // DetailBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1074, 514);
            Controls.Add(cboBookCategory);
            Controls.Add(btnQuit);
            Controls.Add(btnSave);
            Controls.Add(lblHearder);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailBook";
            Text = "DetailBook";
            Load += DetailBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHearder;
        private Button btnSave;
        private Button btnQuit;
        private ComboBox cboBookCategory;
    }
}