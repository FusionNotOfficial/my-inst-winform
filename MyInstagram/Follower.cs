namespace MyInstagram
{
    internal class Follower
    {
        private Functions Con = new Functions();
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFollowed { get; set; }
        public Image Image { get; set; }
        public Follower(int id, string name, Image image)
        {
            Id = id;
            Name = name;
            Image = image;
            if (Con.Exists($"SELECT COUNT(f_id) FROM Followers WHERE f_userId = {Homepage.id} AND f_followingId = {Id}"))
                IsFollowed = true;
            else
                IsFollowed = false;
        }
    }
}
