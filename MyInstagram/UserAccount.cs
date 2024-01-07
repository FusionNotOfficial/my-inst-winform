using System.Data;

namespace MyInstagram
{
    public partial class UserAccount : Form
    {
        Functions Con;
        private int _followerId;
        private int postsCount;
        string _caller;
        public UserAccount(int FollowerId, string caller)
        {
            InitializeComponent();
            Con = new Functions();
            _followerId = FollowerId;
            _caller = caller;
            DataTable dt = Con.GetData($"SELECT u_username, u_picture, u_description FROM Users WHERE u_id = {_followerId}");
            foreach (DataRow row in dt.Rows)
            {
                usernameLabel.Text = row["u_username"].ToString();
                MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                userImage.Image = Image.FromStream(ms);
                DescriptionLabel.Text = row["u_description"].ToString();
            }
            int followers = Con.GetCount($"SELECT COUNT(f_followingId) FROM Followers WHERE f_followingId = {_followerId}");
            Followers.Text = followers.ToString();
            int following = Con.GetCount($"SELECT COUNT(f_userId) FROM Followers WHERE f_userId = {_followerId}");
            Following.Text = following.ToString();
            if (Con.Exists($"SELECT COUNT(f_id) FROM Followers WHERE f_userId = {Homepage.id} AND f_followingId = {_followerId}"))
            {
                followButton.Text = "Following";
                followButton.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                followButton.Text = "Follow";
                followButton.BackColor = SystemColors.Highlight;
            }
            UserItem();
        }
        private void UserItem()
        {
            PostsPanel.Controls.Clear();

            DataTable dt = Con.GetData($"SELECT p_picture, p_date FROM Post WHERE p_user = {_followerId}");
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
                    PostsPanel.Controls.Add(postControls[0]);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var instance = sender as PostUserControl;
            Homepage.instance.LoadForm(new UserPost("UserAccount", _followerId, instance._id));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            switch (_caller)
            {
                case "Follower":
                    Homepage.instance.LoadForm(new FollowForm(true, "MyProfile", _followerId, Homepage.id));
                    break;
                case "Following":
                    Homepage.instance.LoadForm(new FollowForm(false, "MyProfile", _followerId, Homepage.id));
                    break;
                case "Messenger":
                    Homepage.instance.LoadForm(new Direct());
                    break;
                case "Post":
                    Homepage.instance.LoadForm(new Feed());
                    break;
                case "Search":
                    Homepage.instance.LoadForm(new SearchForm());
                    break;
                case "UserAccount":
                    Homepage.instance.LoadForm(new MyProfile());
                    break;
            }
        }

        private void MessageButton_Click(object sender, EventArgs e)
        {
            var dt = Con.GetData($"SELECT r_id FROM Rooms WHERE sender = {Homepage.id} AND reciever = {_followerId}");
            int roomId = 0;
            if (dt.Rows.Count < 1)
            {
                Con.SetData($"INSERT INTO Rooms(sender, reciever) VALUES({Homepage.id}, {_followerId})");
                dt = Con.GetData($"SELECT r_id FROM Rooms WHERE sender = {Homepage.id} AND reciever = {_followerId}");
            }
            foreach (DataRow row in dt.Rows)
                roomId = (int)row["r_id"];
            var mess = new Messenger(roomId, Homepage.id, _followerId);
            mess.Show();
            this.Close();
        }

        private void Followers_Click(object sender, EventArgs e)
        {
            Homepage.instance.LoadForm(new FollowForm(true, "", _followerId, _followerId));
        }

        private void Following_Click(object sender, EventArgs e)
        {
            Homepage.instance.LoadForm(new FollowForm(false, "", _followerId, _followerId));
        }

        private void followButton_Click(object sender, EventArgs e)
        {
            if (followButton.Text == "Following")
            {
                followButton.BackColor = SystemColors.Highlight;
                followButton.Text = "Follow";
                Con.SetData($"DELETE FROM Followers WHERE f_userId = {Homepage.id} AND f_followingId = {_followerId}");
                int temp = Convert.ToInt32(Followers.Text);
                temp--;
                Followers.Text = temp.ToString();
            }
            else
            {
                int temp = Convert.ToInt32(Followers.Text);
                temp++;
                Followers.Text = temp.ToString();
                followButton.BackColor = Color.FromArgb(64, 64, 64);
                followButton.Text = "Following";
                Con.SetData($"INSERT INTO Followers(f_userId, f_followingId) VALUES({Homepage.id}, {_followerId})");
            }
        }
    }
}
