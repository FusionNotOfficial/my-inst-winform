namespace MyInstagram
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            Sign wind = new Sign();
            wind.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheck.Checked)
            {
                passwordText.PasswordChar = false;
            }
            else
                passwordText.PasswordChar = true;
        }
    }
}