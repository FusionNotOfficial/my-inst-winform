using System.Data;
using System.Data.SqlClient;

namespace MyInstagram
{
    class Functions
    {
        public SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;
        public Functions()
        {
            ConStr = @"Data Source=DESKTOP-T96O8TL\SQLEXPRESS;Initial Catalog=MyInsta;Integrated Security=True";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }
        public void SetData(string Query)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cmd.ExecuteNonQuery();
            Con.Close();
        }
        public int GetCount(int roomId, int userId)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = $"SELECT COUNT(m_id) FROM Messages WHERE room = {roomId} AND checked = 0 AND sender != {userId}";
            int result = (Int32)Cmd.ExecuteScalar();
            Con.Close();
            return result;
        }

    }
}
