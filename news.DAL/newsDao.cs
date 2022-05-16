using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using news.Entities;

namespace news.DAL2
{
    public class newsDao
    {
        public khabar Loadfirstnews()
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=newsdata;"
              + "Integrated Security=true;");
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select id , textbox from text";
            sqlCommand.CommandType = CommandType.Text;
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            khabar kh = new khabar();
            kh.textbox = reader[0].ToString();
            kh.id = int.Parse(reader[1].ToString());



            sqlConnection.Close();
            return kh;
        }
    }

}
