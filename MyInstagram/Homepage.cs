namespace MyInstagram
{
    public partial class Homepage : Form
    {
        public static int id;
        public string searchQuery;
        public static Homepage instance;
        public static int scrollValue = 0;
        Functions Con;
        public Homepage()
        {
            InitializeComponent();
            Con = new Functions();
            account_select.BackColor = Color.Gray;
            id = Login.instanse.id;
            LoadForm(new MyProfile());
            instance = this;
        }
        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }
        public void account_select_Click(object sender, EventArgs e)
        {
            if (!(this.mainPanel.Controls[0] is MyProfile))
            {
                LoadForm(new MyProfile());
                account_select.BackColor = Color.Gray;
                search_select.BackColor = Color.Black;
                home_select.BackColor = Color.Black;
            }
        }
        private void search_select_Click(object sender, EventArgs e)
        {
            if (!(this.mainPanel.Controls[0] is SearchForm))
            {
                searchQuery = "";
                LoadForm(new SearchForm());
                search_select.BackColor = Color.Gray;
                account_select.BackColor = Color.Black;
                home_select.BackColor = Color.Black;
            }
        }
        private void home_select_Click(object sender, EventArgs e)
        {
            if (!(this.mainPanel.Controls[0] is Feed))
            {
                LoadForm(new Feed());
                home_select.BackColor = Color.Gray;
                account_select.BackColor = Color.Black;
                search_select.BackColor = Color.Black;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            string LastSeen = $"UPDATE Users SET u_lastSeen = getdate() WHERE u_id = {id}";
            Con.SetData(LastSeen);
        }
    }
}
