namespace MyInstagram
{
    public partial class Message : UserControl
    {
        private int expand = 14;
        private string messageContent;
        public string MessageContent
        {
            get { return messageContent; }
            set
            {
                content.Text = value;
                if (content.Width > 150)
                {
                    for (int i = 0; i < content.Height / 18; i++)
                    {
                        roundControl1.Height += expand;
                        this.Height += expand;
                        date.Location = new Point(date.Location.X, date.Location.Y + expand);
                    }
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
        public DateTime SendDate { get; set; }
        private bool idChecked;
        public bool IdChecked { get; set; }
        public Message()
        {
            InitializeComponent();
        }
    }
}
