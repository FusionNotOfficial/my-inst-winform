using System.Data;

namespace MyInstagram
{
    public partial class Feed : Form
    {
        Functions Con;
        static Feed? Instance;
        public Feed()
        {
            InitializeComponent();
            Instance = this;
            Con = new Functions();
            usernameLabel.Text = Con.GetString($"SELECT u_username FROM Users WHERE u_id = {Homepage.id}");
            UserItem();
        }
        public void UserItem()
        {
            UserContext();
        }
        public void UserItem(bool scrollBarred)
        {
            var scrollBarPos = FeedPanel.VerticalScroll.Value;
            UserContext();
            FeedPanel.VerticalScroll.Value = scrollBarPos;
        }
        private void UserContext()
        {
            FeedPanel.Controls.Clear();
            DataTable dt = Con.GetData("SELECT p_user, p_id, p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id");
            if (dt.Rows.Count > 0)
            {
                List<Post> posts = new List<Post>();
                foreach (DataRow row in dt.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                    MemoryStream ms2 = new MemoryStream((byte[])row["p_picture"]);
                    posts.Add(new Post(Instance, (int)row["p_id"], (int)row["p_user"], Image.FromStream(ms), (DateTime)row["p_date"], row["p_content"].ToString() ?? string.Empty, Convert.ToInt32(row["p_likes"]), Image.FromStream(ms2), row["u_username"].ToString()));
                }
                posts = posts.OrderByDescending(o => o.PostDate).ToList();
                FeedPost postControls;
                foreach (Post post in posts)
                {
                    postControls = new FeedPost(post, "Post");

                    FeedPanel.Controls.Add(postControls);
                }
            }
        }
        private void Direct_Click(object sender, EventArgs e)
        {
            Direct direct = new Direct();
            Hide();
            direct.Show();
        }
        public void Reload()
        {
            UserItem();
        }
    }
}
