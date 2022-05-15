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
            string Createsql = "CREATE TABLE Tema(IdTema INT, Tema VARCHAR(75))";
            string Createsql1 = "CREATE TABLE Subtema(IdSubtema INT, Subtema VARCHAR(75), indexTema INT)";
            string Createsql2 = "CREATE TABLE Formula(IdFormula INT, Formula VARCHAR(75), indexTema INT)";

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
            /*
            string tablaTemas = "INSERT INTO Tema(IdTema, Tema) VALUES(1, 'Termodinamica'); ";
            string tablaTemas1 = "INSERT INTO Tema(IdTema, Tema) VALUES(2, 'Ondas'); ";
            string tablaTemas2 = "INSERT INTO Tema(IdTema, Tema) VALUES(3, 'Optica'); ";
            */

            string tablaSubtemas1 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(1, 'Movimiento periodico', 'Ondas'); ";
            string tablaSubtemas2 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(2, 'Movimiento armonico simple', 'Ondas'); ";
            string tablaSubtemas3 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(3, 'Energia en movimiento armonico simple', 'Ondas'); ";
            string tablaSubtemas4 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(4, 'Movimiento armonico simple angular', 'Ondas'); ";
            string tablaSubtemas5 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(5, 'Pendulo simple', 'Ondas'); ";
            string tablaSubtemas6 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(6, 'Pendulo físico', 'Ondas'); ";
            string tablaSubtemas7 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(7, 'Oscilaciones amortiguadas', 'Ondas'); ";
            string tablaSubtemas8 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(8, 'Oscilaciones impulsadas y resonancia', 'Ondas'); ";


            string tablaSubtemas9 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(9, 'Temperatura y escalas de temperatura', 'Termodinamica'); ";
            string tablaSubtemas10 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(10, 'Expansion termica y esfuerzo termico', 'Termodinamica'); ";
            string tablaSubtemas11 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(11, 'Calor, cambios de fase y calorimetria', 'Termodinamica'); ";
            string tablaSubtemas12 = "INSERT INTO Subtema(IdSubtema, Subtema, Tema) VALUES(12, 'Conducción, convección y radiación', 'Termodinamica'); ";


            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = tablaSubtemas1;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas2;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas3;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas4;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas5;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas6;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas7;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas8;
            sqlite_cmd.ExecuteNonQuery();

            sqlite_cmd.CommandText = tablaSubtemas9;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas10;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas11;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = tablaSubtemas12;
            sqlite_cmd.ExecuteNonQuery();
        }

        public static void ReadData(SQLiteConnection conn)
        {
            string myreader;
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Tema";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                myreader = sqlite_datareader.GetString(1);
            }
            conn.Close();
        }
    }
}
