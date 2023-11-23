using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    internal class Room
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Image UserImage { get; set; }
        public string Username { get; set; }
        public string LastMessage { get; set; }
        public bool IsChecked { get; set; }
        private Functions Con;
        public Room(int userId, int roomId)
        {
            RoomId = roomId;
            Id = userId;
            Con = new Functions();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT u_username, u_picture FROM Users WHERE u_id = {userId}", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                    UserImage = Image.FromStream(ms);
                    Username = row["u_username"].ToString();
                }
            }
        }
    }
}

