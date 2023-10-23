namespace MyInstagram
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            usernameText = new ULControls.ULTextBox();
            label3 = new Label();
            passwordText = new ULControls.ULTextBox();
            passwordCheck = new CheckBox();
            loginBtn = new ULControls.ULButton();
            Sign = new Label();
            passwordError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(110, 48);
            label1.Name = "label1";
            label1.Size = new Size(73, 29);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 111);
            label2.Name = "label2";
            label2.Size = new Size(66, 18);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // usernameText
            // 
            usernameText.BackColor = SystemColors.Window;
            usernameText.BorderColor = Color.MediumSlateBlue;
            usernameText.BorderFocusColor = Color.HotPink;
            usernameText.BorderSize = 2;
            usernameText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameText.ForeColor = Color.DimGray;
            usernameText.Location = new Point(31, 132);
            usernameText.Multiline = false;
            usernameText.Name = "usernameText";
            usernameText.Padding = new Padding(7);
            usernameText.PasswordChar = false;
            usernameText.Size = new Size(225, 30);
            usernameText.TabIndex = 1;
            usernameText.Texts = "";
            usernameText.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 171);
            label3.Name = "label3";
            label3.Size = new Size(61, 18);
            label3.TabIndex = 0;
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
            passwordText.Location = new Point(31, 192);
            passwordText.Multiline = false;
            passwordText.Name = "passwordText";
            passwordText.Padding = new Padding(7);
            passwordText.PasswordChar = true;
            passwordText.Size = new Size(225, 30);
            passwordText.TabIndex = 1;
            passwordText.Texts = "";
            passwordText.UnderlinedStyle = true;
            // 
            // passwordCheck
            // 
            passwordCheck.AutoSize = true;
            passwordCheck.Font = new Font("Verdana", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordCheck.ForeColor = SystemColors.ControlDarkDark;
            passwordCheck.Location = new Point(131, 228);
            passwordCheck.Name = "passwordCheck";
            passwordCheck.Size = new Size(125, 17);
            passwordCheck.TabIndex = 2;
            passwordCheck.Text = "show password";
            passwordCheck.UseVisualStyleBackColor = true;
            passwordCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.MediumSlateBlue;
            loginBtn.BackgroundColor = Color.MediumSlateBlue;
            loginBtn.BorderColor = Color.PaleVioletRed;
            loginBtn.BorderRadius = 40;
            loginBtn.BorderSize = 0;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(31, 271);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(225, 40);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.TextColor = Color.White;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Sign
            // 
            Sign.AutoSize = true;
            Sign.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Sign.ForeColor = SystemColors.ControlDarkDark;
            Sign.Location = new Point(110, 395);
            Sign.Name = "Sign";
            Sign.Size = new Size(58, 18);
            Sign.TabIndex = 0;
            Sign.Text = "SIGN UP";
            Sign.Click += Sign_Click;
            // 
            // passwordError
            // 
            passwordError.AutoSize = true;
            passwordError.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            passwordError.ForeColor = Color.Red;
            passwordError.Location = new Point(35, 242);
            passwordError.Name = "passwordError";
            passwordError.Size = new Size(0, 16);
            passwordError.TabIndex = 0;
            passwordError.Visible = false;
            // 
            // Login
            // 
            ClientSize = new Size(284, 431);
            Controls.Add(loginBtn);
            Controls.Add(passwordCheck);
            Controls.Add(passwordText);
            Controls.Add(passwordError);
            Controls.Add(label3);
            Controls.Add(usernameText);
            Controls.Add(label2);
            Controls.Add(Sign);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ULControls.ULTextBox usernameText;
        private Label label3;
        private ULControls.ULTextBox passwordText;
        private CheckBox passwordCheck;
        private ULControls.ULButton loginBtn;
        private Label Sign;
        private Label passwordError;
    }
}