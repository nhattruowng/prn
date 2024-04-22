namespace BookManagement_LENHATTRUONG
{
    partial class ManagerBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerBook));
            lblName = new Label();
            dgvBookList = new DataGridView();
            btnCreatBook = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            grbSeachBoock = new GroupBox();
            btnSearch = new Button();
            txtBookName = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            grbSeachBoock.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.Name = "lblName";
            // 
            // dgvBookList
            // 
            resources.ApplyResources(dgvBookList, "dgvBookList");
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Name = "dgvBookList";
            // 
            // btnCreatBook
            // 
            resources.ApplyResources(btnCreatBook, "btnCreatBook");
            btnCreatBook.Name = "btnCreatBook";
            btnCreatBook.UseVisualStyleBackColor = true;
            btnCreatBook.Click += btnCreatBook_Click;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(btnUpdate, "btnUpdate");
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            resources.ApplyResources(btnQuit, "btnQuit");
            btnQuit.Name = "btnQuit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // grbSeachBoock
            // 
            resources.ApplyResources(grbSeachBoock, "grbSeachBoock");
            grbSeachBoock.Controls.Add(btnSearch);
            grbSeachBoock.Controls.Add(txtBookName);
            grbSeachBoock.Controls.Add(lblSearch);
            grbSeachBoock.Name = "grbSeachBoock";
            grbSeachBoock.TabStop = false;
            // 
            // btnSearch
            // 
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.Name = "btnSearch";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtBookName
            // 
            resources.ApplyResources(txtBookName, "txtBookName");
            txtBookName.Name = "txtBookName";
            // 
            // lblSearch
            // 
            resources.ApplyResources(lblSearch, "lblSearch");
            lblSearch.Name = "lblSearch";
            // 
            // ManagerBook
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grbSeachBoock);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreatBook);
            Controls.Add(dgvBookList);
            Controls.Add(lblName);
            MaximizeBox = false;
            Name = "ManagerBook";
            Load += ManagerBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            grbSeachBoock.ResumeLayout(false);
            grbSeachBoock.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private DataGridView dgvBookList;
        private Button btnCreatBook;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQuit;
        private GroupBox grbSeachBoock;
        private Button btnSearch;
        private TextBox txtBookName;
        private Label lblSearch;
    }
}
