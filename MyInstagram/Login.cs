using System.Data;

namespace MyInstagram
{
    public partial class Login : Form
    {
        Functions Con = new Functions();
        public int id;
        public static Login instanse;
        public Login()
        {
            InitializeComponent();
            instanse = this;
        }

        private void Sign_Click(object sender, EventArgs e)
        {
            Sign wind = new Sign();
            wind.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheck.Checked)
                passwordText.PasswordChar = false;
            else
                passwordText.PasswordChar = true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameText.Texts;
            string password = passwordText.Texts;
            if (password.Length < 8)
            {
                passwordError.Visible = true;
                passwordError.Text = "password must contain 8 or more symbols!";
            }
            else
            {
                passwordError.Visible = false;
                try
                {
                    string query = "SELECT * FROM USERS WHERE u_username = '" + username + "' AND u_password = '" + password + "'";
                    DataTable dt = new DataTable();
                    dt = Con.GetData(query);
                    foreach (DataRow row in dt.Rows)
                    {
                        id = Convert.ToInt32(row["u_id"]);
                    }
                    if (dt.Rows.Count > 0)
                    {
                        var hmpg = new Homepage();
                        hmpg.Show();
                        Hide();
                    }
                    else
                    {
                        passwordError.Text = "username or password are incorrect!";
                        passwordError.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("something went wrong.");
                }
                finally
                {
                    Con.Con.Close();
                }
            }
        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            id = 1;
            var hmpg = new Homepage();
            hmpg.Show();
            Hide();
        }
    }
}