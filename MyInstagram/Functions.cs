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
            ConCheck();
            Cmd.CommandText = Query;
            Cmd.ExecuteNonQuery();
            Con.Close();
        }
        public int GetCount(string query)
        {
            ConCheck();
            Cmd.CommandText = query;
            int result = (Int32)Cmd.ExecuteScalar();
            Con.Close();
            return result;
        }
        public bool Exists(string query)
        {
            ConCheck();
            Cmd.CommandText = query;
            int result = (Int32)Cmd.ExecuteScalar();
            Con.Close();
            if (result > 0)
                return true;
            else
                return false;
        }
        private void ConCheck()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }
    }
}
