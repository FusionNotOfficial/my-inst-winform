namespace MyInstagram
{
    public partial class FollowControl : UserControl
    {
        public int FollowerId { get; set; }
        Functions Con = new Functions();
        private FollowForm Foll;
        private bool _isFollower;
        public FollowControl(FollowForm foll, bool isFollower)
        {
            InitializeComponent();
            Foll = foll;
            _isFollower = isFollower;
        }

        private void remove_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "Following")
            {
                button.BackColor = SystemColors.Highlight;
                button.Text = "Follow";
                Con.SetData($"DELETE FROM Followers WHERE f_userId = {Homepage.id} AND f_followingId = {FollowerId}");
                Foll.SetFollowingText(true);
            }
            else if (button.Text == "Follow")
            {
                button.BackColor = Color.FromArgb(64, 64, 64);
                button.Text = "Following";
                Con.SetData($"INSERT INTO Followers(f_userId, f_followingId) VALUES({Homepage.id}, {FollowerId})");
                Foll.SetFollowingText(true);
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel);
                if (confirmResult == DialogResult.OK)
                {
                    Con.SetData($"DELETE FROM Followers WHERE f_followingId = {Homepage.id} AND f_userId = {FollowerId}");
                    Foll.UserItem($"SELECT u_id, u_username, u_picture FROM Followers INNER JOIN Users ON Followers.f_userId = Users.u_id WHERE f_followingId = {Homepage.id}");
                    Foll.SetFollowingText(false);
                }
            }
        }

        private void follow_Click(object sender, EventArgs e)
        {
            Con.SetData($"INSERT INTO Followers(f_userId, f_followingId) VALUES({Homepage.id}, {FollowerId})");
            follow.Visible = false;
            Foll.SetFollowingText(true);
        }

        private void picture_Click(object sender, EventArgs e)
        {
            if (_isFollower)
                Homepage.instance.LoadForm(new UserAccount(FollowerId, "Follower"));
            else
                Homepage.instance.LoadForm(new UserAccount(FollowerId, "Following"));
        }
    }
}
