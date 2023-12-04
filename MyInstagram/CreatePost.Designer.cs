﻿namespace MyInstagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePost));
            Direct = new PictureBox();
            label1 = new Label();
            ShareButton = new Label();
            SelectedImage = new PictureBox();
            ImageLabel = new Label();
            labelLine2 = new LabelLine();
            ulTextBox1 = new ULControls.ULTextBox();
            ((System.ComponentModel.ISupportInitialize)Direct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SelectedImage).BeginInit();
            SuspendLayout();
            // 
            // Direct
            // 
            Direct.Image = (Image)resources.GetObject("Direct.Image");
            Direct.Location = new Point(2, 1);
            Direct.Name = "Direct";
            Direct.Size = new Size(30, 30);
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
            label1.Location = new Point(109, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 18);
            label1.TabIndex = 2;
            label1.Text = "New post";
            // 
            // ShareButton
            // 
            ShareButton.AutoSize = true;
            ShareButton.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ShareButton.ForeColor = SystemColors.MenuHighlight;
            ShareButton.Location = new Point(235, 7);
            ShareButton.Name = "ShareButton";
            ShareButton.Size = new Size(47, 19);
            ShareButton.TabIndex = 2;
            ShareButton.Text = "Share";
            ShareButton.Click += NextButton_Click;
            // 
            // SelectedImage
            // 
            SelectedImage.Location = new Point(-2, 30);
            SelectedImage.Name = "SelectedImage";
            SelectedImage.Size = new Size(290, 322);
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
            ImageLabel.Location = new Point(61, 156);
            ImageLabel.Name = "ImageLabel";
            ImageLabel.Size = new Size(160, 21);
            ImageLabel.TabIndex = 4;
            ImageLabel.Text = "Click to select image";
            ImageLabel.Click += SelectedImage_Click;
            // 
            // labelLine2
            // 
            labelLine2.BorderStyle = BorderStyle.Fixed3D;
            labelLine2.Location = new Point(-2, 30);
            labelLine2.Name = "labelLine2";
            labelLine2.Size = new Size(290, 1);
            labelLine2.TabIndex = 9;
            labelLine2.Text = "labelLine1";
            // 
            // ulTextBox1
            // 
            ulTextBox1.BackColor = SystemColors.ActiveCaptionText;
            ulTextBox1.BorderColor = Color.DimGray;
            ulTextBox1.BorderFocusColor = Color.DimGray;
            ulTextBox1.BorderSize = 2;
            ulTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ulTextBox1.ForeColor = Color.Gray;
            ulTextBox1.Location = new Point(0, 352);
            ulTextBox1.Multiline = true;
            ulTextBox1.Name = "ulTextBox1";
            ulTextBox1.Padding = new Padding(7);
            ulTextBox1.PasswordChar = false;
            ulTextBox1.Size = new Size(284, 78);
            ulTextBox1.TabIndex = 11;
            ulTextBox1.Texts = "Write a caption...";
            ulTextBox1.UnderlinedStyle = false;
            // 
            // CreatePost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 431);
            Controls.Add(ulTextBox1);
            Controls.Add(labelLine2);
            Controls.Add(ImageLabel);
            Controls.Add(SelectedImage);
            Controls.Add(ShareButton);
            Controls.Add(label1);
            Controls.Add(Direct);
            FormBorderStyle = FormBorderStyle.None;
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
        private ULControls.ULTextBox ulTextBox1;
    }
}