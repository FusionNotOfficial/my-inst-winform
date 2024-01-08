using System.Data;

namespace MyInstagram
{
    public partial class MyProfile : Form
    {
        Functions Con;
        public int postsCount;
        public static MyProfile Current;
        public MyProfile()
        {
            InitializeComponent();
            Con = new Functions();
            Current = this;
            int followers = Con.GetCount($"SELECT COUNT(f_followingId) FROM Followers WHERE f_followingId = {Homepage.id}");
            Followers.Text = followers.ToString();
            int following = Con.GetCount($"SELECT COUNT(f_userId) FROM Followers WHERE f_userId = {Homepage.id}");
            Following.Text = following.ToString();
            UserLoad();
            UserItem();
        }
        private void UserLoad()
        {
            DataTable dt = Con.GetData($"SELECT u_username, u_picture, u_description FROM Users WHERE u_id = {Homepage.id}");
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
        public void UserItem()
        {
            PostsPannel.Controls.Clear();

            DataTable dt = Con.GetData($"SELECT p_picture, p_date FROM Post WHERE p_user = {Homepage.id}");
            if (dt.Rows.Count > 0)
            {
                int iterator = 0;
                List<Post> posts = new List<Post>();
                foreach (DataRow row in dt.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])row["p_picture"]);
                    Image userImage = Image.FromStream(ms);
                    posts.Add(new Post(userImage, (DateTime)row["p_date"]));
                }
                postsCount = posts.Count;
                posts = posts.OrderByDescending(o => o.PostDate).ToList();
                PostUserControl[] postControls = new PostUserControl[posts.Count];

                foreach (Post post in posts)
                {
                    iterator++;
                    postControls[0] = new PostUserControl();
                    postControls[0].ImageSource = post.PostImage;
                    postControls[0].Click += new EventHandler(button1_Click);
                    postControls[0]._id = iterator;
                    PostsPannel.Controls.Add(postControls[0]);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var instance = sender as PostUserControl;
            Homepage.instance.LoadForm(new UserPost("MyProfile", Homepage.id, instance._id));
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
