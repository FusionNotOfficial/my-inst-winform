using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    public partial class Homepage : Form
    {
        private int id;
        Functions Con;
        public Homepage()
        {
            InitializeComponent();
            Con = new Functions();
            account_select.BackColor = Color.Gray;
            id = Login.instanse.id;
            UserLoad();
        }
        private void UserLoad()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users WHERE u_id = '" + id + "'", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                        userImage.Image = Image.FromStream(ms);
                        usernameLabel.Text = row["u_username"].ToString();
                        DescriptionLabel.Text = row["u_description"].ToString();
                    }
                }
            }
            Con.Con.Close();
        }

        private void Direct_Click(object sender, EventArgs e)
        {
            Direct direct = new Direct();
            Hide();
            direct.Show();
        }

        private void account_select_Click(object sender, EventArgs e)
        {
            account_select.BackColor = Color.Gray;
            search_select.BackColor = Color.Black;
            home_select.BackColor = Color.Black;

            account_panel.Visible = true;
            home_panel.Visible = false;
        }
        private void search_select_Click(object sender, EventArgs e)
        {
            search_select.BackColor = Color.Gray;
            account_select.BackColor = Color.Black;
            home_select.BackColor = Color.Black;
        }
        private void home_select_Click(object sender, EventArgs e)
        {
            home_select.BackColor = Color.Gray;
            account_select.BackColor = Color.Black;
            search_select.BackColor = Color.Black;
        }

        private void Followers_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hui");
        }

        private void Following_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hui");
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            var ep = new EditProfile();
            ep.Show();
            Close();

        }
    }
}
