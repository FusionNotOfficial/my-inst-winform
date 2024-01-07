using System.Data;

namespace MyInstagram
{
    internal class Room
    {
        public int Id { get; set; }
        public int Reciever { get; set; }
        public int RoomId { get; set; }
        public Image UserImage { get; set; }
        public string Username { get; set; }
        public string LastMessage { get; set; }
        public bool IsChecked { get; set; }
        public DateTime LastMessageDate { get; set; }
        private Functions Con;
        public Room(int userId, int roomId, int reciever)
        {
            RoomId = roomId;
            Id = userId;
            Con = new Functions();
            DataTable dt = Con.GetData($"SELECT u_username, u_picture FROM Users WHERE u_id = {userId}");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                    UserImage = Image.FromStream(ms);
                    Username = row["u_username"].ToString();
                }
            }
            dt = Con.GetData($"SELECT TOP 1 send_date FROM Messages WHERE room = {Convert.ToInt32(roomId)} ORDER BY m_id DESC");
            foreach (DataRow row in dt.Rows)
            {
                LastMessageDate = (DateTime)row["send_date"];
            }
            Reciever = reciever;
        }
    }
}

