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
        /// <param FollowControl="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            usernameLabel.Location = new Point(13, 9);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(149, 37);
            usernameLabel.TabIndex = 11;
            usernameLabel.Text = "username";
            // 
            // Direct
            // 
            Direct.Image = (Image)resources.GetObject("Direct.Image");
            Direct.Location = new Point(359, 13);
            Direct.Margin = new Padding(4, 5, 4, 5);
            Direct.Name = "Direct";
            Direct.Size = new Size(39, 40);
            Direct.SizeMode = PictureBoxSizeMode.StretchImage;
            Direct.TabIndex = 12;
            Direct.TabStop = false;
            Direct.Click += Direct_Click;
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Location = new Point(-3, 67);
            labelLine1.Margin = new Padding(4, 0, 4, 0);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(414, 2);
            labelLine1.TabIndex = 13;
            labelLine1.Text = "labelLine1";
            // 
            // FeedPanel
            // 
            FeedPanel.AccessibleRole = AccessibleRole.None;
            FeedPanel.AutoScroll = true;
            FeedPanel.Location = new Point(-3, 67);
            FeedPanel.Margin = new Padding(0);
            FeedPanel.Name = "FeedPanel";
            FeedPanel.Size = new Size(434, 585);
            FeedPanel.TabIndex = 14;
            // 
            // Feed
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(406, 653);
            Controls.Add(FeedPanel);
            Controls.Add(labelLine1);
            Controls.Add(Direct);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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
        public FlowLayoutPanel FeedPanel;
    }
}