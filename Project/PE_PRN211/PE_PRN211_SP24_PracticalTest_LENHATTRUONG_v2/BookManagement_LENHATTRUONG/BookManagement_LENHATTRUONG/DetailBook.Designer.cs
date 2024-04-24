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
            txtNameBook = new TextBox();
            lblBookName = new Label();
            lblCategory = new Label();
            lblDescription = new Label();
            lblPublictionDate = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            grDetail = new GroupBox();
            txtPrice = new TextBox();
            numQuantity = new NumericUpDown();
            dtpPub = new DateTimePicker();
            txtAuthor = new TextBox();
            txtDescription = new RichTextBox();
            lblAuthor = new Label();
            txtId = new TextBox();
            label1 = new Label();
            grDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblHearder
            // 
            lblHearder.AutoSize = true;
            lblHearder.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHearder.ForeColor = Color.FromArgb(255, 128, 128);
            lblHearder.Location = new Point(417, 9);
            lblHearder.Name = "lblHearder";
            lblHearder.Size = new Size(44, 52);
            lblHearder.TabIndex = 2;
            lblHearder.Text = "?";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(891, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSearch_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(647, 473);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(117, 29);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // cboBookCategory
            // 
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(691, 49);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(258, 28);
            cboBookCategory.TabIndex = 3;
            // 
            // txtNameBook
            // 
            txtNameBook.Location = new Point(145, 111);
            txtNameBook.Name = "txtNameBook";
            txtNameBook.Size = new Size(258, 27);
            txtNameBook.TabIndex = 1;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(27, 115);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(100, 23);
            lblBookName.TabIndex = 2;
            lblBookName.Text = "Book Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(565, 54);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(120, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "CategoryBook";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(27, 172);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description";
            // 
            // lblPublictionDate
            // 
            lblPublictionDate.AutoSize = true;
            lblPublictionDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublictionDate.Location = new Point(677, 188);
            lblPublictionDate.Name = "lblPublictionDate";
            lblPublictionDate.Size = new Size(131, 23);
            lblPublictionDate.TabIndex = 10;
            lblPublictionDate.Text = "PublicationDate";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(783, 248);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 23);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(735, 316);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 23);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Price";
            // 
            // grDetail
            // 
            grDetail.Controls.Add(txtId);
            grDetail.Controls.Add(label1);
            grDetail.Controls.Add(txtPrice);
            grDetail.Controls.Add(numQuantity);
            grDetail.Controls.Add(dtpPub);
            grDetail.Controls.Add(txtAuthor);
            grDetail.Controls.Add(txtDescription);
            grDetail.Controls.Add(lblAuthor);
            grDetail.Controls.Add(lblQuantity);
            grDetail.Controls.Add(lblPrice);
            grDetail.Controls.Add(cboBookCategory);
            grDetail.Controls.Add(txtNameBook);
            grDetail.Controls.Add(lblPublictionDate);
            grDetail.Controls.Add(lblBookName);
            grDetail.Controls.Add(lblDescription);
            grDetail.Controls.Add(lblCategory);
            grDetail.Location = new Point(32, 83);
            grDetail.Name = "grDetail";
            grDetail.Size = new Size(976, 362);
            grDetail.TabIndex = 0;
            grDetail.TabStop = false;
            grDetail.Text = "?";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(788, 311);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(161, 27);
            txtPrice.TabIndex = 7;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(875, 244);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(74, 27);
            numQuantity.TabIndex = 6;
            // 
            // dtpPub
            // 
            dtpPub.Format = DateTimePickerFormat.Short;
            dtpPub.Location = new Point(831, 184);
            dtpPub.Name = "dtpPub";
            dtpPub.Size = new Size(118, 27);
            dtpPub.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(682, 111);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(267, 27);
            txtAuthor.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(27, 198);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(645, 140);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(536, 115);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(63, 23);
            lblAuthor.TabIndex = 13;
            lblAuthor.Text = "Author";
            // 
            // txtId
            // 
            txtId.Location = new Point(145, 49);
            txtId.Name = "txtId";
            txtId.Size = new Size(258, 27);
            txtId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 53);
            label1.Name = "label1";
            label1.Size = new Size(71, 23);
            label1.TabIndex = 15;
            label1.Text = "Book ID";
            // 
            // DetailBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1074, 514);
            Controls.Add(grDetail);
            Controls.Add(lblHearder);
            Controls.Add(btnQuit);
            Controls.Add(btnSave);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetailBook";
            Text = "DetailBook";
            Load += DetailBook_Load;
            grDetail.ResumeLayout(false);
            grDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHearder;
        private Button btnSave;
        private Button btnQuit;
        private ComboBox cboBookCategory;
        private TextBox txtNameBook;
        private Label lblBookName;
        private Label lblCategory;
        private Label lblDescription;
        private Label lblPublictionDate;
        private Label lblQuantity;
        private Label lblPrice;
        private GroupBox grDetail;
        private Label lblAuthor;
        private RichTextBox txtDescription;
        private DateTimePicker dtpPub;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private NumericUpDown numQuantity;
        private TextBox txtId;
        private Label label1;
    }
}