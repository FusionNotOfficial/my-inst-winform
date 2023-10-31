using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    public partial class EditProfile : Form
    {
        private byte[] newImageArray;
        private int id;
        private string username, password, description;
        private bool isChanged = false;
        Functions Con;
        public EditProfile(int id)
        {
            InitializeComponent();
            Con = new Functions();
            this.id = id;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void profilePhoto_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Image newImage = Image.FromFile(fd.FileName);
                newImageRound.Image = newImage;
                MemoryStream ms = new MemoryStream();
                newImage.Save(ms, newImage.RawFormat);
                isChanged = true;
                newImageArray = ms.ToArray();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users WHERE u_username = '" + newUsername.Texts + "'", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0 && username != newUsername.Texts)
                {
                    usernameError.Visible = true;
                }
            }
            if (Password.Texts == password)
            {
                usernameError.Visible = false;
                passwordError.Visible = true;
                passwordError.Text = "You cannot change password for your current!";
            }
            else if (Password.Texts.Length < 8 && Password.Texts.Length > 0)
            {
                usernameError.Visible = false;
                passwordError.Visible = true;
                passwordError.Text = "Password must contain 8 or more symbols!";
            }
            else if (Description.Texts.Length > 40)
            {
                usernameError.Visible = false;
                passwordError.Visible = false;
                descriptionError.Visible = true;
            }
            else if (username == newUsername.Texts && Description.Texts == description && Password.Texts == password && isChanged == false)
            {
                NoChangesError.Visible = true;
                usernameError.Visible = false;
                passwordError.Visible = false;
                descriptionError.Visible = false;
            }
            else
            {
                string query = "UPDATE Users SET u_username = @username, u_password = @password, u_picture = @picture, u_description = @description WHERE u_id = '" + id + "'";
                SqlCommand smd = new SqlCommand(query, Con.Con);
                smd.Parameters.AddWithValue("username", newUsername.Texts);
                if(Password.Texts.Length == 0)
                    smd.Parameters.AddWithValue("password", password);
                else
                    smd.Parameters.AddWithValue("password", Password.Texts);
                smd.Parameters.AddWithValue("picture", newImageArray);
                smd.Parameters.AddWithValue("description", Description.Texts);
                Con.Con.Open();
                smd.ExecuteNonQuery();
                Con.Con.Close();
                MessageBox.Show("Changes saved!");
                Homepage hmp = new Homepage(id);
                hmp.Show();
                Close();
            }
        }

        private void EditProfile_Load(object sender, EventArgs e)
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
                        newImageRound.Image = Image.FromStream(ms);
                        newImageArray = (byte[])row["u_picture"];
                        newUsername.Texts = row["u_username"].ToString();
                        password = row["u_password"].ToString();
                        Description.Texts = row["u_description"].ToString();
                        username = newUsername.Texts;
                        description = Description.Texts;
                    }
                }
            }
            Con.Con.Close();
        }
    }
}
