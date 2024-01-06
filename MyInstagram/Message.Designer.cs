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
        /// <param FollowControl="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            date.BackColor = Color.RoyalBlue;
            date.FlatStyle = FlatStyle.System;
            date.Font = new Font("Segoe UI Variable Display", 8F, FontStyle.Regular, GraphicsUnit.Point);
            date.ForeColor = SystemColors.AppWorkspace;
            date.Location = new Point(211, 18);
            date.Margin = new Padding(0);
            date.Name = "date";
            date.Size = new Size(38, 21);
            date.TabIndex = 1;
            date.Text = "20:33";
            // 
            // roundControl1
            // 
            roundControl1.BackColor = Color.RoyalBlue;
            roundControl1.ForeColor = SystemColors.ControlLightLight;
            roundControl1.Location = new Point(0, 0);
            roundControl1.Margin = new Padding(4, 5, 4, 5);
            roundControl1.Name = "roundControl1";
            roundControl1.Size = new Size(286, 45);
            roundControl1.TabIndex = 0;
            // 
            // content
            // 
            content.AutoSize = true;
            content.BackColor = Color.RoyalBlue;
            content.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            content.ForeColor = SystemColors.ButtonHighlight;
            content.Location = new Point(4, 10);
            content.Margin = new Padding(4, 0, 4, 0);
            content.MaximumSize = new Size(900, 250);
            content.Name = "content";
            content.Size = new Size(441, 23);
            content.TabIndex = 2;
            content.Text = "messageiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii";
            // 
            // viewed
            // 
            viewed.BackColor = Color.RoyalBlue;
            viewed.Image = (Image)resources.GetObject("viewed.Image");
            viewed.Location = new Point(253, 20);
            viewed.Margin = new Padding(4, 5, 4, 5);
            viewed.Name = "viewed";
            viewed.Size = new Size(21, 21);
            viewed.SizeMode = PictureBoxSizeMode.StretchImage;
            viewed.TabIndex = 3;
            viewed.TabStop = false;
            viewed.Visible = false;
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(viewed);
            Controls.Add(date);
            Controls.Add(content);
            Controls.Add(roundControl1);
            Margin = new Padding(4, 1, 4, 1);
            Name = "Message";
            Size = new Size(290, 45);
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
