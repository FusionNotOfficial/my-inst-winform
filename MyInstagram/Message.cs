namespace MyInstagram
{
    public partial class Message : UserControl
    {
        private int expand = 14;
        private readonly int extraField = 50;
        private readonly int extraVieved = 32;
        private readonly int extraDate = 2;
        private string messageContent;
        public string MessageContent
        {
            get { return messageContent; }
            set
            {
                messageContent = value;
                content.Text = value;
                if (content.Width > 150)
                {
                    for (int i = 0; i < content.Height / 18; i++)
                    {
                        roundControl1.Height += expand;
                        this.Height += expand;
                        date.Location = new Point(date.Location.X, date.Location.Y + expand);
                        viewed.Location = new Point(viewed.Location.X, viewed.Location.Y + expand);
                    }
                }
            }
        }
        public void RecalculatePosition(bool isSender)
        {
            int difference = roundControl1.Width - content.Width;
            this.Width -= (difference - extraField);
            roundControl1.Width = this.Width;

            if (isSender)
            {
                date.Location = new Point(content.Width + extraDate, date.Location.Y);
                viewed.Location = new Point(content.Width + extraVieved, viewed.Location.Y);
                Margin = new Padding(79 + (difference - extraField), 0, 0, 0);
            }
            else
            {
                int horizontalDateMove = content.Height > 18 ? 31 : 2;
                roundControl1.Width = content.Height > 18 ? roundControl1.Width - 29 : roundControl1.Width;
                date.Location = new Point(content.Width + (extraField - viewed.Width) - extraVieved - horizontalDateMove, date.Location.Y);
                roundControl1.Width = this.Width - viewed.Width;
                this.Width = 200;
                roundControl1.Width = content.Height > 18 ? roundControl1.Width - 29 : roundControl1.Width;
                Margin = new Padding(5, 0, 0, 0);
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
