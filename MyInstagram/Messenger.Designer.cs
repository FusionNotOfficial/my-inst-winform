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
            ulTextBox1 = new ULControls.ULTextBox();
            sendButton = new ULControls.ULButton();
            pictureBox1 = new PictureBox();
            account_name = new Label();
            labelLine1 = new LabelLine();
            messagesPanel = new FlowLayoutPanel();
            roomIcon = new RoundPictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomIcon).BeginInit();
            SuspendLayout();
            // 
            // ulTextBox1
            // 
            ulTextBox1.BackColor = SystemColors.Window;
            ulTextBox1.BorderColor = SystemColors.ControlDarkDark;
            ulTextBox1.BorderFocusColor = Color.HotPink;
            ulTextBox1.BorderSize = 2;
            ulTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ulTextBox1.ForeColor = Color.DimGray;
            ulTextBox1.Location = new Point(12, 389);
            ulTextBox1.Multiline = false;
            ulTextBox1.Name = "ulTextBox1";
            ulTextBox1.Padding = new Padding(7);
            ulTextBox1.PasswordChar = false;
            ulTextBox1.Size = new Size(228, 30);
            ulTextBox1.TabIndex = 0;
            ulTextBox1.Texts = "";
            ulTextBox1.UnderlinedStyle = true;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.DodgerBlue;
            sendButton.BackgroundColor = Color.DodgerBlue;
            sendButton.BorderColor = Color.PaleVioletRed;
            sendButton.BorderRadius = 30;
            sendButton.BorderSize = 0;
            sendButton.FlatAppearance.BorderSize = 0;
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.ForeColor = Color.White;
            sendButton.Location = new Point(222, 387);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(50, 32);
            sendButton.TabIndex = 1;
            sendButton.Text = "send";
            sendButton.TextColor = Color.White;
            sendButton.UseVisualStyleBackColor = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(79, 20);
            label1.Name = "label1";
            label1.Size = new Size(103, 16);
            label1.TabIndex = 6;
            label1.Text = "was active at 18:30";
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 431);
            Controls.Add(roomIcon);
            Controls.Add(messagesPanel);
            Controls.Add(labelLine1);
            Controls.Add(label1);
            Controls.Add(account_name);
            Controls.Add(pictureBox1);
            Controls.Add(sendButton);
            Controls.Add(ulTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Messenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ULControls.ULTextBox ulTextBox1;
        private ULControls.ULButton sendButton;
        private PictureBox pictureBox1;
        private Label account_name;
        private LabelLine labelLine1;
        private FlowLayoutPanel messagesPanel;
        private RoundPictureBox roomIcon;
        private Label label1;
    }
}