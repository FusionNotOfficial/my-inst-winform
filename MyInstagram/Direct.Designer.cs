namespace MyInstagram
{
    partial class Direct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Direct));
            flowLayoutPanel1 = new FlowLayoutPanel();
            account_name = new Label();
            messenger = new PictureBox();
            ulTextBox1 = new ULControls.ULTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)messenger).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(-1, 116);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(287, 316);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Click += button1_Click;
            // 
            // account_name
            // 
            account_name.AutoSize = true;
            account_name.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            account_name.ForeColor = SystemColors.ButtonHighlight;
            account_name.Location = new Point(53, 19);
            account_name.Name = "account_name";
            account_name.Size = new Size(154, 27);
            account_name.TabIndex = 1;
            account_name.Text = "account_name";
            // 
            // messenger
            // 
            messenger.Image = (Image)resources.GetObject("messenger.Image");
            messenger.Location = new Point(12, 9);
            messenger.Name = "messenger";
            messenger.Size = new Size(35, 37);
            messenger.SizeMode = PictureBoxSizeMode.StretchImage;
            messenger.TabIndex = 2;
            messenger.TabStop = false;
            messenger.Click += backButton_Click;
            // 
            // ulTextBox1
            // 
            ulTextBox1.BackColor = SystemColors.WindowFrame;
            ulTextBox1.BorderColor = Color.Transparent;
            ulTextBox1.BorderFocusColor = Color.HotPink;
            ulTextBox1.BorderSize = 0;
            ulTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ulTextBox1.ForeColor = Color.Silver;
            ulTextBox1.Location = new Point(-1, 60);
            ulTextBox1.Multiline = false;
            ulTextBox1.Name = "ulTextBox1";
            ulTextBox1.Padding = new Padding(7);
            ulTextBox1.PasswordChar = false;
            ulTextBox1.Size = new Size(287, 30);
            ulTextBox1.TabIndex = 3;
            ulTextBox1.Texts = "";
            ulTextBox1.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-1, 93);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Messages";
            // 
            // Direct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 431);
            Controls.Add(ulTextBox1);
            Controls.Add(messenger);
            Controls.Add(label1);
            Controls.Add(account_name);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Direct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Direct";
            ((System.ComponentModel.ISupportInitialize)messenger).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label account_name;
        private PictureBox messenger;
        private ULControls.ULTextBox ulTextBox1;
        private Label label1;
        private DirectMessage directMessage1;
    }
}