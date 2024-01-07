namespace MyInstagram
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            PostsPanel = new FlowLayoutPanel();
            DescriptionLabel = new Label();
            MessageButton = new ULControls.ULButton();
            followButton = new ULControls.ULButton();
            panel3 = new Panel();
            label = new Label();
            Following = new Label();
            panel2 = new Panel();
            label4 = new Label();
            Followers = new Label();
            userImage = new RoundPictureBox();
            usernameLabel = new Label();
            panel1 = new Panel();
            backButton = new PictureBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            SuspendLayout();
            // 
            // PostsPanel
            // 
            PostsPanel.Location = new Point(8, 267);
            PostsPanel.Margin = new Padding(0);
            PostsPanel.Name = "PostsPanel";
            PostsPanel.Size = new Size(390, 381);
            PostsPanel.TabIndex = 26;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = SystemColors.ButtonFace;
            DescriptionLabel.Location = new Point(25, 176);
            DescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(113, 26);
            DescriptionLabel.TabIndex = 25;
            DescriptionLabel.Text = "description";
            // 
            // MessageButton
            // 
            MessageButton.BackColor = Color.FromArgb(64, 64, 64);
            MessageButton.BackgroundColor = Color.FromArgb(64, 64, 64);
            MessageButton.BorderColor = Color.PaleVioletRed;
            MessageButton.BorderRadius = 12;
            MessageButton.BorderSize = 0;
            MessageButton.FlatAppearance.BorderSize = 0;
            MessageButton.FlatStyle = FlatStyle.Flat;
            MessageButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MessageButton.ForeColor = Color.White;
            MessageButton.Location = new Point(206, 216);
            MessageButton.Margin = new Padding(4, 5, 4, 5);
            MessageButton.Name = "MessageButton";
            MessageButton.Size = new Size(179, 35);
            MessageButton.TabIndex = 23;
            MessageButton.Text = "Message";
            MessageButton.TextColor = Color.White;
            MessageButton.UseVisualStyleBackColor = false;
            MessageButton.Click += MessageButton_Click;
            // 
            // followButton
            // 
            followButton.BackColor = SystemColors.Highlight;
            followButton.BackgroundColor = SystemColors.Highlight;
            followButton.BorderColor = Color.PaleVioletRed;
            followButton.BorderRadius = 12;
            followButton.BorderSize = 0;
            followButton.FlatAppearance.BorderSize = 0;
            followButton.FlatStyle = FlatStyle.Flat;
            followButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            followButton.ForeColor = Color.White;
            followButton.Location = new Point(25, 216);
            followButton.Margin = new Padding(4, 5, 4, 5);
            followButton.Name = "followButton";
            followButton.Size = new Size(179, 35);
            followButton.TabIndex = 24;
            followButton.Text = "Follow";
            followButton.TextColor = Color.White;
            followButton.UseVisualStyleBackColor = false;
            followButton.Click += followButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label);
            panel3.Controls.Add(Following);
            panel3.Location = new Point(261, 81);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(96, 60);
            panel3.TabIndex = 22;
            panel3.Click += Following_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ButtonFace;
            label.Location = new Point(4, 30);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(86, 23);
            label.TabIndex = 1;
            label.Text = "Following";
            label.Click += Following_Click;
            // 
            // Following
            // 
            Following.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Following.AutoSize = true;
            Following.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Following.ForeColor = SystemColors.ButtonFace;
            Following.Location = new Point(37, 5);
            Following.Margin = new Padding(4, 0, 4, 0);
            Following.Name = "Following";
            Following.Size = new Size(24, 26);
            Following.TabIndex = 0;
            Following.Text = "0";
            Following.Click += Following_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Followers);
            panel2.Location = new Point(169, 81);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(87, 60);
            panel2.TabIndex = 21;
            panel2.Click += Followers_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(4, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 1;
            label4.Text = "Followers";
            label4.Click += Followers_Click;
            // 
            // Followers
            // 
            Followers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Followers.AutoSize = true;
            Followers.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Followers.ForeColor = SystemColors.ButtonFace;
            Followers.Location = new Point(37, 5);
            Followers.Margin = new Padding(4, 0, 4, 0);
            Followers.Name = "Followers";
            Followers.Size = new Size(24, 26);
            Followers.TabIndex = 0;
            Followers.Text = "0";
            Followers.Click += Followers_Click;
            // 
            // userImage
            // 
            userImage.Image = (Image)resources.GetObject("userImage.Image");
            userImage.Location = new Point(25, 60);
            userImage.Margin = new Padding(4, 5, 4, 5);
            userImage.Name = "userImage";
            userImage.Size = new Size(96, 96);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 20;
            userImage.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.Dock = DockStyle.Fill;
            usernameLabel.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.ButtonFace;
            usernameLabel.Location = new Point(0, 0);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(406, 52);
            usernameLabel.TabIndex = 19;
            usernameLabel.Text = "username";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(usernameLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 52);
            panel1.TabIndex = 27;
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(0, -5);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(53, 55);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 20;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // UserAccount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(406, 653);
            Controls.Add(panel1);
            Controls.Add(PostsPanel);
            Controls.Add(DescriptionLabel);
            Controls.Add(MessageButton);
            Controls.Add(followButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(userImage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAccount";
            Text = "UserAccount";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PostsPanel;
        private Label DescriptionLabel;
        private ULControls.ULButton MessageButton;
        private ULControls.ULButton followButton;
        private Panel panel3;
        private Label label;
        private Label Following;
        private Panel panel2;
        private Label label4;
        private Label Followers;
        private RoundPictureBox userImage;
        private Label usernameLabel;
        private Panel panel1;
        private PictureBox backButton;
    }
}