namespace MyInstagram
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            Direct = new PictureBox();
            panel1 = new Panel();
            search_select = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            home_select = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            account_select = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            account_panel = new Panel();
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
            home_panel = new Panel();
            labelLine1 = new LabelLine();
            ((System.ComponentModel.ISupportInitialize)Direct).BeginInit();
            panel1.SuspendLayout();
            search_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            home_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            account_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            account_panel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            SuspendLayout();
            // 
            // Direct
            // 
            Direct.Image = (Image)resources.GetObject("Direct.Image");
            Direct.Location = new Point(251, 6);
            Direct.Name = "Direct";
            Direct.Size = new Size(30, 30);
            Direct.SizeMode = PictureBoxSizeMode.StretchImage;
            Direct.TabIndex = 0;
            Direct.TabStop = false;
            Direct.Click += Direct_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(search_select);
            panel1.Controls.Add(home_select);
            panel1.Controls.Add(account_select);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 39);
            panel1.TabIndex = 1;
            // 
            // search_select
            // 
            search_select.Controls.Add(label1);
            search_select.Controls.Add(pictureBox3);
            search_select.Controls.Add(panel6);
            search_select.Location = new Point(97, 0);
            search_select.Name = "search_select";
            search_select.Size = new Size(94, 40);
            search_select.TabIndex = 0;
            search_select.Click += search_select_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(1, 41);
            label1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(33, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += search_select_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(97, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(94, 40);
            panel6.TabIndex = 0;
            // 
            // home_select
            // 
            home_select.Controls.Add(pictureBox2);
            home_select.Controls.Add(panel4);
            home_select.Location = new Point(0, 0);
            home_select.Name = "home_select";
            home_select.Size = new Size(97, 40);
            home_select.TabIndex = 0;
            home_select.Click += home_select_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += home_select_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(97, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(94, 40);
            panel4.TabIndex = 0;
            // 
            // account_select
            // 
            account_select.Controls.Add(label2);
            account_select.Controls.Add(pictureBox1);
            account_select.Location = new Point(190, 0);
            account_select.Name = "account_select";
            account_select.Size = new Size(94, 40);
            account_select.TabIndex = 0;
            account_select.Click += account_select_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1, -1);
            label2.Name = "label2";
            label2.Size = new Size(1, 41);
            label2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += account_select_Click;
            // 
            // account_panel
            // 
            account_panel.Controls.Add(Direct);
            account_panel.Controls.Add(DescriptionLabel);
            account_panel.Controls.Add(PostButton);
            account_panel.Controls.Add(editProfileButton);
            account_panel.Controls.Add(panel3);
            account_panel.Controls.Add(panel2);
            account_panel.Controls.Add(userImage);
            account_panel.Controls.Add(usernameLabel);
            account_panel.Controls.Add(home_panel);
            account_panel.Dock = DockStyle.Top;
            account_panel.Location = new Point(0, 0);
            account_panel.Name = "account_panel";
            account_panel.Size = new Size(284, 391);
            account_panel.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionLabel.ForeColor = SystemColors.ButtonFace;
            DescriptionLabel.Location = new Point(19, 121);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(73, 18);
            DescriptionLabel.TabIndex = 7;
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
            PostButton.Location = new Point(147, 164);
            PostButton.Name = "PostButton";
            PostButton.Size = new Size(125, 24);
            PostButton.TabIndex = 6;
            PostButton.Text = "Create Post";
            PostButton.TextColor = Color.White;
            PostButton.UseVisualStyleBackColor = false;
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
            editProfileButton.Location = new Point(19, 164);
            editProfileButton.Name = "editProfileButton";
            editProfileButton.Size = new Size(125, 24);
            editProfileButton.TabIndex = 6;
            editProfileButton.Text = "Edit Profile";
            editProfileButton.TextColor = Color.White;
            editProfileButton.UseVisualStyleBackColor = false;
            editProfileButton.Click += editProfileButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Following);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(188, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(67, 36);
            panel3.TabIndex = 5;
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
            panel2.Location = new Point(124, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 36);
            panel2.TabIndex = 4;
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
            userImage.Location = new Point(19, 51);
            userImage.Name = "userImage";
            userImage.Size = new Size(67, 67);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 3;
            userImage.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLabel.ForeColor = SystemColors.ButtonFace;
            usernameLabel.Location = new Point(19, 12);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(96, 24);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "username";
            // 
            // home_panel
            // 
            home_panel.Location = new Point(3, 3);
            home_panel.Name = "home_panel";
            home_panel.Size = new Size(24, 389);
            home_panel.TabIndex = 1;
            home_panel.Visible = false;
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Location = new Point(-5, 391);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(290, 1);
            labelLine1.TabIndex = 8;
            labelLine1.Text = "labelLine1";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 431);
            Controls.Add(labelLine1);
            Controls.Add(account_panel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)Direct).EndInit();
            panel1.ResumeLayout(false);
            search_select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            home_select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            account_select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            account_panel.ResumeLayout(false);
            account_panel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Direct;
        private Panel panel1;
        private Panel search_select;
        private Panel panel6;
        private Panel home_select;
        private Panel panel4;
        private Panel account_select;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Panel account_panel;
        private Panel home_panel;
        private RoundPictureBox userImage;
        private Label usernameLabel;
        private Panel panel2;
        private Label label4;
        private Label Followers;
        private Panel panel3;
        private Label Following;
        private Label label5;
        private ULControls.ULButton editProfileButton;
        private ULControls.ULButton PostButton;
        private Label DescriptionLabel;
        private LabelLine labelLine1;
    }
}