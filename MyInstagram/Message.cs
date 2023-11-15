namespace MyInstagram
{
    public partial class Message : UserControl
    {
        private string messageContent;
        public string MessageContent
        {
            get { return messageContent; }
            set { messageContent = value; }
        }
        private int sender;
        public int Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public Message()
        {
            InitializeComponent();
        }
    }
}
