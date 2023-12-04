using System.Data;
using System.Data.SqlClient;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace MyInstagram
{
    public partial class Direct : Form
    {
        Functions Con;
        private int id;
        public Direct()
        {
            id = Login.instanse.id;
            InitializeComponent();
            Con = new Functions();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT u_username FROM Users WHERE u_id = '" + id + "'", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow row = dt.Rows[0];
            account_name.Text = row["u_username"].ToString();

            UserItem();
        }


        public void UserItem()
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = Con.GetData($"SELECT * FROM Rooms WHERE sender = {id} OR reciever = {id}");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    List<Room> rooms = new List<Room>();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (id == Convert.ToInt32(row["sender"]))
                            rooms.Add(new Room(Convert.ToInt32(row["reciever"]), Convert.ToInt32(row["r_id"]), Convert.ToInt32(row["reciever"])));
                        else
                            rooms.Add(new Room(Convert.ToInt32(row["sender"]), Convert.ToInt32(row["r_id"]), Convert.ToInt32(row["reciever"])));
                    }
                    rooms = rooms.OrderByDescending(o => o.LastMessageDate).ToList();
                    DirectMessage[] directControls = new DirectMessage[rooms.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (Room room in rooms)
                        {
                            directControls[i] = new DirectMessage();
                            int countNotifications = Con.GetCount(room.RoomId, id);
                            if (countNotifications > 0)
                                directControls[i].NotificationsCount = countNotifications;
                            directControls[i].ImageSource = room.UserImage;
                            directControls[i].AccountName = room.Username;
                            directControls[i].RoomId = room.RoomId;
                            DataTable dt3 = Con.GetData($"SELECT TOP 1 text_content FROM Messages WHERE room = {Convert.ToInt32(room.RoomId)} ORDER BY m_id DESC");
                            if (dt3.Rows.Count > 0)
                                directControls[i].LastMessage = dt3.Rows[0][0].ToString();
                            else
                                directControls[i].LastMessage = string.Empty;
                            directControls[i].RecieverId = room.Reciever;
                            directControls[i].MyId = room.Id;

                            flowLayoutPanel1.Controls.Add(directControls[i]);

                            directControls[i].Click += new EventHandler(button1_Click);
                        }
                    }
                }
            }
            Con.Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = sender as DirectMessage;
            Messenger mess;
            if(id != dialog.RecieverId)
                mess = new Messenger(dialog.RoomId, id, dialog.RecieverId);
            else
                mess = new Messenger(dialog.RoomId, id, dialog.MyId);
            Close();
            mess.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var dir = new Homepage();
            dir.Show();
            Close();
        }
    }
}
