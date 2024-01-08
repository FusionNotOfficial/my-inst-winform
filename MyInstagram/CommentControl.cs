using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInstagram
{
    public partial class CommentControl : UserControl
    {
        Functions Con;
        private int _maxWidth = 320;
        private int _userId;
        private int _commentId;
        public CommentControl(Comment comm)
        {
            InitializeComponent();
            Con = new Functions();

            _userId = comm.UserId;
            _commentId = comm.Id;

            DataTable dt = Con.GetData($"SELECT u_picture, u_username FROM Users WHERE u_id = {comm.UserId}");
            foreach (DataRow dr in dt.Rows)
            {
                var m = new MemoryStream((byte[])dr["u_picture"]);
                commentImage.Image = Image.FromStream(m);
                username.Text = (string)dr["u_username"];
            }
            if (comm.UserId == Homepage.id || Con.Exists($"SELECT COUNT(p_id) FROM Post WHERE p_id = {comm.PostId} AND p_user = {Homepage.id}"))
                deleteButton.Visible = true;
            content.Text = comm.Content;

            DateTime now = comm.Date;
            string message = now > DateTime.Now.AddDays(-1) ? now.ToString("HH:mm") : now.ToString("MM/dd HH:mm");

            dateLabel.Text = message;
            dateLabel.Location = new Point(username.Size.Width + 55, dateLabel.Location.Y);

            if (content.Width > _maxWidth - 10)
                for (int i = 0; i <= content.Width / _maxWidth; i++)
                    this.Height += 20;
            content.MaximumSize = new Size(320, 200);
        }
        private void deleteButton_Enter(object sender, EventArgs e) => deleteButton.ForeColor = Color.White;
        private void deleteButton_Leave(object sender, EventArgs e) => deleteButton.ForeColor = SystemColors.ControlDark;

        private void commentImage_Click(object sender, EventArgs e)
        {
            if (_userId != Homepage.id)
            {
                Homepage.instance.LoadForm(new UserAccount(_userId, "Post"));
                CommentForm.Instance.Close();
            }
            else
            {
                Homepage.instance.account_select_Click(sender, e);
                CommentForm.Instance.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Do you want to delete this comment?", "Confirm", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                Con.SetData($"DELETE FROM Comment WHERE c_id = {_commentId}");
                CommentForm.Instance.UserItem();

            }
        }
    }
}
