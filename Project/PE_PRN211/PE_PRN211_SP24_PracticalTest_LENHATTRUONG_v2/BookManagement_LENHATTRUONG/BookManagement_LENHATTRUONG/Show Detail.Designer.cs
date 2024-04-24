namespace BookManagement_LENHATTRUONG
{
    partial class Show_Detail
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
            dgvBookList = new DataGridView();
            grgBox = new GroupBox();
            btnSearch = new Button();
            txtBookName = new TextBox();
            lblSearch = new Label();
            btnCreat = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grgBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblHearder
            // 
            lblHearder.AutoSize = true;
            lblHearder.Font = new Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHearder.ForeColor = Color.FromArgb(255, 128, 128);
            lblHearder.Location = new Point(380, 27);
            lblHearder.Name = "lblHearder";
            lblHearder.Size = new Size(270, 52);
            lblHearder.TabIndex = 0;
            lblHearder.Text = "Manager Book";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(37, 178);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.Size = new Size(817, 308);
            dgvBookList.TabIndex = 1;
            // 
            // grgBox
            // 
            grgBox.Controls.Add(btnSearch);
            grgBox.Controls.Add(txtBookName);
            grgBox.Controls.Add(lblSearch);
            grgBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grgBox.Location = new Point(37, 81);
            grgBox.Name = "grgBox";
            grgBox.Size = new Size(817, 91);
            grgBox.TabIndex = 2;
            grgBox.TabStop = false;
            grgBox.Text = " Search Book ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(660, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(117, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(173, 35);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(440, 30);
            txtBookName.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(43, 38);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(112, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Name";
            // 
            // btnCreat
            // 
            btnCreat.Location = new Point(920, 108);
            btnCreat.Name = "btnCreat";
            btnCreat.Size = new Size(117, 29);
            btnCreat.TabIndex = 3;
            btnCreat.Text = "Create";
            btnCreat.UseVisualStyleBackColor = true;
            btnCreat.Click += btnCreat_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(920, 201);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(920, 292);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(920, 377);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(117, 29);
            btnQuit.TabIndex = 6;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(920, 457);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Show_Detail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1074, 514);
            Controls.Add(btnLogout);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreat);
            Controls.Add(grgBox);
            Controls.Add(dgvBookList);
            Controls.Add(lblHearder);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Show_Detail";
            Text = "Show_Detail";
            Load += Show_Detail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grgBox.ResumeLayout(false);
            grgBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHearder;
        private DataGridView dgvBookList;
        private GroupBox grgBox;
        private Button btnSearch;
        private TextBox txtBookName;
        private Label lblSearch;
        private Button btnCreat;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQuit;
        private Button btnLogout;
    }
}