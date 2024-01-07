namespace MyInstagram
{
    public partial class PostUserControl : UserControl
    {
        private Image imageSource;
        public Image ImageSource
        {
            get { return imageSource; }
            set
            {
                imageSource = value;
                postImage.Image = value;
            }
        }
        public int _id;
        public PostUserControl()
        {
            InitializeComponent();
        }
    }
}
