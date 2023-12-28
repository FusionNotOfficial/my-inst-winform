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
            flowLayoutPanel1.Location = new Point(-1, 166);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(410, 554);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Click += button1_Click;
            // 
            // account_name
            // 
            account_name.AutoSize = true;
            account_name.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            account_name.ForeColor = SystemColors.ButtonHighlight;
            account_name.Location = new Point(57, 19);
            account_name.Margin = new Padding(4, 0, 4, 0);
            account_name.Name = "account_name";
            account_name.Size = new Size(236, 40);
            account_name.TabIndex = 1;
            account_name.Text = "account_name";
            // 
            // messenger
            // 
            messenger.Image = (Image)resources.GetObject("messenger.Image");
            messenger.Location = new Point(-1, 1);
            messenger.Margin = new Padding(4, 5, 4, 5);
            messenger.Name = "messenger";
            messenger.Size = new Size(50, 58);
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
            ulTextBox1.Location = new Point(-1, 69);
            ulTextBox1.Margin = new Padding(4, 5, 4, 5);
            ulTextBox1.Multiline = false;
            ulTextBox1.Name = "ulTextBox1";
            ulTextBox1.Padding = new Padding(10, 12, 10, 12);
            ulTextBox1.PasswordChar = false;
            ulTextBox1.Size = new Size(410, 50);
            ulTextBox1.TabIndex = 3;
            ulTextBox1.Texts = "";
            ulTextBox1.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-1, 133);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 1;
            label1.Text = "Messages";
            // 
            // Direct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(400, 718);
            Controls.Add(ulTextBox1);
            Controls.Add(messenger);
            Controls.Add(label1);
            Controls.Add(account_name);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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