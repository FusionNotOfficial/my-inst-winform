using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    public partial class Direct : Form
    {
        Functions Con;
        public Direct(string username)
        {
            InitializeComponent();
            account_name.Text = username;
            Con = new Functions();
            UserItem();
        }
        public void UserItem()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", Con.Con);
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
                            string sameName = row["u_username"].ToString();
                            directControls[i].LastMessage = String.Empty; // Позже реализую
                            if (sameName == account_name.Text)
                            {
                                flowLayoutPanel1.Controls.Remove(directControls[i]);
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(directControls[i]);
                            }
                            directControls[i].Click += new EventHandler(button1_Click);
                        }
                    }
                }
            }
            Con.Con.Close();
        }

        private Image GetImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Messenger mess = new Messenger();
            mess.Show();
            this.Close();
        }
    }
}
