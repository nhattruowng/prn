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
            datePub = new DateTimePicker();
            txtAuthor = new TextBox();
            txtDescription = new RichTextBox();
            lblAuthor = new Label();
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
            lblHearder.Size = new Size(192, 52);
            lblHearder.TabIndex = 1;
            lblHearder.Text = "Add Book";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(814, 266);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSearch_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(570, 266);
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
            cboBookCategory.Location = new Point(153, 116);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(258, 28);
            cboBookCategory.TabIndex = 5;
            // 
            // txtNameBook
            // 
            txtNameBook.Location = new Point(153, 49);
            txtNameBook.Name = "txtNameBook";
            txtNameBook.Size = new Size(258, 27);
            txtNameBook.TabIndex = 6;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookName.Location = new Point(27, 53);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(100, 23);
            lblBookName.TabIndex = 7;
            lblBookName.Text = "Book Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(27, 121);
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
            lblPublictionDate.Location = new Point(527, 118);
            lblPublictionDate.Name = "lblPublictionDate";
            lblPublictionDate.Size = new Size(131, 23);
            lblPublictionDate.TabIndex = 10;
            lblPublictionDate.Text = "PublicationDate";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(530, 184);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(77, 23);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(717, 184);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 23);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "Price";
            // 
            // grDetail
            // 
            grDetail.Controls.Add(txtPrice);
            grDetail.Controls.Add(numQuantity);
            grDetail.Controls.Add(btnQuit);
            grDetail.Controls.Add(datePub);
            grDetail.Controls.Add(btnSave);
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
            grDetail.TabIndex = 13;
            grDetail.TabStop = false;
            grDetail.Text = " Add Book";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(770, 179);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(161, 27);
            txtPrice.TabIndex = 19;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(622, 180);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(65, 27);
            numQuantity.TabIndex = 18;
            // 
            // datePub
            // 
            datePub.Location = new Point(681, 114);
            datePub.Name = "datePub";
            datePub.Size = new Size(250, 27);
            datePub.TabIndex = 17;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(673, 45);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(258, 27);
            txtAuthor.TabIndex = 16;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(27, 198);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(457, 140);
            txtDescription.TabIndex = 15;
            txtDescription.Text = "";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(527, 49);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(63, 23);
            lblAuthor.TabIndex = 13;
            lblAuthor.Text = "Author";
            // 
            // DetailBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1074, 514);
            Controls.Add(grDetail);
            Controls.Add(lblHearder);
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
        private DateTimePicker datePub;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private NumericUpDown numQuantity;
    }
}