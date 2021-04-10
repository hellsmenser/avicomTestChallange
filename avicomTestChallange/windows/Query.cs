using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows;

namespace avicomTestChallange.windows
{
    /// <summary>
    /// Обращение к базе данных по localhost
    /// </summary>
    class Query
    {

        string conn = "Data Source=localhost;" +
                            "Initial Catalog=SoftTradePlus;" +
                            "Integrated Security=True";
        SqlDataAdapter adapter;
        SqlConnection connection;
        SqlCommand cmd;
        DataTable ReturnTable;

        Exception ex;

        //конструктор
        public Query()
        {
            this.connection = new SqlConnection(conn);
        }
        

        /// <summary>
        /// Исплнение запроса
        /// </summary>
        /// <param name="QueryText">Текст запроса</param>
        /// <param name="ex">Обработчик ошибок</param>
        /// <returns>DataTable с результатом запроса</returns>
        public DataTable Running(string QueryText, out Exception ex)
        {
            ex = null;
            cmd = new SqlCommand(QueryText, connection);
            ReturnTable = new DataTable();
            try
            {
                adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(ReturnTable);
                connection.Close();
            }
            catch (Exception cex)
            {
                ex = cex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return ReturnTable;

        }

        public DataTable Running(string QueryText, SqlCommand cmd, out Exception ex)
        {
            ex = null;
            ReturnTable = new DataTable();
            cmd.CommandText = QueryText;
            cmd.Connection = connection;
            try
            {
                adapter = new SqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(ReturnTable);
                connection.Close();
            }
            catch (Exception cex)
            {
                ex = cex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
            return ReturnTable;

        }
    }
}
