using System.Data;

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

            DataTable dt = Con.GetData($"SELECT u_username FROM Users WHERE u_id = {id}");
            DataRow row = dt.Rows[0];
            account_name.Text = row["u_username"].ToString();

            UserItem(false);
        }

        public void UserItem(bool filter)
        {
            flowLayoutPanel1.Controls.Clear();

            DataTable dt = Con.GetData($"SELECT * FROM Rooms WHERE sender = {id} OR reciever = {id}");
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
                if (filter && search.Text.Length > 0)
                {
                    rooms.RemoveAll(room => !room.Username.StartsWith(search.Text));
                }
                DirectMessage[] directControls = new DirectMessage[rooms.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (Room room in rooms)
                    {
                        directControls[i] = new DirectMessage();
                        int countNotifications = Con.GetCount($"SELECT COUNT(m_id) FROM Messages WHERE room = {room.RoomId} AND sender != {id} AND checked = {0}");
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
        private void button1_Click(object sender, EventArgs e)
        {
            var dialog = sender as DirectMessage;
            Messenger mess;
            if (id != dialog.RecieverId)
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
        private void Direct_Load(object sender, EventArgs e)
        {
            search_SetText();
        }
        protected void search_SetText()
        {
            searchLabel.Visible = true;
        }
        private void search_Enter(object sender, EventArgs e)
        {
            searchLabel.Visible = false;
        }
        private void search_Leave(object sender, EventArgs e)
        {
            search_SetText();
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text.Length > 0 && search.ForeColor == Color.White && searchLabel.Visible == false)
            {
                UserItem(true);
                Homepage.instance.searchQuery = search.Text;
            }
            else
                UserItem(false);
        }
    }
}
