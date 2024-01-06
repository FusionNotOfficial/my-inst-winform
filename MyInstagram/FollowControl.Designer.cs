namespace MyInstagram
{
    partial class FollowControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowControl));
            picture = new RoundPictureBox();
            account_name = new Label();
            follow = new Label();
            remove = new ULControls.ULButton();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.Location = new Point(3, 6);
            picture.Name = "picture";
            picture.Size = new Size(55, 55);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 0;
            picture.TabStop = false;
            picture.Click += picture_Click;
            // 
            // account_name
            // 
            account_name.AutoSize = true;
            account_name.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            account_name.ForeColor = SystemColors.ButtonFace;
            account_name.Location = new Point(65, 23);
            account_name.Margin = new Padding(4, 0, 4, 0);
            account_name.Name = "account_name";
            account_name.Size = new Size(134, 23);
            account_name.TabIndex = 4;
            account_name.Text = "account_name";
            account_name.Click += picture_Click;
            // 
            // follow
            // 
            follow.AutoSize = true;
            follow.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            follow.ForeColor = SystemColors.Highlight;
            follow.Location = new Point(238, 23);
            follow.Margin = new Padding(4, 0, 4, 0);
            follow.Name = "follow";
            follow.Size = new Size(64, 23);
            follow.TabIndex = 4;
            follow.Text = "Follow";
            follow.Click += follow_Click;
            // 
            // remove
            // 
            remove.BackColor = Color.FromArgb(64, 64, 64);
            remove.BackgroundColor = Color.FromArgb(64, 64, 64);
            remove.BorderColor = Color.PaleVioletRed;
            remove.BorderRadius = 15;
            remove.BorderSize = 0;
            remove.FlatAppearance.BorderSize = 0;
            remove.FlatStyle = FlatStyle.Flat;
            remove.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            remove.ForeColor = Color.White;
            remove.Location = new Point(304, 16);
            remove.Name = "remove";
            remove.Size = new Size(83, 36);
            remove.TabIndex = 5;
            remove.Text = "Remove";
            remove.TextColor = Color.White;
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // FollowControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(remove);
            Controls.Add(follow);
            Controls.Add(account_name);
            Controls.Add(picture);
            Name = "FollowControl";
            Size = new Size(406, 69);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public RoundPictureBox picture;
        public Label account_name;
        public Label follow;
        public ULControls.ULButton remove;
    }
}
