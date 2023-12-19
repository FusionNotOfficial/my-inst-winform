namespace MyInstagram
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            PostsPannel = new FlowLayoutPanel();
            Direct = new PictureBox();
            DescriptionLabel = new Label();
            PostButton = new ULControls.ULButton();
            editProfileButton = new ULControls.ULButton();
            panel3 = new Panel();
            Following = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            Followers = new Label();
            userImage = new RoundPictureBox();
            usernameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Direct).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // PostsPannel
            // 
            PostsPannel.Location = new Point(5, 197);
            PostsPannel.Margin = new Padding(0);
            PostsPannel.Name = "PostsPannel";
            PostsPannel.Size = new Size(270, 192);
            PostsPannel.TabIndex = 17;
            // 
            // Direct
            // 
            Direct.Image = (Image)resources.GetObject("Direct.Image");
            Direct.Location = new Point(251, 8);
            Direct.Name = "Direct";
            Direct.Size = new Size(27, 27);
            Direct.SizeMode = PictureBoxSizeMode.StretchImage;
            Direct.TabIndex = 9;
            Direct.TabStop = false;
            Direct.Click += Direct_Click;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = SystemColors.ButtonFace;
            DescriptionLabel.Location = new Point(17, 118);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(73, 18);
            DescriptionLabel.TabIndex = 16;
            DescriptionLabel.Text = "description";
            // 
            // PostButton
            // 
            PostButton.BackColor = Color.FromArgb(64, 64, 64);
            PostButton.BackgroundColor = Color.FromArgb(64, 64, 64);
            PostButton.BorderColor = Color.PaleVioletRed;
            PostButton.BorderRadius = 12;
            PostButton.BorderSize = 0;
            PostButton.FlatAppearance.BorderSize = 0;
            PostButton.FlatStyle = FlatStyle.Flat;
            PostButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PostButton.ForeColor = Color.White;
            PostButton.Location = new Point(145, 161);
            PostButton.Name = "PostButton";
            PostButton.Size = new Size(125, 24);
            PostButton.TabIndex = 14;
            PostButton.Text = "Create Post";
            PostButton.TextColor = Color.White;
            PostButton.UseVisualStyleBackColor = false;
            PostButton.Click += PostButton_Click;
            // 
            // editProfileButton
            // 
            editProfileButton.BackColor = Color.FromArgb(64, 64, 64);
            editProfileButton.BackgroundColor = Color.FromArgb(64, 64, 64);
            editProfileButton.BorderColor = Color.PaleVioletRed;
            editProfileButton.BorderRadius = 12;
            editProfileButton.BorderSize = 0;
            editProfileButton.FlatAppearance.BorderSize = 0;
            editProfileButton.FlatStyle = FlatStyle.Flat;
            editProfileButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editProfileButton.ForeColor = Color.White;
            editProfileButton.Location = new Point(17, 161);
            editProfileButton.Name = "editProfileButton";
            editProfileButton.Size = new Size(125, 24);
            editProfileButton.TabIndex = 15;
            editProfileButton.Text = "Edit Profile";
            editProfileButton.TextColor = Color.White;
            editProfileButton.UseVisualStyleBackColor = false;
            editProfileButton.Click += editProfileButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Following);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(186, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(67, 36);
            panel3.TabIndex = 13;
            panel3.Click += Following_Button_Click;
            // 
            // Following
            // 
            Following.AutoSize = true;
            Following.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Following.ForeColor = SystemColors.ButtonFace;
            Following.Location = new Point(3, 18);
            Following.Name = "Following";
            Following.Size = new Size(59, 18);
            Following.TabIndex = 1;
            Following.Text = "Following";
            Following.Click += Following_Button_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(26, 0);
            label5.Name = "label5";
            label5.Size = new Size(16, 18);
            label5.TabIndex = 0;
            label5.Text = "0";
            label5.Click += Following_Button_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Followers);
            panel2.Location = new Point(122, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 36);
            panel2.TabIndex = 12;
            panel2.Click += Followers_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(3, 18);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 1;
            label4.Text = "Followers";
            label4.Click += Followers_Button_Click;
            // 
            // Followers
            // 
            Followers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Followers.AutoSize = true;
            Followers.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Followers.ForeColor = SystemColors.ButtonFace;
            Followers.Location = new Point(26, 0);
            Followers.Name = "Followers";
            Followers.Size = new Size(16, 18);
            Followers.TabIndex = 0;
            Followers.Text = "0";
            Followers.Click += Followers_Button_Click;
            // 
            // userImage
            // 
            userImage.Image = (Image)resources.GetObject("userImage.Image");
            userImage.Location = new Point(17, 48);
            userImage.Name = "userImage";
            userImage.Size = new Size(67, 67);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 11;
            userImage.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.ButtonFace;
            usernameLabel.Location = new Point(17, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(96, 24);
            usernameLabel.TabIndex = 10;
            usernameLabel.Text = "username";
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 392);
            Controls.Add(PostsPannel);
            Controls.Add(Direct);
            Controls.Add(DescriptionLabel);
            Controls.Add(PostButton);
            Controls.Add(editProfileButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(userImage);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyProfile";
            Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)Direct).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PostsPannel;
        private Label DescriptionLabel;
        private ULControls.ULButton PostButton;
        private ULControls.ULButton editProfileButton;
        private Panel panel3;
        private Label Following;
        private Label label5;
        private Panel panel2;
        private Label label4;
        private Label Followers;
        private RoundPictureBox userImage;
        private Label usernameLabel;
        private PictureBox Direct;
    }
}