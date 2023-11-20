namespace MyInstagram
{
    public partial class Message : UserControl
    {
        private string messageContent;
        public string MessageContent
        {
            get { return messageContent; }
            set
            {
                content.Text = value;
                if (content.Width > 150)
                {
                    roundControl1.Height += 13;
                    this.Height += 13;
                    date.Location = new Point(date.Location.X, date.Location.Y + 13);
                }
            }
        }
        private int sender;
        public int Sender
        {
            get { return sender; }
            set
            {
                sender = value;
            }
        }
        public Message()
        {
            InitializeComponent();
        }
    }
}
