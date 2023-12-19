using System.Data;

namespace MyInstagram
{
    public partial class Feed : Form
    {
        Functions Con;
        public Feed()
        {
            InitializeComponent();
            Con = new Functions();
            UserItem();
        }
        public void UserItem()
        {
            FeedPanel.Controls.Clear();
            DataTable dt = Con.GetData("SELECT p_id, p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id");
            if (dt.Rows.Count > 0)
            {
                List<Post> posts = new List<Post>();
                foreach (DataRow row in dt.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                    MemoryStream ms2 = new MemoryStream((byte[])row["p_picture"]);
                    posts.Add(new Post(Image.FromStream(ms), (DateTime)row["p_date"], row["p_content"].ToString() ?? string.Empty, Convert.ToInt32(row["p_likes"]), Image.FromStream(ms2), row["u_username"].ToString()));
                }
                posts = posts.OrderByDescending(o => o.PostDate).ToList();
                FeedPost postControls;
                foreach (Post post in posts)
                {
                    postControls = new FeedPost(post);

                    FeedPanel.Controls.Add(postControls);

                    //postControls[i].Click += new EventHandler(button1_Click);
                }
            }
            Con.Con.Close();
        }
    }
}
