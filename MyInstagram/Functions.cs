using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

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
        public int GetCount(int roomId, int userId)
        {
            ConCheck();
            Cmd.CommandText = $"SELECT COUNT(m_id) FROM Messages WHERE room = {roomId} AND checked = 0 AND sender != {userId}";
            int result = (Int32)Cmd.ExecuteScalar();
            Con.Close();
            return result;
        }
        public int GetCount(string rowName, string tableName, string value1Name, string value2Name, int value1, int value2)
        {
            ConCheck();
            Cmd.CommandText = $"SELECT COUNT({rowName}) FROM {tableName} WHERE {value1Name} = {value1} AND {value2Name} = {value2}";
            int result = (Int32)Cmd.ExecuteScalar();
            Con.Close();
            return result;
        }
        public int GetCount(string rowName, string tableName, string valueName, int value)
        {
            ConCheck();
            Cmd.CommandText = $"SELECT COUNT({rowName}) FROM {tableName} WHERE {valueName} = {value}";
            int result = (Int32)Cmd.ExecuteScalar();
            Con.Close();
            return result;
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
