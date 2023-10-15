namespace MyInstagram
{
    partial class Sign
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
            label1 = new Label();
            usernameText = new ULControls.ULTextBox();
            label2 = new Label();
            label3 = new Label();
            passwordText = new ULControls.ULTextBox();
            label4 = new Label();
            ConpassText = new ULControls.ULTextBox();
            label5 = new Label();
            emailText = new ULControls.ULTextBox();
            CreateBtn = new ULControls.ULButton();
            backBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 40);
            label1.Name = "label1";
            label1.Size = new Size(84, 27);
            label1.TabIndex = 1;
            label1.Text = "Sign Up";
            // 
            // usernameText
            // 
            usernameText.BackColor = SystemColors.Window;
            usernameText.BorderColor = Color.MediumSlateBlue;
            usernameText.BorderFocusColor = Color.HotPink;
            usernameText.BorderSize = 2;
            usernameText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameText.ForeColor = Color.DimGray;
            usernameText.Location = new Point(29, 94);
            usernameText.Multiline = false;
            usernameText.Name = "usernameText";
            usernameText.Padding = new Padding(7);
            usernameText.PasswordChar = false;
            usernameText.Size = new Size(225, 30);
            usernameText.TabIndex = 3;
            usernameText.Texts = "";
            usernameText.UnderlinedStyle = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 73);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 135);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // passwordText
            // 
            passwordText.BackColor = SystemColors.Window;
            passwordText.BorderColor = Color.MediumSlateBlue;
            passwordText.BorderFocusColor = Color.HotPink;
            passwordText.BorderSize = 2;
            passwordText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordText.ForeColor = Color.DimGray;
            passwordText.Location = new Point(29, 156);
            passwordText.Multiline = false;
            passwordText.Name = "passwordText";
            passwordText.Padding = new Padding(7);
            passwordText.PasswordChar = false;
            passwordText.Size = new Size(225, 30);
            passwordText.TabIndex = 3;
            passwordText.Texts = "";
            passwordText.UnderlinedStyle = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 200);
            label4.Name = "label4";
            label4.Size = new Size(113, 18);
            label4.TabIndex = 2;
            label4.Text = "Confirm password";
            // 
            // ConpassText
            // 
            ConpassText.BackColor = SystemColors.Window;
            ConpassText.BorderColor = Color.MediumSlateBlue;
            ConpassText.BorderFocusColor = Color.HotPink;
            ConpassText.BorderSize = 2;
            ConpassText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConpassText.ForeColor = Color.DimGray;
            ConpassText.Location = new Point(29, 221);
            ConpassText.Multiline = false;
            ConpassText.Name = "ConpassText";
            ConpassText.Padding = new Padding(7);
            ConpassText.PasswordChar = false;
            ConpassText.Size = new Size(225, 30);
            ConpassText.TabIndex = 3;
            ConpassText.Texts = "";
            ConpassText.UnderlinedStyle = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 267);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 2;
            label5.Text = "Email address";
            // 
            // emailText
            // 
            emailText.BackColor = SystemColors.Window;
            emailText.BorderColor = Color.MediumSlateBlue;
            emailText.BorderFocusColor = Color.HotPink;
            emailText.BorderSize = 2;
            emailText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailText.ForeColor = Color.DimGray;
            emailText.Location = new Point(29, 288);
            emailText.Multiline = false;
            emailText.Name = "emailText";
            emailText.Padding = new Padding(7);
            emailText.PasswordChar = false;
            emailText.Size = new Size(225, 30);
            emailText.TabIndex = 3;
            emailText.Texts = "";
            emailText.UnderlinedStyle = true;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.MediumSlateBlue;
            CreateBtn.BackgroundColor = Color.MediumSlateBlue;
            CreateBtn.BorderColor = Color.PaleVioletRed;
            CreateBtn.BorderRadius = 40;
            CreateBtn.BorderSize = 0;
            CreateBtn.FlatAppearance.BorderSize = 0;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.ForeColor = Color.White;
            CreateBtn.Location = new Point(29, 355);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(225, 40);
            CreateBtn.TabIndex = 4;
            CreateBtn.Text = "Create Account";
            CreateBtn.TextColor = Color.White;
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.BackgroundImageLayout = ImageLayout.None;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Location = new Point(245, 12);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(27, 23);
            backBtn.TabIndex = 5;
            backBtn.Text = "X";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // Sign
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(284, 432);
            Controls.Add(backBtn);
            Controls.Add(CreateBtn);
            Controls.Add(emailText);
            Controls.Add(label5);
            Controls.Add(ConpassText);
            Controls.Add(label4);
            Controls.Add(passwordText);
            Controls.Add(label3);
            Controls.Add(usernameText);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Sign";
            Text = "Sign";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ULControls.ULTextBox usernameText;
        private Label label2;
        private Label label3;
        private ULControls.ULTextBox passwordText;
        private Label label4;
        private ULControls.ULTextBox ConpassText;
        private Label label5;
        private ULControls.ULTextBox emailText;
        private ULControls.ULButton CreateBtn;
        private Button backBtn;
    }
}