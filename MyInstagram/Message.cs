namespace MyInstagram
{
    public partial class Message : UserControl
    {
        private readonly int _expand = 20;
        private readonly int _maxWidth = 206;
        private string messageContent;
        public string MessageContent
        {
            get { return messageContent; }
            set
            {
                messageContent = value;
                content.Text = value;
                if (content.Width > _maxWidth)
                {
                    for (int i = 0; i < content.Width / _maxWidth; i++)
                    {
                        roundControl1.Height += _expand;
                        this.Height += _expand;
                        date.Location = new Point(date.Location.X, date.Location.Y + _expand);
                        viewed.Location = new Point(viewed.Location.X, viewed.Location.Y + _expand);
                    }
                }
                content.MaximumSize = new Size(280, 150);
            }
        }
        public void RecalculatePosition(bool isSender)
        {
            if (isSender)
            {
                if(content.Width < _maxWidth)
                {
                    int startWidth = roundControl1.Width;
                    roundControl1.Width = content.Width + date.Width + viewed.Width + 15;
                    int diffrence = startWidth - roundControl1.Width;
                    this.Width -= diffrence;
                    date.Location = new Point(content.Width + 2, date.Location.Y);
                    viewed.Location = new Point(date.Location.X + 39, viewed.Location.Y);
                    this.Margin = new Padding(110 + diffrence, 1, 0, 1);
                }
                else
                    this.Margin = new Padding(110, 1, 0, 1);
            }
            else
            {
                if(content.Width < _maxWidth)
                {
                    roundControl1.Width = content.Width + date.Width + 15;
                    date.Location = new Point(content.Width + 5, date.Location.Y);
                    this.Margin = new Padding(4, 1, 0, 1);
                }
                else
                {
                    date.Location = new Point(date.Location.X + 30, date.Location.Y);
                }
            }
        }

        private int sender;
        public int Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        private DateTime sendDate;
        public DateTime SendDate
        {
            get { return sendDate; }
            set
            {
                sendDate = value;
                date.Text = sendDate.ToString(String.Format("HH:mm"));
            }
        }
        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                if (isChecked)
                    viewed.Image = Image.FromFile(@"..\check2.png");
                else
                    viewed.Image = Image.FromFile(@"..\check1.png");
            }
        }
        public Message()
        {
            InitializeComponent();
        }
        public Message(string message, int sender, DateTime dt, bool isChecked)
        {
            InitializeComponent();
            MessageContent = message;
            Sender = sender;
            SendDate = dt;
            IsChecked = isChecked;
        }
    }
}
