namespace MyInstagram
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            labelLine1 = new LabelLine();
            label1 = new Label();
            backButton = new PictureBox();
            newImageRound = new RoundPictureBox();
            profilePhoto = new Label();
            labelLine2 = new LabelLine();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            newUsername = new ULControls.ULTextBox();
            Password = new ULControls.ULTextBox();
            Description = new ULControls.ULTextBox();
            ApplyButton = new ULControls.ULButton();
            NoChangesError = new Label();
            usernameError = new Label();
            passwordError = new Label();
            descriptionError = new Label();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newImageRound).BeginInit();
            SuspendLayout();
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Location = new Point(-2, 56);
            labelLine1.Margin = new Padding(4, 0, 4, 0);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(407, 2);
            labelLine1.TabIndex = 0;
            labelLine1.Text = "labelLine1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(146, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(118, 26);
            label1.TabIndex = 1;
            label1.Text = "Edit profile";
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(0, -2);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(53, 55);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 2;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // newImageRound
            // 
            newImageRound.Image = (Image)resources.GetObject("newImageRound.Image");
            newImageRound.Location = new Point(161, 72);
            newImageRound.Margin = new Padding(4, 5, 4, 5);
            newImageRound.Name = "newImageRound";
            newImageRound.Size = new Size(86, 86);
            newImageRound.SizeMode = PictureBoxSizeMode.StretchImage;
            newImageRound.TabIndex = 3;
            newImageRound.TabStop = false;
            // 
            // profilePhoto
            // 
            profilePhoto.AutoSize = true;
            profilePhoto.Font = new Font("UD Digi Kyokasho NK-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilePhoto.ForeColor = Color.DodgerBlue;
            profilePhoto.Location = new Point(109, 173);
            profilePhoto.Margin = new Padding(4, 0, 4, 0);
            profilePhoto.Name = "profilePhoto";
            profilePhoto.Size = new Size(211, 21);
            profilePhoto.TabIndex = 1;
            profilePhoto.Text = "Change profile photo";
            profilePhoto.Click += profilePhoto_Click;
            // 
            // labelLine2
            // 
            labelLine2.BorderStyle = BorderStyle.Fixed3D;
            labelLine2.Location = new Point(-2, 213);
            labelLine2.Margin = new Padding(4, 0, 4, 0);
            labelLine2.Name = "labelLine2";
            labelLine2.Size = new Size(407, 2);
            labelLine2.TabIndex = 0;
            labelLine2.Text = "labelLine1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(15, 255);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 26);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(15, 338);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 26);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(15, 428);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 26);
            label4.TabIndex = 1;
            label4.Text = "Description";
            // 
            // newUsername
            // 
            newUsername.BackColor = SystemColors.Desktop;
            newUsername.BorderColor = Color.Gray;
            newUsername.BorderFocusColor = Color.HotPink;
            newUsername.BorderSize = 1;
            newUsername.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            newUsername.ForeColor = Color.White;
            newUsername.Location = new Point(148, 230);
            newUsername.Margin = new Padding(4, 5, 4, 5);
            newUsername.Multiline = false;
            newUsername.Name = "newUsername";
            newUsername.Padding = new Padding(10, 12, 10, 12);
            newUsername.PasswordChar = false;
            newUsername.Size = new Size(239, 51);
            newUsername.TabIndex = 4;
            newUsername.Texts = "";
            newUsername.UnderlinedStyle = true;
            // 
            // Password
            // 
            Password.BackColor = SystemColors.Desktop;
            Password.BorderColor = Color.Gray;
            Password.BorderFocusColor = Color.HotPink;
            Password.BorderSize = 1;
            Password.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.White;
            Password.Location = new Point(144, 316);
            Password.Margin = new Padding(4, 5, 4, 5);
            Password.Multiline = false;
            Password.Name = "Password";
            Password.Padding = new Padding(10, 12, 10, 12);
            Password.PasswordChar = false;
            Password.Size = new Size(243, 51);
            Password.TabIndex = 4;
            Password.Texts = "";
            Password.UnderlinedStyle = true;
            // 
            // Description
            // 
            Description.BackColor = SystemColors.Desktop;
            Description.BorderColor = Color.Gray;
            Description.BorderFocusColor = Color.HotPink;
            Description.BorderSize = 1;
            Description.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Description.ForeColor = Color.White;
            Description.Location = new Point(144, 403);
            Description.Margin = new Padding(4, 5, 4, 5);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Padding = new Padding(10, 12, 10, 12);
            Description.PasswordChar = false;
            Description.Size = new Size(243, 50);
            Description.TabIndex = 4;
            Description.Texts = "";
            Description.UnderlinedStyle = true;
            // 
            // ApplyButton
            // 
            ApplyButton.BackColor = Color.FromArgb(64, 64, 64);
            ApplyButton.BackgroundColor = Color.FromArgb(64, 64, 64);
            ApplyButton.BorderColor = Color.PaleVioletRed;
            ApplyButton.BorderRadius = 12;
            ApplyButton.BorderSize = 0;
            ApplyButton.FlatAppearance.BorderSize = 0;
            ApplyButton.FlatStyle = FlatStyle.Flat;
            ApplyButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ApplyButton.ForeColor = Color.White;
            ApplyButton.Location = new Point(109, 628);
            ApplyButton.Margin = new Padding(4, 5, 4, 5);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(179, 40);
            ApplyButton.TabIndex = 7;
            ApplyButton.Text = "Apply";
            ApplyButton.TextColor = Color.White;
            ApplyButton.UseVisualStyleBackColor = false;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // NoChangesError
            // 
            NoChangesError.AutoSize = true;
            NoChangesError.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            NoChangesError.ForeColor = Color.Red;
            NoChangesError.Location = new Point(17, 578);
            NoChangesError.Margin = new Padding(4, 0, 4, 0);
            NoChangesError.Name = "NoChangesError";
            NoChangesError.Size = new Size(314, 23);
            NoChangesError.TabIndex = 8;
            NoChangesError.Text = "Please do some changes before apply!";
            NoChangesError.Visible = false;
            // 
            // usernameError
            // 
            usernameError.AutoSize = true;
            usernameError.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            usernameError.ForeColor = Color.Red;
            usernameError.Location = new Point(15, 295);
            usernameError.Margin = new Padding(4, 0, 4, 0);
            usernameError.Name = "usernameError";
            usernameError.Size = new Size(215, 23);
            usernameError.TabIndex = 8;
            usernameError.Text = "That name already exists!";
            usernameError.Visible = false;
            // 
            // passwordError
            // 
            passwordError.AutoSize = true;
            passwordError.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordError.ForeColor = Color.Red;
            passwordError.Location = new Point(15, 372);
            passwordError.Margin = new Padding(4, 0, 4, 0);
            passwordError.Name = "passwordError";
            passwordError.Size = new Size(215, 23);
            passwordError.TabIndex = 8;
            passwordError.Text = "That name already exists!";
            passwordError.Visible = false;
            // 
            // descriptionError
            // 
            descriptionError.AutoSize = true;
            descriptionError.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionError.ForeColor = Color.Red;
            descriptionError.Location = new Point(15, 458);
            descriptionError.Margin = new Padding(4, 0, 4, 0);
            descriptionError.Name = "descriptionError";
            descriptionError.Size = new Size(394, 23);
            descriptionError.TabIndex = 8;
            descriptionError.Text = "Description can't contain more that 40 symbols!";
            descriptionError.Visible = false;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(400, 718);
            Controls.Add(descriptionError);
            Controls.Add(passwordError);
            Controls.Add(usernameError);
            Controls.Add(NoChangesError);
            Controls.Add(ApplyButton);
            Controls.Add(Description);
            Controls.Add(Password);
            Controls.Add(newUsername);
            Controls.Add(newImageRound);
            Controls.Add(backButton);
            Controls.Add(profilePhoto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLine2);
            Controls.Add(labelLine1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            Load += EditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)newImageRound).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelLine labelLine1;
        private Label label1;
        private PictureBox backButton;
        private RoundPictureBox newImageRound;
        private Label profilePhoto;
        private LabelLine labelLine2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ULControls.ULTextBox newUsername;
        private ULControls.ULTextBox Password;
        private ULControls.ULTextBox Description;
        private ULControls.ULButton ApplyButton;
        private Label NoChangesError;
        private Label usernameError;
        private Label passwordError;
        private Label descriptionError;
    }
}