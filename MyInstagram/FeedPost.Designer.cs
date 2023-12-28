namespace MyInstagram
{
    partial class FeedPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedPost));
            userPicture = new RoundPictureBox();
            usernameLabel = new Label();
            followButton = new ULControls.ULButton();
            postPicture = new PictureBox();
            likeButton = new PictureBox();
            pictureBox2 = new PictureBox();
            likesLabel = new Label();
            usernameDescription = new Label();
            descriptionLabel = new Label();
            postDate = new Label();
            ((System.ComponentModel.ISupportInitialize)userPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)postPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)likeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // userPicture
            // 
            userPicture.Image = (Image)resources.GetObject("userPicture.Image");
            userPicture.Location = new Point(9, 5);
            userPicture.Margin = new Padding(4, 5, 4, 5);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(50, 50);
            userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicture.TabIndex = 0;
            userPicture.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.ButtonFace;
            usernameLabel.Location = new Point(69, 18);
            usernameLabel.Margin = new Padding(4, 0, 4, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(106, 26);
            usernameLabel.TabIndex = 12;
            usernameLabel.Text = "username";
            // 
            // followButton
            // 
            followButton.BackColor = Color.FromArgb(64, 64, 64);
            followButton.BackgroundColor = Color.FromArgb(64, 64, 64);
            followButton.BorderColor = Color.PaleVioletRed;
            followButton.BorderRadius = 12;
            followButton.BorderSize = 0;
            followButton.FlatAppearance.BorderSize = 0;
            followButton.FlatStyle = FlatStyle.Flat;
            followButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            followButton.ForeColor = Color.White;
            followButton.Location = new Point(278, 18);
            followButton.Margin = new Padding(4, 5, 4, 5);
            followButton.Name = "followButton";
            followButton.Size = new Size(120, 35);
            followButton.TabIndex = 15;
            followButton.Text = "Follow";
            followButton.TextColor = Color.White;
            followButton.UseVisualStyleBackColor = false;
            followButton.Click += followButton_Click;
            // 
            // postPicture
            // 
            postPicture.Location = new Point(0, 60);
            postPicture.Margin = new Padding(0);
            postPicture.Name = "postPicture";
            postPicture.Size = new Size(414, 408);
            postPicture.SizeMode = PictureBoxSizeMode.Zoom;
            postPicture.TabIndex = 16;
            postPicture.TabStop = false;
            // 
            // likeButton
            // 
            likeButton.Image = (Image)resources.GetObject("likeButton.Image");
            likeButton.Location = new Point(9, 473);
            likeButton.Margin = new Padding(4, 5, 4, 5);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(34, 34);
            likeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            likeButton.TabIndex = 17;
            likeButton.TabStop = false;
            likeButton.Click += likeButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(82, 473);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // likesLabel
            // 
            likesLabel.AutoSize = true;
            likesLabel.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            likesLabel.ForeColor = SystemColors.ButtonFace;
            likesLabel.Location = new Point(52, 480);
            likesLabel.Margin = new Padding(4, 0, 4, 0);
            likesLabel.Name = "likesLabel";
            likesLabel.Size = new Size(21, 23);
            likesLabel.TabIndex = 12;
            likesLabel.Text = "9";
            // 
            // usernameDescription
            // 
            usernameDescription.AutoSize = true;
            usernameDescription.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameDescription.ForeColor = SystemColors.ButtonFace;
            usernameDescription.Location = new Point(5, 511);
            usernameDescription.Margin = new Padding(4, 0, 4, 0);
            usernameDescription.Name = "usernameDescription";
            usernameDescription.Size = new Size(106, 26);
            usernameDescription.TabIndex = 12;
            usernameDescription.Text = "username";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.ForeColor = SystemColors.ButtonFace;
            descriptionLabel.Location = new Point(98, 511);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(166, 26);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "some description";
            // 
            // postDate
            // 
            postDate.AutoSize = true;
            postDate.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            postDate.ForeColor = SystemColors.ControlDarkDark;
            postDate.Location = new Point(264, 473);
            postDate.Margin = new Padding(4, 0, 4, 0);
            postDate.Name = "postDate";
            postDate.Size = new Size(114, 23);
            postDate.TabIndex = 12;
            postDate.Text = "November 12";
            // 
            // FeedPost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(pictureBox2);
            Controls.Add(likeButton);
            Controls.Add(postPicture);
            Controls.Add(followButton);
            Controls.Add(postDate);
            Controls.Add(likesLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(usernameDescription);
            Controls.Add(usernameLabel);
            Controls.Add(userPicture);
            Margin = new Padding(0);
            Name = "FeedPost";
            Size = new Size(406, 589);
            ((System.ComponentModel.ISupportInitialize)userPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)postPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)likeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundPictureBox userPicture;
        private Label usernameLabel;
        private ULControls.ULButton followButton;
        private PictureBox postPicture;
        private PictureBox likeButton;
        private PictureBox pictureBox2;
        private Label likesLabel;
        private Label usernameDescription;
        private Label descriptionLabel;
        private Label postDate;
    }
}
