namespace MyInstagram
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            panel1 = new Panel();
            searchLabel = new spLabel();
            pictureBox1 = new PictureBox();
            search = new TextBox();
            AccountsPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(searchLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(search);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 51);
            panel1.TabIndex = 10;
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
            search.Location = new Point(40, 11);
            search.Multiline = true;
            search.Name = "search";
            search.Size = new Size(341, 33);
            search.TabIndex = 0;
            search.TextChanged += search_TextChanged;
            search.Enter += search_Enter;
            search.Leave += search_Leave;
            // 
            // AccountsPanel
            // 
            AccountsPanel.AutoScroll = true;
            AccountsPanel.BackColor = SystemColors.ActiveCaptionText;
            AccountsPanel.Location = new Point(0, 86);
            AccountsPanel.Margin = new Padding(4, 5, 4, 5);
            AccountsPanel.Name = "AccountsPanel";
            AccountsPanel.Size = new Size(433, 604);
            AccountsPanel.TabIndex = 8;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(406, 653);
            Controls.Add(panel1);
            Controls.Add(AccountsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchForm";
            Text = "SearchForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public TextBox search;
        private FlowLayoutPanel AccountsPanel;
        private spLabel searchLabel;
    }
}