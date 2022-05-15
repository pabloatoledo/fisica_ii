using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisica_II
{
    public partial class Fisica_II : Form
    {
        //ctrlLista lista = new ctrlLista();

        public Fisica_II()
        {
            InitializeComponent();

        }

        private void Fisica_II_Load(object sender, EventArgs e)
        {
            //DB.CreateTable(DB.CreateConnection());    //Genera la tabla y el archivo menus.db
            DB.InsertData(DB.CreateConnection());       //Inserta la info en la db
            cmbTema.Items.Clear();
            cargaTemas(DB.CreateConnection());
        }

        private void actSubtemas(object sender, EventArgs e)
        {
            cmbSubtema.Items.Clear();
            cargaSubtemas(DB.CreateConnection());
        }

        private void cargaTemas(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Tema";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string tema = sqlite_datareader.GetString(1);
                cmbTema.Items.Add(tema);
            }
            conn.Close();
        }

        private void cargaSubtemas(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Subtema where Tema = '" + cmbTema.SelectedItem.ToString() + "'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string subtema = sqlite_datareader.GetString(1);
                cmbSubtema.Items.Add(subtema);
            }
            conn.Close();
        }


    }

}
