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
            //WAITFOR DELAY '00:00:01';
            string sql = @"SELECT B.Name as 'Book Name', S.FirstName as 'Student Name',
                          FORMAT(DateOut, 'D', 'ru-RU') as 'Date Out' ,FORMAT(DateIn, 'D', 'ru-RU') as 'Date In', Id_Lib FROM S_Cards
                               JOIN Students as S ON S.Id = S_Cards.Id_Student
                               JOIN Books as B ON B.Id = S_Cards.Id_Book ";
            // Получить объект Connection подключенный к DB.
            var conn = DBUtils.GetDBConnection();
            try
            {
                AsyncQueryEmployee(conn, sql);
                Console.ReadKey();
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

        private static void QueryEmployee(SqlConnection conn, string sql)
        {
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows) return;
                    //Console.WriteLine($"{"Book Name:",-70} {"Pages:",-15} Comment:\n");
                    int cnt = 0;
                    while (reader.Read())
                    {
                        //Console.WriteLine($"{reader.GetString(1),-70} {reader.GetInt32(2),-15} {reader.GetString(8)}");
                        //Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");

                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Row {++cnt}");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string tmp = reader[i].ToString();
                            if (string.IsNullOrEmpty(tmp)) tmp = "Not Returned!";
                            Console.WriteLine($"{reader.GetName(i) + ":",-20}" + tmp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        async private static void AsyncQueryEmployee(SqlConnection conn, string sql)
        {
            await conn.OpenAsync();
           

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    //Console.WriteLine($"{"Book Name:",-70} {"Pages:",-15} Comment:\n");
                    int cnt = 0;
                    while (reader.Read())
                    {
                        //Console.WriteLine($"{reader.GetString(1),-70} {reader.GetInt32(2),-15} {reader.GetString(8)}");
                        //Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------");

                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"Row {++cnt}");
                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string tmp = reader[i].ToString();
                            if (string.IsNullOrEmpty(tmp)) tmp = "Not Returned!";
                            Console.WriteLine($"{reader.GetName(i) + ":",-20}" + tmp);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
