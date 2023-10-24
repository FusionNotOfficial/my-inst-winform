using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyInstagram
{
    public partial class Direct : Form
    {
        Functions Con;
        public Direct()
        {
            InitializeComponent();
            Con = new Functions();
        }
        private void UserItem()
        {
            flowLayoutPanel1.Controls.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Users", Con.Con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                UserControl[] userControls = new UserControl[dt.Rows.Count];
                for(int i = 0; i < 1; i++)
                {
                    userControls[i] = new UserControl();
                    MemoryStream stream = new MemoryStream((byte[])row["image"]);
                }
            }
        }
    }
}
