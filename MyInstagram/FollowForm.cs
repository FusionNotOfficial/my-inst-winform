using System.Data;

namespace MyInstagram
{
    public partial class FollowForm : Form
    {
        Functions Con;
        private bool _isFollow;
        private string _callBack;
        private int _followerId;
        private int _userId;
        public FollowForm(bool isFollower, string callBack, int followerId, int userId)
        {
            InitializeComponent();
            Con = new Functions();
            _callBack = callBack;
            _isFollow = isFollower;
            _followerId = followerId;
            _userId = userId;
            if (_isFollow)
            {
                followers.ForeColor = Color.White;
                following.ForeColor = Color.DarkGray;
                UserItem($"SELECT u_id, u_username, u_picture FROM Followers INNER JOIN Users ON Followers.f_userId = Users.u_id WHERE f_followingId = {_userId}");
            }
            else
            {
                followers.ForeColor = Color.DarkGray;
                following.ForeColor = Color.White;
                UserItem($"SELECT u_id, u_username, u_picture FROM Followers INNER JOIN Users ON Followers.f_followingId = Users.u_id WHERE f_userId = {_userId}");
            }

            DataTable dt = Con.GetData($"SELECT u_username FROM Users WHERE u_id = {_userId}");
            Account.Text = dt.Rows[0][0].ToString();
            SetFollowingText(true);
            SetFollowingText(false);
        }
        public void SetFollowingText(bool isFollow)
        {
            if (isFollow)
            {
                int amount = Con.GetCount($"SELECT COUNT(f_id) FROM Followers WHERE f_userId = {_userId}");
                following.Text = amount.ToString() + " following";
            }
            else
            {
                int amount = Con.GetCount($"SELECT COUNT(f_id) FROM Followers WHERE f_followingId = {_userId}");
                followers.Text = amount.ToString() + " followers";
            }
        }
        public void UserItem(string query)
        {
            accounts.Controls.Clear();

            DataTable dt = Con.GetData(query);
            if (dt.Rows.Count > 0)
            {
                List<Follower> followers = new List<Follower>();
                foreach (DataRow row in dt.Rows)
                {
                    followers.Add(new Follower((int)row["u_id"], row["u_username"].ToString()));
                }
                followers = followers.OrderBy(o => o.Name).ToList();
                FollowControl[] followControls = new FollowControl[followers.Count];
                foreach (Follower follow in followers)
                {
                    if (_callBack == "MyProfile")
                    {
                        if (_isFollow)
                            followControls[0] = new FollowControl(this, true);
                        else
                            followControls[0] = new FollowControl(this, false);
                        followControls[0].picture.Image = follow.Image;
                        followControls[0].account_name.Text = follow.Name;
                        followControls[0].FollowerId = follow.Id;
                        if (!_isFollow)
                        {
                            followControls[0].follow.Visible = false;
                            followControls[0].remove.Size = new Size(95, 36);
                            followControls[0].remove.Location = new Point(followControls[0].remove.Location.X - 15, followControls[0].remove.Location.Y);
                            followControls[0].remove.Text = "Following";
                        }
                        else
                            if (Con.Exists($"SELECT COUNT(f_id) FROM Followers WHERE f_followingId = {follow.Id} AND f_userId = {_userId}"))
                            followControls[0].follow.Visible = false;
                    }
                    // Если зашел в подписки другого пользователя
                    else
                    {
                        if (_isFollow)
                            followControls[0] = new FollowControl(this, true);
                        else
                            followControls[0] = new FollowControl(this, false);
                        followControls[0].picture.Image = follow.Image;
                        followControls[0].account_name.Text = follow.Name;
                        followControls[0].FollowerId = follow.Id;
                        followControls[0].follow.Visible = false;
                        followControls[0].remove.Size = new Size(95, 36);
                        followControls[0].remove.Location = new Point(followControls[0].remove.Location.X - 15, followControls[0].remove.Location.Y);
                        if (followControls[0].FollowerId == Homepage.id)
                        {
                            followControls[0].remove.Visible = false;
                            followControls[0].picture.Click += new EventHandler(LoadHomePage);
                            followControls[0].account_name.Click += new EventHandler(LoadHomePage);
                        }
                        if (Con.Exists($"SELECT COUNT(f_id) FROM Followers WHERE f_followingId = {follow.Id} AND f_userId = {Homepage.id}"))
                        {
                            followControls[0].remove.BackColor = Color.FromArgb(64, 64, 64);
                            followControls[0].remove.Text = "Following";
                        }
                        else
                        {
                            followControls[0].remove.BackColor = SystemColors.Highlight;
                            followControls[0].remove.Text = "Follow";
                        }
                    }
                    accounts.Controls.Add(followControls[0]);
                }
            }
            Con.Con.Close();
        }
        static void LoadHomePage(object sender, EventArgs e)
        {
            Homepage.instance.account_select_Click(sender, e);
            Homepage.instance.LoadForm(new MyProfile());
        }
        private void FollowForm_Load(object sender, EventArgs e)
        {
            this.search.Enter += new EventHandler(search_Enter);
            this.search.Leave += new EventHandler(search_Leave);
            search_SetText();
        }
        protected void search_SetText()
        {
            this.search.Text = "Search";
            search.ForeColor = Color.Gray;
        }
        private void search_Enter(object sender, EventArgs e)
        {
            if (search.ForeColor == Color.White)
                return;
            search.Text = "";
            search.ForeColor = Color.White;
        }
        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text.Trim() == "")
                search_SetText();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            if (_callBack == "MyProfile")
                Homepage.instance.LoadForm(new MyProfile());
            else
                Homepage.instance.LoadForm(new UserAccount(_followerId, "Post"));
        }
        private void followers_Click(object sender, EventArgs e)
        {
            if (!_isFollow)
                _isFollow = true;
            UserItem($"SELECT u_id, u_username FROM Followers INNER JOIN Users ON Followers.f_userId = Users.u_id WHERE f_followingId = {_userId}");
            followers.ForeColor = Color.White;
            following.ForeColor = Color.DarkGray;
        }
        private void following_Click(object sender, EventArgs e)
        {
            if (_isFollow)
                _isFollow = false;
            UserItem($"SELECT u_id, u_username FROM Followers INNER JOIN Users ON Followers.f_followingId = Users.u_id WHERE f_userId = {_userId}");
            followers.ForeColor = Color.DarkGray;
            following.ForeColor = Color.White;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text.Length > 0)
            {
                if (_isFollow)
                    UserItem($"SELECT DISTINCT u_id, u_username FROM Followers INNER JOIN Users ON Followers.f_userId = Users.u_id WHERE f_followingId = {_userId} AND u_username LIKE '" + search.Text + "%'");
                else
                    UserItem($"SELECT DISTINCT u_id, u_username FROM Followers INNER JOIN Users ON Followers.f_followingId = Users.u_id WHERE f_userId = {_userId} AND u_username LIKE '" + search.Text + "%'");
            }
            else
            {
                if (_isFollow)
                    UserItem($"SELECT u_id, u_username FROM Followers INNER JOIN Users ON Followers.f_userId = Users.u_id WHERE f_followingId = {_userId}");
                else
                    UserItem($"SELECT u_id, u_username FROM Followers INNER JOIN Users ON Followers.f_followingId = Users.u_id WHERE f_userId = {_userId}");
            }
        }
    }
}
