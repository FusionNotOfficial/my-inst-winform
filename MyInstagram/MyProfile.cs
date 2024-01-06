using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    public partial class MyProfile : Form
    {
        Functions Con;
        public MyProfile()
        {
            InitializeComponent();
            Con = new Functions();
            int followers = Con.GetCount($"SELECT COUNT(f_followingId) FROM Followers WHERE f_followingId = {Homepage.id}");
            Followers.Text = followers.ToString();
            int following = Con.GetCount($"SELECT COUNT(f_userId) FROM Followers WHERE f_userId = {Homepage.id}");
            Following.Text = following.ToString();
            UserLoad();
            UserItem();
        }
        private void UserLoad()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users WHERE u_id = '" + Homepage.id + "'", Con.Con);
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
        public void UserItem()
        {
            PostsPannel.Controls.Clear();

            DataTable dt = Con.GetData($"SELECT p_picture, p_date FROM Post WHERE p_user = {Homepage.id}");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    List<Post> posts = new List<Post>();
                    foreach (DataRow row in dt.Rows)
                    {
                        MemoryStream ms = new MemoryStream((byte[])row["p_picture"]);
                        Image userImage = Image.FromStream(ms);
                        posts.Add(new Post(userImage, (DateTime)row["p_date"]));
                    }
                    posts = posts.OrderByDescending(o => o.PostDate).ToList();
                    PostUserControl[] postControls = new PostUserControl[posts.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (Post post in posts)
                        {
                            postControls[i] = new PostUserControl();
                            postControls[i].ImageSource = post.PostImage;

                            PostsPannel.Controls.Add(postControls[i]);

                            //postControls[i].Click += new EventHandler(button1_Click);
                        }
                    }
                }
            }
            Con.Con.Close();
        }
        private void Followers_Button_Click(object sender, EventArgs e)
        {
            Homepage.instance.LoadForm(new FollowForm(true, "MyProfile", 0, Homepage.id));
        }

        private void Following_Button_Click(object sender, EventArgs e)
        {
            Homepage.instance.LoadForm(new FollowForm(false, "MyProfile", 0, Homepage.id));
        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            var ep = new EditProfile();
            ep.Show();
            Close();
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            CreatePost cp = new CreatePost();
            this.Hide();
            cp.Show();
        }

        private void Direct_Click(object sender, EventArgs e)
        {
            Direct direct = new Direct();
            Hide();
            direct.Show();
        }
    }
}
