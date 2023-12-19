namespace MyInstagram
{
    public partial class Homepage : Form
    {
        public static int id;
        Functions Con;
        public Homepage()
        {
            InitializeComponent();
            Con = new Functions();
            account_select.BackColor = Color.Gray;
            id = Login.instanse.id;
            LoadForm(new MyProfile());
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
        private void account_select_Click(object sender, EventArgs e)
        {
            if (account_select.BackColor != Color.Gray)
            {
                LoadForm(new MyProfile());
                account_select.BackColor = Color.Gray;
                search_select.BackColor = Color.Black;
                home_select.BackColor = Color.Black;
            }
        }
        private void search_select_Click(object sender, EventArgs e)
        {
            search_select.BackColor = Color.Gray;
            account_select.BackColor = Color.Black;
            home_select.BackColor = Color.Black;
        }
        private void home_select_Click(object sender, EventArgs e)
        {
            LoadForm(new Feed());
            home_select.BackColor = Color.Gray;
            account_select.BackColor = Color.Black;
            search_select.BackColor = Color.Black;
        }
    }
}
