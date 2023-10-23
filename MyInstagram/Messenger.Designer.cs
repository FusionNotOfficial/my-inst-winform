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
            ulTextBox1 = new ULControls.ULTextBox();
            ulButton1 = new ULControls.ULButton();
            dataGridView1 = new DataGridView();
            ulButton2 = new ULControls.ULButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ulTextBox1
            // 
            ulTextBox1.BackColor = SystemColors.Window;
            ulTextBox1.BorderColor = Color.MediumSlateBlue;
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
            // ulButton1
            // 
            ulButton1.BackColor = Color.MediumSlateBlue;
            ulButton1.BackgroundColor = Color.MediumSlateBlue;
            ulButton1.BorderColor = Color.PaleVioletRed;
            ulButton1.BorderRadius = 10;
            ulButton1.BorderSize = 0;
            ulButton1.FlatAppearance.BorderSize = 0;
            ulButton1.FlatStyle = FlatStyle.Flat;
            ulButton1.ForeColor = Color.White;
            ulButton1.Location = new Point(234, 389);
            ulButton1.Name = "ulButton1";
            ulButton1.Size = new Size(50, 30);
            ulButton1.TabIndex = 1;
            ulButton1.Text = "send";
            ulButton1.TextColor = Color.White;
            ulButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 337);
            dataGridView1.TabIndex = 2;
            // 
            // ulButton2
            // 
            ulButton2.BackColor = Color.MediumSlateBlue;
            ulButton2.BackgroundColor = Color.MediumSlateBlue;
            ulButton2.BorderColor = Color.PaleVioletRed;
            ulButton2.BorderRadius = 30;
            ulButton2.BorderSize = 0;
            ulButton2.FlatAppearance.BorderSize = 0;
            ulButton2.FlatStyle = FlatStyle.Flat;
            ulButton2.ForeColor = Color.White;
            ulButton2.Location = new Point(3, 0);
            ulButton2.Name = "ulButton2";
            ulButton2.Size = new Size(70, 30);
            ulButton2.TabIndex = 3;
            ulButton2.Text = "back";
            ulButton2.TextColor = Color.White;
            ulButton2.UseVisualStyleBackColor = false;
            // 
            // Messenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 431);
            Controls.Add(ulButton2);
            Controls.Add(dataGridView1);
            Controls.Add(ulButton1);
            Controls.Add(ulTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Messenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ULControls.ULTextBox ulTextBox1;
        private ULControls.ULButton ulButton1;
        private DataGridView dataGridView1;
        private ULControls.ULButton ulButton2;
    }
}