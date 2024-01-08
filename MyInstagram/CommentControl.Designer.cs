namespace MyInstagram
{
    partial class CommentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentControl));
            commentImage = new RoundPictureBox();
            content = new Label();
            dateLabel = new Label();
            username = new Label();
            deleteButton = new Label();
            ((System.ComponentModel.ISupportInitialize)commentImage).BeginInit();
            SuspendLayout();
            // 
            // commentImage
            // 
            commentImage.Image = (Image)resources.GetObject("commentImage.Image");
            commentImage.Location = new Point(3, 3);
            commentImage.Name = "commentImage";
            commentImage.Size = new Size(50, 50);
            commentImage.SizeMode = PictureBoxSizeMode.StretchImage;
            commentImage.TabIndex = 0;
            commentImage.TabStop = false;
            commentImage.Click += commentImage_Click;
            // 
            // content
            // 
            content.AutoSize = true;
            content.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            content.ForeColor = SystemColors.ButtonHighlight;
            content.Location = new Point(59, 26);
            content.MaximumSize = new Size(2320, 0);
            content.Name = "content";
            content.Size = new Size(319, 23);
            content.TabIndex = 1;
            content.Text = "usernwwwwweqqqqqqqqqqqqqqqqqqq";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.ForeColor = SystemColors.ControlDark;
            dateLabel.Location = new Point(150, 4);
            dateLabel.Margin = new Padding(4, 0, 4, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(31, 21);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "2w";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            username.ForeColor = SystemColors.ButtonFace;
            username.Location = new Point(59, 3);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new Size(93, 23);
            username.TabIndex = 14;
            username.Text = "username";
            username.Click += commentImage_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.ForeColor = SystemColors.ControlDark;
            deleteButton.Location = new Point(365, -4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(30, 25);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "...";
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            deleteButton.MouseEnter += deleteButton_Enter;
            deleteButton.MouseLeave += deleteButton_Leave;
            // 
            // CommentControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            Controls.Add(deleteButton);
            Controls.Add(dateLabel);
            Controls.Add(username);
            Controls.Add(content);
            Controls.Add(commentImage);
            Margin = new Padding(0);
            Name = "CommentControl";
            Size = new Size(400, 57);
            ((System.ComponentModel.ISupportInitialize)commentImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RoundPictureBox commentImage;
        private Label content;
        private Label dateLabel;
        private Label username;
        private Label deleteButton;
    }
}
