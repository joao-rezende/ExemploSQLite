using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace ExemploSQLite.Classes
{
    internal class BD
    {
        private static SQLiteConnection conexao = null;

        public static SQLiteConnection Conexao()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\Joao\\source\\repos\\ExemploSQLite\\ExemploSQLite\\bd\\exemplo.db");
            conexao.Open();

            return conexao;
        }

        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM usuarios";
                    adapter = new SQLiteDataAdapter(cmd.CommandText, Conexao());
                    adapter.Fill(dt);
                    Conexao().Close();

                    return dt;
                }
            } catch (Exception ex)
            {
                Conexao().Close();
                throw ex;
            }
        }

        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter adapter = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao().CreateCommand())
                {
                    cmd.CommandText = sql;
                    adapter = new SQLiteDataAdapter(cmd.CommandText, Conexao());
                    adapter.Fill(dt);
                    Conexao().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Conexao().Close();
                throw ex;
            }
        }
    }
}
