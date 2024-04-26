namespace Watches_TruongLeNhat
{
    partial class Watch_Managerment
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
            dtaWatch = new DataGridView();
            label1 = new Label();
            btnCreat = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnQuit = new Button();
            btnSearch = new Button();
            label2 = new Label();
            label3 = new Label();
            txtSearchName = new TextBox();
            txtSearchDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtaWatch).BeginInit();
            SuspendLayout();
            // 
            // dtaWatch
            // 
            dtaWatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtaWatch.Location = new Point(32, 171);
            dtaWatch.Name = "dtaWatch";
            dtaWatch.RowHeadersWidth = 51;
            dtaWatch.Size = new Size(833, 350);
            dtaWatch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 31);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 1;
            label1.Text = "Watch Managerment";
            // 
            // btnCreat
            // 
            btnCreat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreat.Location = new Point(919, 170);
            btnCreat.Name = "btnCreat";
            btnCreat.Size = new Size(127, 29);
            btnCreat.TabIndex = 2;
            btnCreat.Text = "Create Watch";
            btnCreat.UseVisualStyleBackColor = true;
            btnCreat.Click += btnCreat_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(919, 249);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(919, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(919, 480);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(127, 29);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(765, 89);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 98);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 7;
            label2.Text = "WatchName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 100);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 8;
            label3.Text = "Description";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(131, 93);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(248, 27);
            txtSearchName.TabIndex = 9;
            // 
            // txtSearchDescription
            // 
            txtSearchDescription.Location = new Point(476, 91);
            txtSearchDescription.Name = "txtSearchDescription";
            txtSearchDescription.Size = new Size(248, 27);
            txtSearchDescription.TabIndex = 10;
            // 
            // Watch_Managerment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 551);
            Controls.Add(txtSearchDescription);
            Controls.Add(txtSearchName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSearch);
            Controls.Add(btnQuit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreat);
            Controls.Add(label1);
            Controls.Add(dtaWatch);
            Name = "Watch_Managerment";
            Text = "Watch_Managerment";
            Load += Watch_Managerment_Load;
            ((System.ComponentModel.ISupportInitialize)dtaWatch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtaWatch;
        private Label label1;
        private Button btnCreat;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnQuit;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private TextBox txtSearchName;
        private TextBox txtSearchDescription;
    }
}