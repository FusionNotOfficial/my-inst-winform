using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                    string query = "INSERT INTO Users values('{0}', '{1}', '{2}')";
                    query = string.Format(query, username, password, email);
                    Con.SetData(query);
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    Close();
                }
                catch (Exception Ex) { MessageBox.Show(Ex.Message); }
                finally { Close(); }
            }
        }
    }
}
