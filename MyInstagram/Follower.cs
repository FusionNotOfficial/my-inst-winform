using System.Data;

namespace MyInstagram
{
    internal class Follower
    {
        private Functions Con = new Functions();
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsFollowed { get; set; }
        public Image Image { get; set; }
        public Follower(int id, string name)
        {
            Id = id;
            Name = name;
            var dt = Con.GetData($"SELECT u_picture FROM Users WHERE u_id = {Id}");
            foreach (DataRow row in dt.Rows)
            {
                MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                Image = Image.FromStream(ms);
            }
            if (Con.Exists($"SELECT COUNT(f_id) FROM Followers WHERE f_userId = {Homepage.id} AND f_followingId = {Id}"))
                IsFollowed = true;
            else
                IsFollowed = false;
        }
    }
}
