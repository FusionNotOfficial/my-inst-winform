using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MyInstagram
{
    public partial class Sign : Form
    {
        Functions Con;
        public Sign()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Regex emailValidator = new Regex(@"^[-\w.]+@([A-Za-z0-9][-A-Za-z0-9]+\.)+(ru|com)$");

            string username = usernameText.Texts;
            string password = passwordText.Texts;
            string conpass = ConpassText.Texts;
            string email = emailText.Texts;

            string usersQuery = "SELECT * FROM USERS WHERE u_username = '" + username + "'";
            DataTable dt = new DataTable();
            dt = Con.GetData(usersQuery);

            if (dt.Rows.Count > 0)
            {
                usernameError.Visible = true;
                usernameError.Text = "account with that username already exists!";
            }
            else if (password.Length < 8)
            {
                passwordError.Visible = true;
                usernameError.Visible = false;
                passwordError.Text = "password must contain 8 or more symbols!";
            }
            else if (password != conpass)
            {
                conpassError.Visible = true;
                passwordError.Visible = false;
                usernameError.Visible = false;
                conpassError.Text = "passwords are not matched!";
            }
            else if (!emailValidator.IsMatch(emailText.Texts))
            {
                emailError.Visible = true;
                passwordError.Visible = false;
                conpassError.Visible = false;
                usernameError.Visible = false;
                emailError.Text = "please enter email correctly!";
            }
            else
            {
                conpassError.Visible = false;
                passwordError.Visible = false;
                emailError.Visible = false;
                usernameError.Visible = false;
                try
                {
                    string query = "INSERT INTO Users(u_username, u_password, u_email, u_picture, u_description) VALUES (@username, @password, @email, @picture, @description)";
                    SqlCommand smd = new SqlCommand(query, Con.Con);
                    MemoryStream me = new MemoryStream();
                    Image.FromFile(@"..\default.jpg").Save(me, Image.FromFile(@"..\default.jpg").RawFormat);
                    smd.Parameters.AddWithValue("username", username);
                    smd.Parameters.AddWithValue("password", password);
                    smd.Parameters.AddWithValue("email", email);
                    smd.Parameters.AddWithValue("picture", me.ToArray());
                    smd.Parameters.AddWithValue("description", string.Empty);
                    Con.Con.Open();
                    smd.ExecuteNonQuery();
                    Con.Con.Close();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
                finally { Close(); }
            }
        }
    }
}
