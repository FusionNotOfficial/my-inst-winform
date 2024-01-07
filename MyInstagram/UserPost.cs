using System.Data;
using System.Windows.Forms;

namespace MyInstagram
{
    public partial class UserPost : Form
    {
        Functions Con;
        private string _callback;
        private int _id, _scroll;
        private int _postUserId;
        public static UserPost Current;
        public UserPost(string callback, int id, int scroll)
        {
            InitializeComponent();
            Con = new Functions();
            Current = this;
            _callback = callback;
            _id = id;
            _scroll = scroll;
            Account.Text = Con.GetString($"SELECT u_username FROM Users WHERE u_id = {_id}");

            UserItem();
        }
        public void UserItem()
        {
            PostsPanel.Controls.Clear();
            DataTable dt = Con.GetData($"SELECT p_user, p_id, p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id WHERE p_user = {_id}");
            if (dt.Rows.Count > 0)
            {
                List<Post> posts = new List<Post>();
                foreach (DataRow row in dt.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                    MemoryStream ms2 = new MemoryStream((byte[])row["p_picture"]);
                    posts.Add(new Post((int)row["p_id"], (int)row["p_user"], Image.FromStream(ms), (DateTime)row["p_date"], row["p_content"].ToString() ?? string.Empty, Convert.ToInt32(row["p_likes"]), Image.FromStream(ms2), row["u_username"].ToString()));
                    _postUserId = (int)row["p_user"];
                }
                posts = posts.OrderByDescending(o => o.PostDate).ToList();
                FeedPost postControls;
                foreach (Post post in posts)
                {
                    postControls = new FeedPost(post, _callback);
                    PostsPanel.Controls.Add(postControls);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            switch (_callback)
            {
                case "MyProfile":
                    Homepage.instance.LoadForm(new MyProfile());
                    break;
                case "UserAccount":
                    Homepage.instance.LoadForm(new UserAccount(_postUserId, _callback));
                    break;
            }
        }

        private void UserPost_Load(object sender, EventArgs e)
        {
            PostsPanel.VerticalScroll.Value = (_scroll * 589) - 589;
        }
    }
}
