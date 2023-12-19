namespace MyInstagram
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Image PostImage { get; set; }
        public Image UserImage { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }
        public int Likes { get; set; }
        public Post(Image postImage, DateTime postDate)
        {
            PostImage = postImage;
            PostDate = postDate;
        }
        public Post(Image postImage, DateTime postDate, string content, int likes, Image userImage, string username) : this(postImage, postDate)
        {
            PostImage = postImage;
            PostDate = postDate;
            Content = content;
            Likes = likes;
            UserImage = userImage;
            Username = username;
        }
        public Post(int id, int userId, Image postImage, DateTime postDate, string content, int likes, Image userImage, string username) : this(postImage, postDate, content, likes, userImage, username)
        {
            Id = id;
            UserId = userId;
        }
    }
}
