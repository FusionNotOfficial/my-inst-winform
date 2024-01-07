using System.Runtime.InteropServices;

namespace MyInstagram
{
    public class Post
    {
        public int Id { get; private set; }
        public int UserId { get; set; }
        public Image PostImage { get; set; }
        public Image UserImage { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }
        public int Likes { get; set; }
        public Feed Feed { get; set; }

        public Post(Image postImage, DateTime postDate)
        {
            PostImage = postImage;
            PostDate = postDate;
        }
        public Post(int id, Image postImage, DateTime postDate, string content, int likes, Image userImage, string username) : this(postImage, postDate)
        {
            Id = id;
            PostImage = postImage;
            PostDate = postDate;
            Content = content;
            Likes = likes;
            UserImage = userImage;
            Username = username;
        }
        public Post(int id, int userId, Image postImage, DateTime postDate, string content, int likes, Image userImage, string username) : this(postImage, postDate)
        {
            Id = id;
            UserId = userId;
            PostImage = postImage;
            PostDate = postDate;
            Content = content;
            Likes = likes;
            UserImage = userImage;
            Username = username;
        }
        public Post(Feed feed, int id, int userId, Image postImage, DateTime postDate, string content, int likes, Image userImage, string username) : this(id, postImage, postDate, content, likes, userImage, username)
        {
            UserId = userId;
            Feed = feed;
        }
    }
}
