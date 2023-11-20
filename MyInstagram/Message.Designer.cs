namespace MyInstagram
{
    partial class Message
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            date = new Label();
            roundControl1 = new RoundControl();
            content = new Label();
            SuspendLayout();
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.RoyalBlue;
            date.FlatStyle = FlatStyle.System;
            date.ForeColor = SystemColors.AppWorkspace;
            date.Location = new Point(152, 16);
            date.Name = "date";
            date.Size = new Size(34, 15);
            date.TabIndex = 1;
            date.Text = "20:33";
            // 
            // roundControl1
            // 
            roundControl1.BackColor = Color.RoyalBlue;
            roundControl1.ForeColor = SystemColors.ControlLightLight;
            roundControl1.Location = new Point(0, 3);
            roundControl1.Name = "roundControl1";
            roundControl1.Size = new Size(199, 32);
            roundControl1.TabIndex = 0;
            // 
            // content
            // 
            content.AutoSize = true;
            content.BackColor = Color.RoyalBlue;
            content.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            content.ForeColor = SystemColors.ButtonHighlight;
            content.Location = new Point(4, 9);
            content.MaximumSize = new Size(180, 50);
            content.Name = "content";
            content.Size = new Size(178, 36);
            content.TabIndex = 2;
            content.Text = "Messaaaaaaфффффaaaaaaaaaa";
            // 
            // Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(date);
            Controls.Add(content);
            Controls.Add(roundControl1);
            Name = "Message";
            Size = new Size(203, 38);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public RoundControl roundControl1;
        public Label date;
        public Label content;
    }
}
