using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (usernameText.Texts == "" || passwordText.Texts == "" || emailText.Texts == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string username = usernameText.Texts;
                    string password = passwordText.Texts;
                    string email = emailText.Texts;
                    string Query = "INSERT INTO Users values('{0}', '{1}', '{2}')";
                    Query = string.Format(Query, username, password, email);
                    Con.SetData(Query);
                    MessageBox.Show("Account Created");
                    Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
