using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectTest
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"ms-sql-9.in-solve.ru";

            string database = "1gb_librarysql";
            string username = "1gb_samir4ik86";
            string password = "4474zz75iw";

            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }
    }

    class DBSQLServerUtils
    {

        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Получить объект Connection подключенный к DB.
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                QueryEmployee(conn);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                // Закрыть соединение.
                conn.Close();
                // Разрушить объект, освободить ресурс.
                conn.Dispose();
            }

        }

        private static void QueryEmployee(SqlConnection conn)
        {
            string sql = "SELECT * from Books order by id";

            // Создать объект Command.
            SqlCommand cmd = conn.CreateCommand();

            // Сочетать Command с Connection.
            cmd.CommandText = sql;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.Write($"{reader.GetString(1)}" + "salam" + Environment.NewLine);
                        //Console.WriteLine(reader.GetString(1));
                        
                        //// Индекс столбца Emp_ID в команде SQL.
                        //int empIdIndex = reader.GetOrdinal("Emp_Id"); // 0


                        //long empId = Convert.ToInt64(reader.GetValue(0));

                        //// Столбец Emp_No имеет index = 1.
                        //string empNo = reader.GetString(1);
                        //int empNameIndex = reader.GetOrdinal("Emp_Name");// 2
                        //string empName = reader.GetString(empNameIndex);

                        //// Индекс столбца Mng_Id в команде SQL.
                        //int mngIdIndex = reader.GetOrdinal("Mng_Id");

                        //long? mngId = null;


                        //if (!reader.IsDBNull(mngIdIndex))
                        //{
                        //    mngId = Convert.ToInt64(reader.GetValue(mngIdIndex));
                        //}
                        //Console.WriteLine("--------------------");
                        //Console.WriteLine("empIdIndex:" + empIdIndex);
                        //Console.WriteLine("EmpId:" + empId);
                        //Console.WriteLine("EmpNo:" + empNo);
                        //Console.WriteLine("EmpName:" + empName);
                        //Console.WriteLine("MngId:" + mngId);

                        // Индекс столбца Emp_ID в команде SQL.
                       
                    }
                }
            }

        }
    }
}
