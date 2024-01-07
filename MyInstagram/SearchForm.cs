using System.Data;

namespace MyInstagram
{
    public partial class SearchForm : Form
    {
        Functions Con;
        public SearchForm()
        {
            InitializeComponent();
            Con = new Functions();

            search.Text = Homepage.instance.searchQuery;
            if (search.Text.Length > 0)
            {
                searchLabel.Visible = false;
                UserItem(true);
            }
            else UserItem(false);
        }
        public void UserItem(bool filter)
        {
            AccountsPanel.Controls.Clear();

            DataTable dt = Con.GetData($"SELECT u_id, u_username, u_picture FROM Users WHERE NOT u_id = {Homepage.id}");
            if (dt.Rows.Count > 0)
            {
                var users = new List<Follower>();
                // adding every user in list to sort
                foreach (DataRow dr in dt.Rows)
                    users.Add(new Follower((int)dr["u_id"], dr["u_username"].ToString()));
                // using search bar
                if (filter && search.Text.Length > 0)
                    users.RemoveAll(user => !user.Name.StartsWith(search.Text));
                var fc = new FollowControl[users.Count];

                foreach (Follower user in users)
                {
                    fc[0] = new FollowControl();
                    fc[0].picture.Image = user.Image;
                    fc[0].account_name.Text = user.Name;
                    fc[0].FollowerId = user.Id;
                    fc[0].remove.Size = new Size(95, 36);
                    fc[0].remove.Location = new Point(fc[0].remove.Location.X - 15, fc[0].remove.Location.Y);
                    if (Con.Exists($"SELECT COUNT(f_id) FROM Followers WHERE f_followingId = {fc[0].FollowerId} AND f_userId = {Homepage.id}"))
                    {
                        fc[0].remove.BackColor = Color.FromArgb(64, 64, 64);
                        fc[0].remove.Text = "Following";
                    }
                    else
                    {
                        fc[0].remove.BackColor = SystemColors.Highlight;
                        fc[0].remove.Text = "Follow";
                    }

                    AccountsPanel.Controls.Add(fc[0]);
                    if (filter && search.Text.Length > 0)
                        AddPosts(user.Name);
                }
            }
        }
        protected void search_SetText()
        {
            searchLabel.Visible = true;
        }
        private void search_Enter(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
        }
        private void search_Leave(object sender, EventArgs e)
        {
            search_SetText();
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text.Length > 0 && search.ForeColor == Color.White && searchLabel.Visible == false)
            {
                UserItem(true);
                Homepage.instance.searchQuery = search.Text;
            }
            else
                UserItem(false);
        }
        private void AddPosts(string name)
        {
            DataTable dt2 = Con.GetData($"SELECT p_user, p_id, p_picture, p_date, p_content, p_likes, u_username, u_picture FROM Post INNER JOIN Users ON Post.p_user = Users.u_id WHERE u_username = '" + name + "'");
            if (dt2.Rows.Count > 0)
            {
                var posts = new List<Post>();
                foreach (DataRow row in dt2.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                    MemoryStream ms2 = new MemoryStream((byte[])row["p_picture"]);
                    posts.Add(new Post((int)row["p_id"], (int)row["p_user"], Image.FromStream(ms), (DateTime)row["p_date"], row["p_content"].ToString() ?? string.Empty, Convert.ToInt32(row["p_likes"]), Image.FromStream(ms2), row["u_username"].ToString()));
                }
                posts = posts.OrderByDescending(o => o.PostDate).ToList();
                FeedPost postControls;
                foreach (Post post in posts)
                {
                    postControls = new FeedPost(post, "Search");
                    postControls.followButton.Visible = false;
                    AccountsPanel.Controls.Add(postControls);
                }
            }
        }
    }
}
