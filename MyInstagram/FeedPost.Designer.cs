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
            userPicture.Location = new Point(6, 3);
            userPicture.Name = "userPicture";
            userPicture.Size = new Size(35, 35);
            userPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            userPicture.TabIndex = 0;
            userPicture.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.ButtonFace;
            usernameLabel.Location = new Point(48, 11);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(68, 18);
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
            followButton.Location = new Point(205, 10);
            followButton.Name = "followButton";
            followButton.Size = new Size(74, 24);
            followButton.TabIndex = 15;
            followButton.Text = "Follow";
            followButton.TextColor = Color.White;
            followButton.UseVisualStyleBackColor = false;
            // 
            // postPicture
            // 
            postPicture.Location = new Point(0, 46);
            postPicture.Margin = new Padding(0);
            postPicture.Name = "postPicture";
            postPicture.Size = new Size(290, 245);
            postPicture.SizeMode = PictureBoxSizeMode.Zoom;
            postPicture.TabIndex = 16;
            postPicture.TabStop = false;
            // 
            // likeButton
            // 
            likeButton.Image = (Image)resources.GetObject("likeButton.Image");
            likeButton.Location = new Point(10, 297);
            likeButton.Name = "likeButton";
            likeButton.Size = new Size(24, 22);
            likeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            likeButton.TabIndex = 17;
            likeButton.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(61, 297);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // likesLabel
            // 
            likesLabel.AutoSize = true;
            likesLabel.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            likesLabel.ForeColor = SystemColors.ButtonFace;
            likesLabel.Location = new Point(40, 301);
            likesLabel.Name = "likesLabel";
            likesLabel.Size = new Size(15, 18);
            likesLabel.TabIndex = 12;
            likesLabel.Text = "9";
            // 
            // usernameDescription
            // 
            usernameDescription.AutoSize = true;
            usernameDescription.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usernameDescription.ForeColor = SystemColors.ButtonFace;
            usernameDescription.Location = new Point(7, 320);
            usernameDescription.Name = "usernameDescription";
            usernameDescription.Size = new Size(68, 18);
            usernameDescription.TabIndex = 12;
            usernameDescription.Text = "username";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.ForeColor = SystemColors.ButtonFace;
            descriptionLabel.Location = new Point(72, 320);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(108, 18);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "some description";
            // 
            // postDate
            // 
            postDate.AutoSize = true;
            postDate.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            postDate.ForeColor = SystemColors.ControlDarkDark;
            postDate.Location = new Point(202, 297);
            postDate.Name = "postDate";
            postDate.Size = new Size(79, 18);
            postDate.TabIndex = 12;
            postDate.Text = "November 12";
            // 
            // FeedPost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Size = new Size(284, 349);
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
