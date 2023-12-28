namespace MyInstagram
{
    partial class PostUserControl
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
            postImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)postImage).BeginInit();
            SuspendLayout();
            // 
            // postImage
            // 
            postImage.Location = new Point(0, 0);
            postImage.Margin = new Padding(0);
            postImage.Name = "postImage";
            postImage.Size = new Size(130, 130);
            postImage.SizeMode = PictureBoxSizeMode.StretchImage;
            postImage.TabIndex = 0;
            postImage.TabStop = false;
            // 
            // PostUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(postImage);
            Margin = new Padding(0);
            Name = "PostUserControl";
            Size = new Size(130, 130);
            ((System.ComponentModel.ISupportInitialize)postImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox postImage;
    }
}
