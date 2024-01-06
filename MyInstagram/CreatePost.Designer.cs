namespace MyInstagram
{
    partial class CreatePost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePost));
            Direct = new PictureBox();
            label1 = new Label();
            ShareButton = new Label();
            SelectedImage = new PictureBox();
            ImageLabel = new Label();
            labelLine2 = new LabelLine();
            description = new ULControls.ULTextBox();
            ((System.ComponentModel.ISupportInitialize)Direct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectedImage).BeginInit();
            SuspendLayout();
            // 
            // Direct
            // 
            Direct.Image = (Image)resources.GetObject("Direct.Image");
            Direct.Location = new Point(3, 2);
            Direct.Margin = new Padding(4, 5, 4, 5);
            Direct.Name = "Direct";
            Direct.Size = new Size(43, 45);
            Direct.SizeMode = PictureBoxSizeMode.StretchImage;
            Direct.TabIndex = 1;
            Direct.TabStop = false;
            Direct.Click += Direct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(156, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 26);
            label1.TabIndex = 2;
            label1.Text = "New post";
            // 
            // ShareButton
            // 
            ShareButton.AutoSize = true;
            ShareButton.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShareButton.ForeColor = SystemColors.GrayText;
            ShareButton.Location = new Point(327, 9);
            ShareButton.Margin = new Padding(4, 0, 4, 0);
            ShareButton.Name = "ShareButton";
            ShareButton.Size = new Size(69, 27);
            ShareButton.TabIndex = 2;
            ShareButton.Text = "Share";
            ShareButton.Click += NextButton_Click;
            // 
            // SelectedImage
            // 
            SelectedImage.Location = new Point(3, 50);
            SelectedImage.Margin = new Padding(4, 5, 4, 5);
            SelectedImage.Name = "SelectedImage";
            SelectedImage.Size = new Size(414, 537);
            SelectedImage.SizeMode = PictureBoxSizeMode.Zoom;
            SelectedImage.TabIndex = 3;
            SelectedImage.TabStop = false;
            SelectedImage.Click += SelectedImage_Click;
            // 
            // ImageLabel
            // 
            ImageLabel.AutoSize = true;
            ImageLabel.BackColor = SystemColors.ActiveCaptionText;
            ImageLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ImageLabel.ForeColor = SystemColors.ButtonHighlight;
            ImageLabel.Location = new Point(83, 260);
            ImageLabel.Margin = new Padding(4, 0, 4, 0);
            ImageLabel.Name = "ImageLabel";
            ImageLabel.Size = new Size(238, 32);
            ImageLabel.TabIndex = 4;
            ImageLabel.Text = "Click to select image";
            ImageLabel.Click += SelectedImage_Click;
            // 
            // labelLine2
            // 
            labelLine2.BorderStyle = BorderStyle.Fixed3D;
            labelLine2.Location = new Point(-3, 50);
            labelLine2.Margin = new Padding(4, 0, 4, 0);
            labelLine2.Name = "labelLine2";
            labelLine2.Size = new Size(414, 2);
            labelLine2.TabIndex = 9;
            labelLine2.Text = "labelLine1";
            // 
            // description
            // 
            description.BackColor = SystemColors.ActiveCaptionText;
            description.BorderColor = Color.DimGray;
            description.BorderFocusColor = Color.DimGray;
            description.BorderSize = 2;
            description.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            description.ForeColor = Color.Gainsboro;
            description.Location = new Point(-3, 587);
            description.Margin = new Padding(4, 5, 4, 5);
            description.Multiline = true;
            description.Name = "description";
            description.Padding = new Padding(10, 12, 10, 12);
            description.PasswordChar = false;
            description.Size = new Size(414, 136);
            description.TabIndex = 11;
            description.Texts = "Write a caption...";
            description.UnderlinedStyle = false;
            // 
            // CreatePost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(400, 718);
            Controls.Add(description);
            Controls.Add(labelLine2);
            Controls.Add(ImageLabel);
            Controls.Add(SelectedImage);
            Controls.Add(ShareButton);
            Controls.Add(label1);
            Controls.Add(Direct);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CreatePost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePost";
            ((System.ComponentModel.ISupportInitialize)Direct).EndInit();
            ((System.ComponentModel.ISupportInitialize)SelectedImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Direct;
        private Label label1;
        private Label ShareButton;
        private PictureBox SelectedImage;
        private Label ImageLabel;
        private LabelLine labelLine2;
        private ULControls.ULTextBox description;
    }
}