namespace MyInstagram
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            panel1 = new Panel();
            account_select = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            search_select = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            home_select = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            labelLine1 = new LabelLine();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            account_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            search_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            home_select.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(account_select);
            panel1.Controls.Add(search_select);
            panel1.Controls.Add(home_select);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 658);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 60);
            panel1.TabIndex = 1;
            // 
            // account_select
            // 
            account_select.Controls.Add(label2);
            account_select.Controls.Add(pictureBox1);
            account_select.Location = new Point(271, 0);
            account_select.Margin = new Padding(4, 5, 4, 5);
            account_select.Name = "account_select";
            account_select.Size = new Size(134, 67);
            account_select.TabIndex = 0;
            account_select.Click += account_select_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1, -2);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1, 68);
            label2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 10);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += account_select_Click;
            // 
            // search_select
            // 
            search_select.Controls.Add(label1);
            search_select.Controls.Add(pictureBox3);
            search_select.Controls.Add(panel6);
            search_select.Location = new Point(139, 0);
            search_select.Margin = new Padding(4, 5, 4, 5);
            search_select.Name = "search_select";
            search_select.Size = new Size(134, 67);
            search_select.TabIndex = 0;
            search_select.Click += search_select_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1, 68);
            label1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(47, 13);
            pictureBox3.Margin = new Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += search_select_Click;
            // 
            // panel6
            // 
            panel6.Location = new Point(139, 0);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(134, 67);
            panel6.TabIndex = 0;
            // 
            // home_select
            // 
            home_select.Controls.Add(pictureBox2);
            home_select.Controls.Add(panel4);
            home_select.Location = new Point(0, 0);
            home_select.Margin = new Padding(4, 5, 4, 5);
            home_select.Name = "home_select";
            home_select.Size = new Size(139, 67);
            home_select.TabIndex = 0;
            home_select.Click += home_select_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(47, 8);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += home_select_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(139, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 67);
            panel4.TabIndex = 0;
            // 
            // labelLine1
            // 
            labelLine1.BorderStyle = BorderStyle.Fixed3D;
            labelLine1.Dock = DockStyle.Bottom;
            labelLine1.Location = new Point(0, 656);
            labelLine1.Margin = new Padding(4, 0, 4, 0);
            labelLine1.Name = "labelLine1";
            labelLine1.Size = new Size(400, 2);
            labelLine1.TabIndex = 8;
            labelLine1.Text = "labelLine1";
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(400, 718);
            mainPanel.TabIndex = 9;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(400, 718);
            Controls.Add(labelLine1);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            panel1.ResumeLayout(false);
            account_select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            search_select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            home_select.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel search_select;
        private Panel panel6;
        private Panel home_select;
        private Panel panel4;
        private Panel account_select;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private LabelLine labelLine1;
        private Panel mainPanel;
    }
}