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
            tbxNameBook = new TextBox();
            txtBookName = new Label();
            txtCategory = new Label();
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
            btnSave.Location = new Point(692, 178);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSearch_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(692, 266);
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
            cboBookCategory.Location = new Point(398, 266);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(258, 28);
            cboBookCategory.TabIndex = 5;
            // 
            // tbxNameBook
            // 
            tbxNameBook.Location = new Point(398, 178);
            tbxNameBook.Name = "tbxNameBook";
            tbxNameBook.Size = new Size(258, 27);
            tbxNameBook.TabIndex = 6;
            // 
            // txtBookName
            // 
            txtBookName.AutoSize = true;
            txtBookName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBookName.Location = new Point(292, 182);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(100, 23);
            txtBookName.TabIndex = 7;
            txtBookName.Text = "Book Name";
            // 
            // txtCategory
            // 
            txtCategory.AutoSize = true;
            txtCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCategory.Location = new Point(272, 271);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(120, 23);
            txtCategory.TabIndex = 8;
            txtCategory.Text = "CategoryBook";
            // 
            // DetailBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1074, 514);
            Controls.Add(txtCategory);
            Controls.Add(txtBookName);
            Controls.Add(tbxNameBook);
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
        private TextBox tbxNameBook;
        private Label txtBookName;
        private Label txtCategory;
    }
}