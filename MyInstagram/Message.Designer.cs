namespace MyInstagram
{
    partial class Message
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            date = new Label();
            roundControl1 = new RoundControl();
            content = new Label();
            viewed = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)viewed).BeginInit();
            SuspendLayout();
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.RoyalBlue;
            date.FlatStyle = FlatStyle.System;
            date.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            date.ForeColor = SystemColors.AppWorkspace;
            date.Location = new Point(150, 18);
            date.Name = "date";
            date.Size = new Size(34, 13);
            date.TabIndex = 1;
            date.Text = "20:33";
            // 
            // roundControl1
            // 
            roundControl1.BackColor = Color.RoyalBlue;
            roundControl1.ForeColor = SystemColors.ControlLightLight;
            roundControl1.Location = new Point(0, 3);
            roundControl1.Name = "roundControl1";
            roundControl1.Size = new Size(200, 32);
            roundControl1.TabIndex = 0;
            // 
            // content
            // 
            content.AutoSize = true;
            content.BackColor = Color.RoyalBlue;
            content.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            content.ForeColor = SystemColors.ButtonHighlight;
            content.Location = new Point(4, 9);
            content.MaximumSize = new Size(180, 150);
            content.Name = "content";
            content.Size = new Size(59, 18);
            content.TabIndex = 2;
            content.Text = "message";
            // 
            // viewed
            // 
            viewed.BackColor = Color.RoyalBlue;
            viewed.Image = (Image)resources.GetObject("viewed.Image");
            viewed.Location = new Point(180, 16);
            viewed.Name = "viewed";
            viewed.Size = new Size(15, 15);
            viewed.SizeMode = PictureBoxSizeMode.StretchImage;
            viewed.TabIndex = 3;
            viewed.TabStop = false;
            viewed.Visible = false;
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(viewed);
            Controls.Add(date);
            Controls.Add(content);
            Controls.Add(roundControl1);
            Name = "Message";
            Size = new Size(203, 38);
            ((System.ComponentModel.ISupportInitialize)viewed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public RoundControl roundControl1;
        public Label date;
        public Label content;
        public PictureBox viewed;
    }
}
