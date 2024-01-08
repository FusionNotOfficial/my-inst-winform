using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInstagram
{
    public partial class CommentForm : Form
    {
        Functions Con;
        private int _postId;
        public static CommentForm? Instance { get; private set; }
        public CommentForm(int postId)
        {
            InitializeComponent();
            Con = new Functions();
            Instance = this;
            _postId = postId;
            DataTable dt = Con.GetData($"SELECT u_picture FROM Users WHERE u_id = {Homepage.id}");
            var ms = new MemoryStream((byte[])dt.Rows[0][0]);
            userIcon.Image = Image.FromStream(ms);

            UserItem();
        }

        public void UserItem()
        {
            commentsPanel.Controls.Clear();
            DataTable dt = Con.GetData($"SELECT c_id, c_user, c_content, c_date, u_picture, u_username FROM Comment INNER JOIN Users ON Comment.c_user = Users.u_id WHERE c_post = {_postId}");
            if (dt.Rows.Count > 0)
            {
                List<Comment> comments = new List<Comment>();
                foreach (DataRow row in dt.Rows)
                    comments.Add(new Comment((int)row["c_id"], (int)row["c_user"], _postId, (DateTime)row["c_date"], (string)row["c_content"]));
                comments = comments.OrderByDescending(o => o.Date).ToList();
                CommentControl cc;
                foreach (Comment comm in comments)
                {
                    cc = new CommentControl(comm);
                    commentsPanel.Controls.Add(cc);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendPicture_Click(object sender, EventArgs e)
        {
            if (message.Texts.Length > 0)
            {
                Con.SetData($"INSERT INTO Comment(c_content, c_date, c_user, c_post) VALUES('{message.Texts}', GETDATE(), {Homepage.id}, {_postId})");
                UserItem();
                message.Texts = "";
            }
        }
        private void sendButton_Enter(object sender, EventArgs e)
        {
            sendButton.BackColor = Color.RoyalBlue;
            sendIcon.BackColor = Color.RoyalBlue;
        }

        private void sendButton_MouseLeave(object sender, EventArgs e)
        {
            sendButton.BackColor = Color.DodgerBlue;
            sendIcon.BackColor = Color.DodgerBlue;
        }
    }
}
