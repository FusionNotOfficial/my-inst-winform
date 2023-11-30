namespace MyInstagram
{
    partial class Messenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messenger));
            message = new ULControls.ULTextBox();
            pictureBox1 = new PictureBox();
            account_name = new Label();
            labelLine1 = new LabelLine();
            messagesPanel = new FlowLayoutPanel();
            LengthError = new Label();
            roomIcon = new RoundPictureBox();
            lastSeen = new Label();
            sendIcon = new PictureBox();
            sendButton = new RoundControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sendIcon).BeginInit();
            SuspendLayout();
            // 
            // message
            // 
            message.BackColor = SystemColors.Window;
            message.BorderColor = SystemColors.ControlDarkDark;
            message.BorderFocusColor = Color.HotPink;
            message.BorderSize = 2;
            message.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            message.ForeColor = Color.DimGray;
            message.Location = new Point(12, 389);
            message.Multiline = true;
            message.Name = "message";
            message.Padding = new Padding(7);
            message.PasswordChar = false;
            message.Size = new Size(228, 30);
            message.TabIndex = 0;
            message.Texts = "";
            message.UnderlinedStyle = true;
            message._TextChanged += message__TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += BackButton_Click;
            // 
            // account_name
            // 
            account_name.AutoSize = true;
            account_name.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            account_name.ForeColor = SystemColors.ButtonHighlight;
            account_name.Location = new Point(78, 2);
            account_name.Name = "account_name";
            account_name.Size = new Size(121, 22);
            account_name.TabIndex = 6;
            account_name.Text = "account_name";
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Location = new Point(1, 40);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(285, 1);
            labelLine1.TabIndex = 7;
            labelLine1.Text = "labelLine1";
            // 
            // messagesPanel
            // 
            messagesPanel.Location = new Point(1, 43);
            messagesPanel.Name = "messagesPanel";
            messagesPanel.Size = new Size(285, 340);
            messagesPanel.TabIndex = 8;
            // 
            // LengthError
            // 
            LengthError.AutoSize = true;
            LengthError.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LengthError.ForeColor = Color.Red;
            LengthError.Location = new Point(12, 370);
            LengthError.Name = "LengthError";
            LengthError.Size = new Size(158, 16);
            LengthError.TabIndex = 12;
            LengthError.Text = "Message limit is 100 symbols!";
            LengthError.Visible = false;
            // 
            // roomIcon
            // 
            roomIcon.Image = (Image)resources.GetObject("roomIcon.Image");
            roomIcon.Location = new Point(42, 5);
            roomIcon.Name = "roomIcon";
            roomIcon.Size = new Size(31, 31);
            roomIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            roomIcon.TabIndex = 9;
            roomIcon.TabStop = false;
            // 
            // lastSeen
            // 
            lastSeen.AutoSize = true;
            lastSeen.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastSeen.ForeColor = SystemColors.ControlDarkDark;
            lastSeen.Location = new Point(79, 20);
            lastSeen.Name = "lastSeen";
            lastSeen.Size = new Size(103, 16);
            lastSeen.TabIndex = 6;
            lastSeen.Text = "was active at 18:30";
            // 
            // sendIcon
            // 
            sendIcon.BackColor = Color.CornflowerBlue;
            sendIcon.Enabled = false;
            sendIcon.Image = (Image)resources.GetObject("sendIcon.Image");
            sendIcon.Location = new Point(235, 389);
            sendIcon.Name = "sendIcon";
            sendIcon.Size = new Size(26, 30);
            sendIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            sendIcon.TabIndex = 10;
            sendIcon.TabStop = false;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.CornflowerBlue;
            sendButton.Location = new Point(223, 389);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(49, 31);
            sendButton.TabIndex = 11;
            sendButton.Click += sendButton_Click;
            sendButton.MouseEnter += sendButton_Enter;
            sendButton.MouseLeave += sendButton_MouseLeave;
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 431);
            Controls.Add(LengthError);
            Controls.Add(sendIcon);
            Controls.Add(sendButton);
            Controls.Add(roomIcon);
            Controls.Add(messagesPanel);
            Controls.Add(labelLine1);
            Controls.Add(lastSeen);
            Controls.Add(account_name);
            Controls.Add(pictureBox1);
            Controls.Add(message);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Messenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)sendIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ULControls.ULTextBox message;
        private PictureBox pictureBox1;
        private Label account_name;
        private LabelLine labelLine1;
        private FlowLayoutPanel messagesPanel;
        private RoundPictureBox roomIcon;
        private Label lastSeen;
        private PictureBox sendIcon;
        private RoundControl sendButton;
        private Label LengthError;
    }
}