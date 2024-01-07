namespace MyInstagram
{
    partial class FollowForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowForm));
            backButton = new PictureBox();
            Account = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            search = new TextBox();
            followers = new Label();
            following = new Label();
            accounts = new FlowLayoutPanel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)backButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.Location = new Point(1, 2);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(53, 55);
            backButton.SizeMode = PictureBoxSizeMode.StretchImage;
            backButton.TabIndex = 4;
            backButton.TabStop = false;
            backButton.Click += backButton_Click;
            // 
            // Account
            // 
            Account.Dock = DockStyle.Top;
            Account.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Account.ForeColor = SystemColors.ButtonFace;
            Account.Location = new Point(0, 0);
            Account.Margin = new Padding(4, 0, 4, 0);
            Account.Name = "Account";
            Account.Size = new Size(406, 57);
            Account.TabIndex = 3;
            Account.Text = "account_name";
            Account.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(search);
            panel1.Location = new Point(1, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 51);
            panel1.TabIndex = 6;
            // 
            // search
            // 
            search.Anchor = AnchorStyles.None;
            search.BackColor = Color.FromArgb(64, 64, 64);
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = SystemColors.GrayText;
            search.Location = new Point(38, 10);
            search.Multiline = true;
            search.Name = "search";
            search.Size = new Size(372, 33);
            search.TabIndex = 0;
            search.Text = "Search";
            search.TextChanged += search_TextChanged;
            search.Enter += search_Enter;
            search.Leave += search_Leave;
            // 
            // followers
            // 
            followers.Dock = DockStyle.Fill;
            followers.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            followers.ForeColor = SystemColors.ButtonFace;
            followers.Location = new Point(0, 0);
            followers.Margin = new Padding(4, 0, 4, 0);
            followers.Name = "followers";
            followers.Size = new Size(173, 41);
            followers.TabIndex = 3;
            followers.Text = "0 followers";
            followers.TextAlign = ContentAlignment.MiddleCenter;
            followers.Click += followers_Click;
            // 
            // following
            // 
            following.Dock = DockStyle.Fill;
            following.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            following.ForeColor = SystemColors.ControlDarkDark;
            following.Location = new Point(0, 0);
            following.Margin = new Padding(4, 0, 4, 0);
            following.Name = "following";
            following.Size = new Size(155, 41);
            following.TabIndex = 3;
            following.Text = "3 following";
            following.TextAlign = ContentAlignment.MiddleCenter;
            following.Click += following_Click;
            // 
            // accounts
            // 
            accounts.AutoScroll = true;
            accounts.Location = new Point(1, 147);
            accounts.Name = "accounts";
            accounts.Size = new Size(441, 505);
            accounts.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(followers);
            panel2.Location = new Point(39, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 41);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Controls.Add(following);
            panel3.Location = new Point(210, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 41);
            panel3.TabIndex = 9;
            // 
            // FollowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(406, 653);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(accounts);
            Controls.Add(panel1);
            Controls.Add(backButton);
            Controls.Add(Account);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FollowForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FollowForm";
            ((System.ComponentModel.ISupportInitialize)backButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox backButton;
        private Label Account;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox search;
        private Label followers;
        private Label following;
        private FlowLayoutPanel accounts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel2;
        private Panel panel3;
    }
}