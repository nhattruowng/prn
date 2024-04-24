namespace ClothesShop
{
    partial class FormAdmin
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
            btnQuit = new Button();
            picAvata = new PictureBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picAvata).BeginInit();
            SuspendLayout();
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(966, 526);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(94, 29);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // picAvata
            // 
            picAvata.BackColor = SystemColors.ActiveCaptionText;
            picAvata.Location = new Point(1009, 7);
            picAvata.Name = "picAvata";
            picAvata.Size = new Size(51, 53);
            picAvata.TabIndex = 0;
            picAvata.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Cyan;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1070, 464);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = " Detail ";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1094, 567);
            Controls.Add(picAvata);
            Controls.Add(btnQuit);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MaximumSize = new Size(1403, 746);
            MinimizeBox = false;
            MinimumSize = new Size(665, 442);
            Name = "FormAdmin";
            Text = "Admin Page";
            ((System.ComponentModel.ISupportInitialize)picAvata).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnQuit;
        private PictureBox picAvata;
        private GroupBox groupBox2;
    }
}