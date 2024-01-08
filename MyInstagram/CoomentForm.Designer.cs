namespace MyInstagram
{
    partial class CommentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentForm));
            backButton = new PictureBox();
            label1 = new Label();
            commentsPanel = new FlowLayoutPanel();
            message = new ULControls.ULTextBox();
            userIcon = new RoundPictureBox();
            sendIcon = new PictureBox();
            sendButton = new RoundControl();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sendIcon).BeginInit();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(0, 5);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(50, 52);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 5;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(145, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 6;
            label1.Text = "Comments";
            // 
            // commentsPanel
            // 
            commentsPanel.AutoScroll = true;
            commentsPanel.Location = new Point(0, 65);
            commentsPanel.Name = "commentsPanel";
            commentsPanel.Size = new Size(435, 581);
            commentsPanel.TabIndex = 7;
            // 
            // message
            // 
            message.BackColor = Color.FromArgb(36, 36, 36);
            message.BorderColor = SystemColors.ControlDarkDark;
            message.BorderFocusColor = Color.White;
            message.BorderSize = 2;
            message.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            message.ForeColor = Color.White;
            message.Location = new Point(78, 654);
            message.Margin = new Padding(4, 5, 4, 5);
            message.Multiline = true;
            message.Name = "message";
            message.Padding = new Padding(10, 12, 10, 12);
            message.PasswordChar = false;
            message.Size = new Size(277, 49);
            message.TabIndex = 9;
            message.Texts = "";
            message.UnderlinedStyle = false;
            // 
            // userIcon
            // 
            userIcon.Image = (Image)resources.GetObject("userIcon.Image");
            userIcon.Location = new Point(12, 654);
            userIcon.Name = "userIcon";
            userIcon.Size = new Size(50, 50);
            userIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            userIcon.TabIndex = 10;
            userIcon.TabStop = false;
            // 
            // sendIcon
            // 
            sendIcon.BackColor = Color.DodgerBlue;
            sendIcon.Enabled = false;
            sendIcon.Image = (Image)resources.GetObject("sendIcon.Image");
            sendIcon.Location = new Point(334, 659);
            sendIcon.Name = "sendIcon";
            sendIcon.Size = new Size(40, 40);
            sendIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            sendIcon.TabIndex = 11;
            sendIcon.TabStop = false;
            sendIcon.Click += sendPicture_Click;
            sendIcon.MouseEnter += sendButton_Enter;
            sendIcon.MouseLeave += sendButton_MouseLeave;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.DodgerBlue;
            sendButton.Location = new Point(318, 654);
            sendButton.Name = "sendButton";
            sendButton.Radius = 40;
            sendButton.Size = new Size(70, 50);
            sendButton.TabIndex = 12;
            sendButton.Click += sendPicture_Click;
            sendButton.MouseEnter += sendButton_Enter;
            sendButton.MouseLeave += sendButton_MouseLeave;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(400, 718);
            Controls.Add(sendIcon);
            Controls.Add(userIcon);
            Controls.Add(commentsPanel);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(sendButton);
            Controls.Add(message);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CommentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoomentForm";
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)userIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)sendIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox backButton;
        private Label label1;
        private FlowLayoutPanel commentsPanel;
        private ULControls.ULTextBox message;
        private RoundPictureBox userIcon;
        private PictureBox sendIcon;
        private RoundControl sendButton;
    }
}