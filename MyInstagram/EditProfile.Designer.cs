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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            labelLine1 = new LabelLine();
            label1 = new Label();
            backButton = new PictureBox();
            roundPictureBox1 = new RoundPictureBox();
            profilePhoto = new Label();
            labelLine2 = new LabelLine();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Name = new ULControls.ULTextBox();
            Password = new ULControls.ULTextBox();
            Description = new ULControls.ULTextBox();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Location = new Point(-2, 38);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(285, 1);
            labelLine1.TabIndex = 0;
            labelLine1.Text = "labelLine1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 1;
            label1.Text = "Edit profile";
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(0, -1);
            backButton.Name = "backButton";
            backButton.Size = new Size(39, 39);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 2;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.Image = (Image)resources.GetObject("roundPictureBox1.Image");
            roundPictureBox1.Location = new Point(113, 55);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(60, 60);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            roundPictureBox1.TabIndex = 3;
            roundPictureBox1.TabStop = false;
            // 
            // profilePhoto
            // 
            profilePhoto.AutoSize = true;
            profilePhoto.Font = new Font("UD Digi Kyokasho NK-B", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilePhoto.ForeColor = Color.DodgerBlue;
            profilePhoto.Location = new Point(76, 120);
            profilePhoto.Name = "profilePhoto";
            profilePhoto.Size = new Size(140, 14);
            profilePhoto.TabIndex = 1;
            profilePhoto.Text = "Change profile photo";
            // 
            // labelLine2
            // 
            labelLine2.BorderStyle = BorderStyle.Fixed3D;
            labelLine2.Location = new Point(0, 147);
            labelLine2.Name = "labelLine2";
            labelLine2.Size = new Size(285, 1);
            labelLine2.TabIndex = 0;
            labelLine2.Text = "labelLine1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(65, 18);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 245);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 1;
            label4.Text = "Description";
            // 
            // Name
            // 
            Name.BackColor = SystemColors.Desktop;
            Name.BorderColor = Color.Gray;
            Name.BorderFocusColor = Color.HotPink;
            Name.BorderSize = 1;
            Name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name.ForeColor = Color.DimGray;
            Name.Location = new Point(102, 153);
            Name.Multiline = false;
            Name.Name = "Name";
            Name.Padding = new Padding(7);
            Name.PasswordChar = false;
            Name.Size = new Size(183, 30);
            Name.TabIndex = 4;
            Name.Texts = "";
            Name.UnderlinedStyle = true;
            // 
            // Password
            // 
            Password.BackColor = SystemColors.Desktop;
            Password.BorderColor = Color.Gray;
            Password.BorderFocusColor = Color.HotPink;
            Password.BorderSize = 1;
            Password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.DimGray;
            Password.Location = new Point(102, 192);
            Password.Multiline = false;
            Password.Name = "Password";
            Password.Padding = new Padding(7);
            Password.PasswordChar = false;
            Password.Size = new Size(181, 30);
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
            Description.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Description.ForeColor = Color.DimGray;
            Description.Location = new Point(102, 230);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.Padding = new Padding(7);
            Description.PasswordChar = false;
            Description.Size = new Size(181, 30);
            Description.TabIndex = 4;
            Description.Texts = "";
            Description.UnderlinedStyle = true;
            // 
            // EditProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 431);
            Controls.Add(Description);
            Controls.Add(Password);
            Controls.Add(Name);
            Controls.Add(roundPictureBox1);
            Controls.Add(backButton);
            Controls.Add(profilePhoto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLine2);
            Controls.Add(labelLine1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfile";
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LabelLine labelLine1;
        private Label label1;
        private PictureBox backButton;
        private RoundPictureBox roundPictureBox1;
        private Label profilePhoto;
        private LabelLine labelLine2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ULControls.ULTextBox Name;
        private ULControls.ULTextBox Password;
        private ULControls.ULTextBox Description;
    }
}