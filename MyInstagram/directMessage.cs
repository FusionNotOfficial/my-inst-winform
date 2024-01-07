using System.ComponentModel;

namespace MyInstagram
{
    public partial class DirectMessage : UserControl
    {
        public DirectMessage()
        {
            InitializeComponent();
        }
        public int RecieverId { get; set; }
        public int MyId { get; set; }
        private int notificationsCount;
        public int NotificationsCount
        {
            get { return notificationsCount; }
            set
            {
                notificationsCount = value;
                notification.Text = notificationsCount.ToString();
                notification.Visible = true;
                notificationForm.Visible = true;
                if (notificationsCount > 9 && notificationsCount < 100)
                    FormResize();
                else if (notificationsCount > 99)
                {
                    FormResize();
                    notification.Text = "99";
                }

            }
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
            set
            {
                if (value != null)
                    lastMessage.Text = value;
                else
                    lastMessage.Text = string.Empty;
            } // сделать ... в конце
        }
        private int roomId;
        [Category("Tools")]
        public int RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }
        private void FormResize()
        {
            notificationForm.Size = new Size(31, 25);
            notificationForm.Location = new Point(242, 15);
            notificationForm.Radius = 20;
            notification.Location = new Point(247, 17);
        }
    }
}
