using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    public partial class Messenger : Form
    {
        private int myId;
        private int roomId;
        Functions Con;
        public Messenger(int roomId, int myId)
        {
            InitializeComponent();
            this.myId = myId;
            this.roomId = roomId;
            Con = new Functions();
            string query = "SELECT u_username, u_picture FROM Rooms INNER JOIN Users ON Rooms.reciever = Users.u_id WHERE r_id ='" + roomId + "'";
            DataTable dt = Con.GetData(query);
            foreach (DataRow row in dt.Rows)
            {
                account_name.Text = row["u_username"].ToString();
                MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                roomIcon.Image = Image.FromStream(ms);
            }
            UserItem();
        }

        private void UserItem()
        {
            messagesPanel.Controls.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM Messages WHERE room = {roomId}", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Message mes = new Message(row["text_content"].ToString(), Convert.ToInt32(row["sender"]), Convert.ToDateTime(row["send_date"]), Convert.ToBoolean(row["checked"]));
                if (mes.Sender == myId)
                    mes.Margin = new Padding(79, 0, 0, 0);
                else
                {
                    mes.roundControl1.BackColor = Color.FromArgb(31, 34, 31);
                    mes.content.BackColor = Color.FromArgb(31, 34, 31);
                    mes.date.BackColor = Color.FromArgb(31, 34, 31);
                    mes.Margin = new Padding(5, 0, 0, 0);
                }
                messagesPanel.Controls.Add(mes);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Direct dr = new Direct();
            dr.Show();
            Close();
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (message.Texts.Length != 0)
            {
                string query = $"INSERT INTO Messages(text_content, send_date, room, sender, checked) VALUES('{message.Texts}', '{DateTime.Now}', {roomId}, {myId}, {0})";
                SqlCommand smd = new SqlCommand(query, Con.Con);
                Con.Con.Open();
                smd.ExecuteNonQuery();
                message.Texts = String.Empty;
                UserItem();
                Con.Con.Close();
            }
        }

        private void sendButton_Enter(object sender, EventArgs e)
        {
            sendButton.BackColor = Color.RoyalBlue;
            sendIcon.BackColor = Color.RoyalBlue;
        }

        private void sendButton_MouseLeave(object sender, EventArgs e)
        {
            sendButton.BackColor = Color.CornflowerBlue;
            sendIcon.BackColor = Color.CornflowerBlue;
        }

        private void message__TextChanged(object sender, EventArgs e)
        {
            if (message.Texts.Length > 100)
            {
                sendButton.BackColor = Color.RoyalBlue;
                sendIcon.BackColor = Color.RoyalBlue;
                sendButton.Enabled = false;
                LengthError.Visible = true;
            }
            else
            {
                sendButton.BackColor = Color.CornflowerBlue;
                sendIcon.BackColor = Color.CornflowerBlue;
                sendButton.Enabled = true;
                LengthError.Visible = false;
            }
        }
    }
}
