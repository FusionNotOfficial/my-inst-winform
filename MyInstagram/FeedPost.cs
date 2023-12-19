namespace MyInstagram
{
    public partial class FeedPost : UserControl
    {
        public FeedPost(Post post)
        {
            InitializeComponent();

            userPicture.Image = post.PostImage;
            postPicture.Image = post.UserImage;
            usernameLabel.Text = post.Username;
            usernameDescription.Text = post.Username;
            likesLabel.Text = post.Likes.ToString();
            postDate.Text = post.PostDate.ToString();
            descriptionLabel.Text = post.Content;
        }

    }
}
