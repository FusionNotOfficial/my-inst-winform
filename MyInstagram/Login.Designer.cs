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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            usernameText = new ULControls.ULTextBox();
            label3 = new Label();
            passwordText = new ULControls.ULTextBox();
            passwordCheck = new CheckBox();
            loginBtn = new ULControls.ULButton();
            Sign = new Label();
            passwordError = new Label();
            label4 = new Label();
            roundPictureBox1 = new RoundPictureBox();
            roundPictureBox2 = new RoundPictureBox();
            roundPictureBox3 = new RoundPictureBox();
            roundPictureBox4 = new RoundPictureBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // usernameText
            // 
            usernameText.BackColor = SystemColors.Window;
            usernameText.BorderColor = Color.MediumSlateBlue;
            usernameText.BorderFocusColor = Color.HotPink;
            usernameText.BorderSize = 2;
            resources.ApplyResources(usernameText, "usernameText");
            usernameText.ForeColor = Color.DimGray;
            usernameText.Multiline = false;
            usernameText.Name = "usernameText";
            usernameText.PasswordChar = false;
            usernameText.Texts = "";
            usernameText.UnderlinedStyle = true;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // passwordText
            // 
            passwordText.BackColor = SystemColors.Window;
            passwordText.BorderColor = Color.MediumSlateBlue;
            passwordText.BorderFocusColor = Color.HotPink;
            passwordText.BorderSize = 2;
            resources.ApplyResources(passwordText, "passwordText");
            passwordText.ForeColor = Color.DimGray;
            passwordText.Multiline = false;
            passwordText.Name = "passwordText";
            passwordText.PasswordChar = true;
            passwordText.Texts = "";
            passwordText.UnderlinedStyle = true;
            // 
            // passwordCheck
            // 
            resources.ApplyResources(passwordCheck, "passwordCheck");
            passwordCheck.ForeColor = SystemColors.ControlDarkDark;
            passwordCheck.Name = "passwordCheck";
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
            resources.ApplyResources(loginBtn, "loginBtn");
            loginBtn.ForeColor = Color.White;
            loginBtn.Name = "loginBtn";
            loginBtn.TextColor = Color.White;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // Sign
            // 
            resources.ApplyResources(Sign, "Sign");
            Sign.ForeColor = Color.MediumSlateBlue;
            Sign.Name = "Sign";
            Sign.Click += Sign_Click;
            // 
            // passwordError
            // 
            resources.ApplyResources(passwordError, "passwordError");
            passwordError.ForeColor = Color.Red;
            passwordError.Name = "passwordError";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Name = "label4";
            label4.Click += Sign_Click;
            // 
            // roundPictureBox1
            // 
            resources.ApplyResources(roundPictureBox1, "roundPictureBox1");
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.TabStop = false;
            // 
            // roundPictureBox2
            // 
            resources.ApplyResources(roundPictureBox2, "roundPictureBox2");
            roundPictureBox2.Name = "roundPictureBox2";
            roundPictureBox2.TabStop = false;
            roundPictureBox2.Click += roundPictureBox2_Click;
            // 
            // roundPictureBox3
            // 
            resources.ApplyResources(roundPictureBox3, "roundPictureBox3");
            roundPictureBox3.Name = "roundPictureBox3";
            roundPictureBox3.TabStop = false;
            // 
            // roundPictureBox4
            // 
            resources.ApplyResources(roundPictureBox4, "roundPictureBox4");
            roundPictureBox4.Name = "roundPictureBox4";
            roundPictureBox4.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 50;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(roundPictureBox3);
            Controls.Add(roundPictureBox4);
            Controls.Add(roundPictureBox2);
            Controls.Add(roundPictureBox1);
            Controls.Add(loginBtn);
            Controls.Add(passwordCheck);
            Controls.Add(passwordText);
            Controls.Add(passwordError);
            Controls.Add(label3);
            Controls.Add(usernameText);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(Sign);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox4).EndInit();
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
        private Label label4;
        private RoundPictureBox roundPictureBox1;
        private RoundPictureBox roundPictureBox2;
        private RoundPictureBox roundPictureBox3;
        private RoundPictureBox roundPictureBox4;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}