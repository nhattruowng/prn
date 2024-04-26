namespace Watches_TruongLeNhat
{
    partial class ShowDetail
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtname = new TextBox();
            txtPrice = new TextBox();
            cbbrand = new ComboBox();
            txtDis = new TextBox();
            btnSave = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblHearder
            // 
            lblHearder.AutoSize = true;
            lblHearder.Location = new Point(37, 41);
            lblHearder.Name = "lblHearder";
            lblHearder.Size = new Size(16, 20);
            lblHearder.TabIndex = 1;
            lblHearder.Text = "?";
            lblHearder.Click += lblHearder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 126);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 2;
            label1.Text = "Watch name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(458, 126);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 179);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 193);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 6;
            label5.Text = "Discription";
            // 
            // txtname
            // 
            txtname.Location = new Point(147, 126);
            txtname.Name = "txtname";
            txtname.Size = new Size(228, 27);
            txtname.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(527, 123);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(228, 27);
            txtPrice.TabIndex = 9;
            // 
            // cbbrand
            // 
            cbbrand.FormattingEnabled = true;
            cbbrand.Location = new Point(527, 171);
            cbbrand.Name = "cbbrand";
            cbbrand.Size = new Size(228, 28);
            cbbrand.TabIndex = 10;
            // 
            // txtDis
            // 
            txtDis.Location = new Point(44, 225);
            txtDis.Multiline = true;
            txtDis.Name = "txtDis";
            txtDis.Size = new Size(331, 133);
            txtDis.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(661, 405);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(817, 405);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 13;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // ShowDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 469);
            Controls.Add(btnQuit);
            Controls.Add(btnSave);
            Controls.Add(txtDis);
            Controls.Add(cbbrand);
            Controls.Add(txtPrice);
            Controls.Add(txtname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblHearder);
            Name = "ShowDetail";
            Text = "ShowDetail";
            Load += ShowDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHearder;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtname;
        private TextBox txtPrice;
        private ComboBox cbbrand;
        private TextBox txtDis;
        private Button btnSave;
        private Button btnQuit;
    }
}