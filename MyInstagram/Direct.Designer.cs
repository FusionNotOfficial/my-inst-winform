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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Direct));
            flowLayoutPanel1 = new FlowLayoutPanel();
            account_name = new Label();
            messenger = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            searchLabel = new spLabel();
            pictureBox1 = new PictureBox();
            search = new TextBox();
            textBox1 = new TextBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)messenger).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(-1, 146);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(433, 575);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Click += button1_Click;
            // 
            // account_name
            // 
            account_name.AutoSize = true;
            account_name.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            account_name.ForeColor = SystemColors.ButtonHighlight;
            account_name.Location = new Point(57, 9);
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
            messenger.Size = new Size(50, 50);
            messenger.SizeMode = PictureBoxSizeMode.StretchImage;
            messenger.TabIndex = 2;
            messenger.TabStop = false;
            messenger.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(-1, 113);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 1;
            label1.Text = "Messages";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(searchLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(search);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(6, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(388, 51);
            panel1.TabIndex = 11;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Color = SystemColors.GrayText;
            searchLabel.Enabled = false;
            searchLabel.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchLabel.ForeColor = SystemColors.GrayText;
            searchLabel.Location = new Point(45, 13);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(64, 25);
            searchLabel.TabIndex = 0;
            searchLabel.Text = "Search";
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
            // search
            // 
            search.Anchor = AnchorStyles.None;
            search.BackColor = Color.FromArgb(64, 64, 64);
            search.BorderStyle = BorderStyle.None;
            search.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = Color.White;
            search.Location = new Point(44, 10);
            search.Multiline = true;
            search.Name = "search";
            search.Size = new Size(341, 33);
            search.TabIndex = 0;
            search.TextChanged += search_TextChanged;
            search.Enter += search_Enter;
            search.Leave += search_Leave;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(41, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 33);
            textBox1.TabIndex = 6;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 50;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Direct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(400, 718);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label account_name;
        private PictureBox messenger;
        private Label label1;
        private Panel panel1;
        private spLabel searchLabel;
        private PictureBox pictureBox1;
        public TextBox search;
        public TextBox textBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}