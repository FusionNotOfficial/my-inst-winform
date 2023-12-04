using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInstagram
{
    public partial class CreatePost : Form
    {
        private byte[] newImageArray;

        public CreatePost()
        {
            InitializeComponent();
        }

        private void Direct_Click(object sender, EventArgs e)
        {
            Homepage hmp = new Homepage();
            hmp.Show();
            this.Close();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {

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
        }
    }
}
