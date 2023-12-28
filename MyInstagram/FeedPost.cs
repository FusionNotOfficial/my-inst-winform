using Guna.UI2.WinForms.Suite;
using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    public partial class FeedPost : UserControl
    {
        Functions Con;
        private int id;
        private int userId;
        private readonly int horizontalAdj = 10;
        private int likesCount;
        private bool isLiked = false;
        private string filePath;
        Feed FeedRef;
        public FeedPost(Post post)
        {
            InitializeComponent();

            Con = new Functions();
            id = post.Id;

            int amount = Con.GetCount("l_id", "Likes", "l_userId", "l_postId", Homepage.id, id);
            if (amount > 0)
            {
                isLiked = true;
                filePath = "../heart_2.png";
            }
            else
                filePath = "../heart_1.png";
            userId= post.UserId;
            FeedRef = post.Feed;
            amount = Con.GetCount("f_id", "Followers", "f_userId", "f_followingId", Homepage.id, userId);
            if(amount > 0)
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
            UpdateLikes();
            postDate.Text = post.PostDate.ToString("D");
            descriptionLabel.Text = post.Content;
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
                FeedRef.UserItem(true);
            }
        }
        private void SetFollowButton(bool isFollow)
        {
            if(isFollow)
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
    }
}
