namespace MyInstagram
{
    partial class DirectMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectMessage));
            picture = new RoundPictureBox();
            lastMessage = new Label();
            username = new spLabel();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.Enabled = false;
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.Location = new Point(12, 3);
            picture.Name = "picture";
            picture.Size = new Size(50, 50);
            picture.TabIndex = 1;
            picture.TabStop = false;
            // 
            // lastMessage
            // 
            lastMessage.AutoSize = true;
            lastMessage.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastMessage.ForeColor = SystemColors.ButtonHighlight;
            lastMessage.Location = new Point(68, 26);
            lastMessage.Name = "lastMessage";
            lastMessage.Size = new Size(79, 18);
            lastMessage.TabIndex = 2;
            lastMessage.Text = "lastMessage";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Enabled = false;
            username.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(68, 5);
            username.Name = "username";
            username.Size = new Size(68, 18);
            username.TabIndex = 3;
            username.Text = "username";
            // 
            // DirectMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(username);
            Controls.Add(lastMessage);
            Controls.Add(picture);
            Name = "DirectMessage";
            Size = new Size(342, 56);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lastMessage;
        public RoundPictureBox picture;
        private spLabel username;
    }
}
