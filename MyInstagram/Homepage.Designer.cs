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
            messenger = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)messenger).BeginInit();
            SuspendLayout();
            // 
            // messenger
            // 
            messenger.Image = (Image)resources.GetObject("messenger.Image");
            messenger.Location = new Point(222, 12);
            messenger.Name = "messenger";
            messenger.Size = new Size(50, 50);
            messenger.SizeMode = PictureBoxSizeMode.StretchImage;
            messenger.TabIndex = 0;
            messenger.TabStop = false;
            messenger.Click += messenger_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 431);
            Controls.Add(messenger);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)messenger).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox messenger;
    }
}