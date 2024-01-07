namespace MyInstagram
{
    partial class UserPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPost));
            PostsPanel = new FlowLayoutPanel();
            labelLine1 = new LabelLine();
            Account = new Label();
            backButton = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PostsPanel
            // 
            PostsPanel.AccessibleRole = AccessibleRole.None;
            PostsPanel.AutoScroll = true;
            PostsPanel.Location = new Point(-2, 80);
            PostsPanel.Margin = new Padding(0);
            PostsPanel.Name = "PostsPanel";
            PostsPanel.Size = new Size(439, 604);
            PostsPanel.TabIndex = 18;
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Location = new Point(-14, 63);
            labelLine1.Margin = new Padding(4, 0, 4, 0);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(414, 2);
            labelLine1.TabIndex = 17;
            labelLine1.Text = "labelLine1";
            // 
            // Account
            // 
            Account.Dock = DockStyle.Top;
            Account.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Account.ForeColor = SystemColors.GrayText;
            Account.Location = new Point(0, 0);
            Account.Margin = new Padding(10, 10, 10, 0);
            Account.Name = "Account";
            Account.Size = new Size(406, 40);
            Account.TabIndex = 19;
            Account.Text = "account_name";
            Account.TextAlign = ContentAlignment.BottomCenter;
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(13, 5);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(53, 55);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 20;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Account);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 77);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("UD Digi Kyokasho NK-B", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 40);
            label1.Name = "label1";
            label1.Size = new Size(406, 37);
            label1.TabIndex = 21;
            label1.Text = "Posts";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // UserPost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(406, 653);
            Controls.Add(PostsPanel);
            Controls.Add(panel1);
            Controls.Add(labelLine1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserPost";
            Text = "UserPost";
            Load += UserPost_Load;
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public FlowLayoutPanel PostsPanel;
        private LabelLine labelLine1;
        private Label Account;
        private PictureBox backButton;
        private Panel panel1;
        private Label label1;
    }
}