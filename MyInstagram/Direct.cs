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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Rooms INNER JOIN Users ON Rooms.reciever = Users.u_id WHERE sender = (SELECT u_id FROM Users WHERE u_username = '" + account_name.Text + "')", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DirectMessage[] directControls = new DirectMessage[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            directControls[i] = new DirectMessage();
                            MemoryStream ms = new MemoryStream((byte[])row["u_picture"]);
                            directControls[i].ImageSource = Image.FromStream(ms);
                            directControls[i].AccountName = row["u_username"].ToString();
                            directControls[i].RoomId = Convert.ToInt32(row["r_id"]);
                            string sameName = row["u_username"].ToString();
                            directControls[i].LastMessage = String.Empty; // Позже реализую

                            if (sameName == account_name.Text)
                                flowLayoutPanel1.Controls.Remove(directControls[i]);
                            else
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
