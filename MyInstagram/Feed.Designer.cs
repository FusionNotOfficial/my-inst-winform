namespace MyInstagram
{
    partial class Feed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feed));
            usernameLabel = new Label();
            Direct = new PictureBox();
            labelLine1 = new LabelLine();
            FeedPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)Direct).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.ButtonFace;
            usernameLabel.Location = new Point(17, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(96, 24);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "username";
            // 
            // Direct
            // 
            Direct.Image = (Image)resources.GetObject("Direct.Image");
            Direct.Location = new Point(251, 8);
            Direct.Name = "Direct";
            Direct.Size = new Size(27, 27);
            Direct.SizeMode = PictureBoxSizeMode.StretchImage;
            Direct.TabIndex = 12;
            Direct.TabStop = false;
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Location = new Point(-2, 40);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(290, 1);
            labelLine1.TabIndex = 13;
            labelLine1.Text = "labelLine1";
            // 
            // FeedPanel
            // 
            FeedPanel.AutoScroll = true;
            FeedPanel.Location = new Point(-2, 40);
            FeedPanel.Margin = new Padding(0);
            FeedPanel.Name = "FeedPanel";
            FeedPanel.Size = new Size(304, 351);
            FeedPanel.TabIndex = 14;
            // 
            // Feed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 392);
            Controls.Add(FeedPanel);
            Controls.Add(labelLine1);
            Controls.Add(Direct);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Feed";
            Text = "Feed";
            ((System.ComponentModel.ISupportInitialize)Direct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private PictureBox Direct;
        private LabelLine labelLine1;
        private FlowLayoutPanel FeedPanel;
    }
}