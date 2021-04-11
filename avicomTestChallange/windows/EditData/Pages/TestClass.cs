using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace avicomTestChallange.windows.EditData.Pages
{
    public class TestClass
    {

        Query query = new Query();
        Exception ex = null;
        public string name;
        public int curid;
        DataTable QueryResult;
        public TestClass() {


        }

        public bool addFunc()
        {

            //настраиваем запрос
            string addQuery = "INSERT INTO Managers([name])" +
                                "VALUES (@name)";
            SqlCommand cmd = new SqlCommand();

            //добовляем обьекту параметры
            try
            {
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = name;
            }
            catch (Exception cex)
            {
                ex = cex;
            }

            //выполнение запроса и обновление датагрида
            QueryResult = query.Running(addQuery, cmd, out ex);
            if( ex == null)
            {
                return true;
            }
            return false;
        }


        public bool removeFunc()
        {
            //настраиваем запрос
            string removeQuery = "DELETE FROM Managers WHERE id = " + curid.ToString();
            DataTable QueryResult;

            //выполняем запрос и обнавляем датагрид
            QueryResult = query.Running(removeQuery, out ex); 
            if (ex == null)
            {
                return true;
            }
            return false;
        }



    }
}
