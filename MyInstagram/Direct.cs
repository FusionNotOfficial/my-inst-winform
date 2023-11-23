using System.Data;
using System.Data.SqlClient;

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

            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Rooms WHERE sender = {id} OR reciever = {id}", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    List<Room> rooms = new List<Room>();
                    foreach (DataRow row in dt.Rows)
                    {
                        if (id == Convert.ToInt32(row["sender"]))
                            rooms.Add(new Room(Convert.ToInt32(row["reciever"]), Convert.ToInt32(row["r_id"])));
                        else
                            rooms.Add(new Room(Convert.ToInt32(row["sender"]), Convert.ToInt32(row["r_id"])));
                    }
                    DirectMessage[] directControls = new DirectMessage[rooms.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (Room room in rooms)
                        {
                            directControls[i] = new DirectMessage();
                            directControls[i].ImageSource = room.UserImage;
                            directControls[i].AccountName = room.Username;
                            directControls[i].RoomId = room.RoomId;
                            directControls[i].LastMessage = String.Empty; // Позже реализую

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

            Messenger mess = new Messenger(dialog.RoomId, id);
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
