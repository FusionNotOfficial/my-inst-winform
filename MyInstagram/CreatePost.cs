using System.Data.SqlClient;

namespace MyInstagram
{
    public partial class CreatePost : Form
    {
        private byte[] newImageArray;
        private bool isSelected = false;
        Functions Con;
        Homepage hmp = new Homepage();
        public CreatePost()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void Direct_Click(object sender, EventArgs e)
        {
            hmp.Show();
            Close();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                string query = "INSERT INTO Post(p_picture, p_content, p_likes, p_user, p_date) VALUES(@p_picture, @p_content, @p_likes, @p_user, GetDate())";
                SqlCommand smd = new SqlCommand(query, Con.Con);

                smd.Parameters.AddWithValue("p_picture", newImageArray);
                smd.Parameters.AddWithValue("p_content", description.Texts);
                smd.Parameters.AddWithValue("p_likes", 0);
                smd.Parameters.AddWithValue("p_user", Homepage.id);
                Con.Con.Open();
                smd.ExecuteNonQuery();
                Con.Con.Close();
                hmp.Show();
                Close();
                MyProfile.Current.UserItem();
            }
        }

        private void SelectedImage_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Image newImage = Image.FromFile(fd.FileName);
                SelectedImage.Image = newImage;
                MemoryStream ms = new MemoryStream();
                newImage.Save(ms, newImage.RawFormat);
                newImageArray = ms.ToArray();
            }
            ImageLabel.Visible = false;
            ShareButton.ForeColor = SystemColors.MenuHighlight;
            isSelected = true;
        }
    }
}
