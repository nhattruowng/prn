namespace BookManagement_LENHATTRUONG
{
    partial class Save
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
            lblName = new Label();
            cboBookCategory = new ComboBox();
            btnSave = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            lblName.ImeMode = ImeMode.NoControl;
            lblName.Location = new Point(334, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(157, 38);
            lblName.TabIndex = 1;
            lblName.Text = "BookDetail";
            // 
            // cboBookCategory
            // 
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(57, 255);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(446, 28);
            cboBookCategory.TabIndex = 2;
            cboBookCategory.SelectedIndexChanged += cboBookCategory_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSave.ImeMode = ImeMode.NoControl;
            btnSave.Location = new Point(577, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(194, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Creat Book";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnQuit.ImeMode = ImeMode.NoControl;
            btnQuit.Location = new Point(577, 303);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(194, 29);
            btnQuit.TabIndex = 4;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 658);
            Controls.Add(btnQuit);
            Controls.Add(btnSave);
            Controls.Add(cboBookCategory);
            Controls.Add(lblName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Save";
            Text = "Save";
            Load += BookDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private ComboBox cboBookCategory;
        private Button btnSave;
        private Button btnQuit;
    }
}