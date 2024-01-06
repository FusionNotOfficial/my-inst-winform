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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectMessage));
            picture = new RoundPictureBox();
            username = new spLabel();
            notificationForm = new RoundControl();
            notification = new Label();
            lastMessage = new spLabel();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // picture
            // 
            picture.BackColor = Color.DimGray;
            picture.Enabled = false;
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.Location = new Point(17, 5);
            picture.Margin = new Padding(4, 5, 4, 5);
            picture.Name = "picture";
            picture.Size = new Size(71, 71);
            picture.TabIndex = 1;
            picture.TabStop = false;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Enabled = false;
            username.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            username.Location = new Point(97, 8);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new Size(106, 26);
            username.TabIndex = 3;
            username.Text = "username";
            // 
            // notificationForm
            // 
            notificationForm.BackColor = Color.DarkGray;
            notificationForm.Location = new Point(353, 25);
            notificationForm.Margin = new Padding(4, 5, 4, 5);
            notificationForm.Name = "notificationForm";
            notificationForm.Radius = 40;
            notificationForm.Size = new Size(36, 36);
            notificationForm.TabIndex = 4;
            notificationForm.Visible = false;
            // 
            // notification
            // 
            notification.AutoSize = true;
            notification.BackColor = Color.DarkGray;
            notification.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            notification.ForeColor = SystemColors.Control;
            notification.Location = new Point(360, 28);
            notification.Margin = new Padding(4, 0, 4, 0);
            notification.Name = "notification";
            notification.Size = new Size(22, 28);
            notification.TabIndex = 5;
            notification.Text = "1";
            notification.Visible = false;
            // 
            // lastMessage
            // 
            lastMessage.AutoSize = true;
            lastMessage.Enabled = false;
            lastMessage.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lastMessage.ForeColor = SystemColors.ButtonHighlight;
            lastMessage.Location = new Point(97, 47);
            lastMessage.Margin = new Padding(4, 0, 4, 0);
            lastMessage.Name = "lastMessage";
            lastMessage.Size = new Size(80, 23);
            lastMessage.TabIndex = 6;
            lastMessage.Text = "spLabel1";
            // 
            // DirectMessage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(lastMessage);
            Controls.Add(notification);
            Controls.Add(username);
            Controls.Add(picture);
            Controls.Add(notificationForm);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DirectMessage";
            Size = new Size(399, 82);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public RoundPictureBox picture;
        private spLabel username;
        private RoundControl notificationForm;
        private Label notification;
        private spLabel lastMessage;
    }
}
