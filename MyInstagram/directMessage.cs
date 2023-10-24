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
    public partial class directMessage : UserControl
    {
        public directMessage()
        {
            InitializeComponent();
        }
        private Image imageSource;
        [Category("Tools")]
        public Image ImageSource
        {
            get { return imageSource; }
            set { 
                picture.Image = value;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
