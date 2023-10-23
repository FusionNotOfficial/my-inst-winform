namespace MyInstagram
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            roundPictureBox1 = new MyInstagram.RoundPictureBox();
            roundPictureBox2 = new MyInstagram.RoundPictureBox();
            roundPictureBox3 = new MyInstagram.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.Image = (Image)resources.GetObject("roundPictureBox1.Image");
            roundPictureBox1.Location = new Point(369, 86);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(100, 96);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 0;
            roundPictureBox1.TabStop = false;
            // 
            // roundPictureBox2
            // 
            roundPictureBox2.Location = new Point(511, 258);
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.Size = new Size(100, 93);
            roundPictureBox2.TabIndex = 1;
            roundPictureBox2.TabStop = false;
            // 
            // roundPictureBox3
            // 
            roundPictureBox3.Image = (Image)resources.GetObject("roundPictureBox3.Image");
            roundPictureBox3.Location = new Point(568, 99);
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.Size = new Size(100, 81);
            roundPictureBox3.TabIndex = 2;
            roundPictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(roundPictureBox3);
            Controls.Add(roundPictureBox2);
            Controls.Add(roundPictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.CodeDom.CodeTypeReference roundPictureBox1;
        private System.CodeDom.CodeTypeReference roundPictureBox2;
        private System.CodeDom.CodeTypeReference roundPictureBox3;
    }
}