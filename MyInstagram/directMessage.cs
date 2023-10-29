using System.ComponentModel;

namespace MyInstagram
{
    public partial class DirectMessage : UserControl
    {
        public DirectMessage()
        {
            InitializeComponent();
        }
        private Image imageSource;
        [Category("Tools")]
        public Image ImageSource
        {
            get { return imageSource; }
            set
            {
                imageSource = value;
                picture.Image = value;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private string accountName;
        [Category("Tools")]
        public string AccountName
        {
            get { return accountName; }
            set { username.Text = value; }
        }
        private string lastSeenMessage;
        [Category("Tools")]
        public string LastMessage
        {
            get { return lastSeenMessage; }
            set { lastMessage.Text = value; }
        }
    }
}
