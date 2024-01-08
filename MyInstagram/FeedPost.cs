namespace MyInstagram
{
    public partial class FeedPost : UserControl
    {
        Functions Con;
        Feed FeedRef;

        private int id;
        private int userId;
        private readonly int horizontalAdj = 10;
        private int likesCount;
        private bool isLiked = false;
        private string filePath;
        private string _callback;

        public FeedPost(Post post, string callback)
        {
            InitializeComponent();

            _callback = callback;
            Con = new Functions();
            id = post.Id;

            if (Con.Exists($"SELECT COUNT(l_id) FROM Likes WHERE l_userId = {Homepage.id} AND l_postId = {id}"))
            {
                isLiked = true;
                filePath = "../heart_2.png";
            }
            else
                filePath = "../heart_1.png";

            userId = post.UserId;
            FeedRef = post.Feed;

            int amount = Con.GetCount($"SELECT COUNT(f_id) FROM Followers WHERE f_userId = {Homepage.id} AND f_followingId = {userId}");
            if (amount > 0)
                SetFollowButton(true);
            else
                SetFollowButton(false);
            likeButton.Image = Image.FromFile(filePath);
            userPicture.Image = post.PostImage;
            postPicture.Image = post.UserImage;
            usernameLabel.Text = post.Username;
            usernameDescription.Text = post.Username;
            likesCount = post.Likes;
            if (userId == Homepage.id)
                followButton.Visible = false;

            if (userId == Homepage.id)
                deleteButton.Visible = true;

            UpdateLikes();
            postDate.Text = post.PostDate.ToString("D");
            descriptionLabel.Text = post.Content;
            descriptionLabel.Location = new Point(usernameLabel.Size.Width, descriptionLabel.Location.Y);
            _callback = callback;
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            string filePath;
            if (isLiked)
            {
                filePath = "../heart_1.png";
                likesCount -= 1;
                Con.SetData($"DELETE FROM Likes WHERE l_postId = {id} AND l_userId = {Homepage.id}");
            }
            else
            {
                filePath = "../heart_2.png";
                likesCount += 1;
                Con.SetData($"INSERT INTO Likes(l_userId, l_postId) VALUES({Homepage.id}, {id})");
            }
            isLiked = !isLiked;
            likeButton.Image = Image.FromFile(filePath);
            Con.SetData($"UPDATE Post SET p_likes = {likesCount} WHERE p_id = {id}");
            UpdateLikes();
        }
        private void UpdateLikes()
        {
            likesLabel.Text = likesCount.ToString();
        }
        private void followButton_Click(object sender, EventArgs e)
        {
            if (followButton.Text == "Follow")
            {
                SetFollowButton(true);
                Con.SetData($"INSERT INTO Followers(f_userId, f_followingId) VALUES({Homepage.id}, {userId})");
                FeedRef.UserItem(true);
            }
            else
            {
                SetFollowButton(false);
                Con.SetData($"DELETE FROM Followers WHERE f_userId = {Homepage.id} AND f_followingId = {userId}");
                if (_callback != "UserAccount")
                    FeedRef.UserItem(true);

            }
        }
        private void SetFollowButton(bool isFollow)
        {
            if (isFollow)
            {
                followButton.Text = "Following";
                followButton.Width += horizontalAdj;
                followButton.Location = new Point(followButton.Location.X - horizontalAdj, followButton.Location.Y);
            }
            else

            {
                followButton.Text = "Follow";
                followButton.Width -= horizontalAdj;
                followButton.Location = new Point(followButton.Location.X + horizontalAdj, followButton.Location.Y);
            }
        }
        private void userPicture_Click(object sender, EventArgs e)
        {
            if (userId != Homepage.id)
            {
                switch (_callback)
                {
                    case "Post":
                        Homepage.instance.LoadForm(new UserAccount(userId, _callback));
                        break;
                    case "UserAccount":

                        break;
                    default:
                        Homepage.instance.LoadForm(new UserAccount(userId, _callback));
                        break;
                }
            }
            else
                Homepage.instance.account_select_Click(sender, e);
        }

        private void deleteButton_Enter(object sender, EventArgs e) => label1.ForeColor = Color.White;

        private void deleteButton_Leave(object sender, EventArgs e) => label1.ForeColor = SystemColors.ControlDark;


        private void label1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to delete this post?", "Confirm", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
                Con.SetData($"DELETE FROM Post WHERE p_id = {id}");
            if (_callback == "MyProfile")
                UserPost.Current.UserItem();
            else
                FeedRef.UserItem();
        }

        private void comment_Click(object sender, EventArgs e)
        {
            CommentForm comment = new CommentForm(id);
            comment.Show();
        }
    }
}
