using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisica_II
{
    class DB
    {
        /*static void Main(string[] args)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn);
        }*/

        

        public static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=menus.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        public static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE Tema(IdTema INT, Tema VARCHAR(20))";
            string Createsql1 = "CREATE TABLE Subtema(IdSubtema INT, Subtema VARCHAR(20), indexTema INT)";
            string Createsql2 = "CREATE TABLE Formula(IdFormula INT, Formula VARCHAR(50), indexTema INT)";

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql2;
            sqlite_cmd.ExecuteNonQuery();

        }

        public static void InsertData(SQLiteConnection conn)
        {
            string tablaTemas = "INSERT INTO Tema(IdTema, Tema) VALUES(1, 'Termodinamica'); ";
            string tablaTemas1 = "INSERT INTO Tema(IdTema, Tema) VALUES(2, 'Ondas'); ";
            string tablaTemas2 = "INSERT INTO Tema(IdTema, Tema) VALUES(3, 'Optica'); ";


            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = tablaTemas;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaTemas1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaTemas2;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void ReadData(SQLiteConnection conn)
        {
            ctrlLista lista = new ctrlLista();

            string myreader;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Tema";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                myreader = sqlite_datareader.GetString(1);
                lista.ltemas.Add(myreader);
            }
            conn.Close();
        }
    }
}
