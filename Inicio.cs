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
        private int Valores, Formula, contHisto;
        private string unidad;
        private DataTable dt;     //usada para el datagridview con historicos

        public Fisica_II()
        {
            InitializeComponent();
        }           

        private void Fisica_II_Load(object sender, EventArgs e)
        {
            //DB.CreateTable(DB.CreateConnection());    //Genera la tabla y el archivo menus.db
            //DB.InsertData(DB.CreateConnection());       //Inserta la info en la db
            cmbTema.Items.Clear();
            cargaTemas(DB.CreateConnection());


            dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Formula");
            dt.Columns.Add("Resultado");
            dgvAnteriores.DataSource = dt;
        }

        private void actSubtemas(object sender, EventArgs e)
        {
            cmbSubtema.Items.Clear();
            cargaSubtemas(DB.CreateConnection());
        }

        private void actFormulas(object sender, EventArgs e)
        {
            cmbFormula.Items.Clear();
            cargaFormula(DB.CreateConnection());
            listaCoeficientes(cmbSubtema.SelectedItem.ToString(), DB.CreateConnection());
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
            ocultaValores();
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
            ocultaValores();
        }

        private void cargaFormula(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Formula where Subtema = '" + cmbSubtema.SelectedItem.ToString() + "'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string formula = sqlite_datareader.GetString(1);
                cmbFormula.Items.Add(formula);
            }
            conn.Close();
            ocultaValores();
        }

        private void consValores(SQLiteConnection conn)
        {
            ocultaValores();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Formula where Formula = '" + cmbFormula.SelectedItem.ToString() + "'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                Formula = sqlite_datareader.GetInt32(0);    //determina la formula para poder hacer el calculo
                Valores = sqlite_datareader.GetInt32(3);    //determina la cantidad de valores que tiene para mostrar labels y textbox
                unidad = sqlite_datareader.GetString(10);   //determina la unidad del resultado y la carga en el txtResultado
                lblVal1.Text = sqlite_datareader.GetString(4);  //carga los nombres de los labels desde la DB
                lblVal2.Text = sqlite_datareader.GetString(5);
                lblVal3.Text = sqlite_datareader.GetString(6);
                lblVal4.Text = sqlite_datareader.GetString(7);
                lblVal5.Text = sqlite_datareader.GetString(8);
                lblVal6.Text = sqlite_datareader.GetString(9);
            }
            conn.Close();
        }

        private void muestraFormula(object sender, EventArgs e)
        {
            lblFinal.Visible = true;
            txtFinal.Visible = true;
            consValores(DB.CreateConnection());

            switch (Valores)
            {
                case 1:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    break;

                case 2:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    lblVal2.Visible = true;
                    txtVal2.Visible = true;
                    break;

                case 3:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    lblVal2.Visible = true;
                    txtVal2.Visible = true;
                    lblVal3.Visible = true;
                    txtVal3.Visible = true;
                    break;

                case 4:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    lblVal2.Visible = true;
                    txtVal2.Visible = true;
                    lblVal3.Visible = true;
                    txtVal3.Visible = true;
                    lblVal4.Visible = true;
                    txtVal4.Visible = true;
                    break;

                case 5:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    lblVal2.Visible = true;
                    txtVal2.Visible = true;
                    lblVal3.Visible = true;
                    txtVal3.Visible = true;
                    lblVal4.Visible = true;
                    txtVal4.Visible = true;
                    lblVal5.Visible = true;
                    txtVal5.Visible = true;
                    break;

                case 6:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    lblVal2.Visible = true;
                    txtVal2.Visible = true;
                    lblVal3.Visible = true;
                    txtVal3.Visible = true;
                    lblVal4.Visible = true;
                    txtVal4.Visible = true;
                    lblVal5.Visible = true;
                    txtVal5.Visible = true;
                    lblVal6.Visible = true;
                    txtVal6.Visible = true;
                    break;
            }
        }

        private void ocultaValores()
        {
            lblVal1.Visible = false;
            txtVal1.Visible = false;
            lblVal2.Visible = false;
            txtVal2.Visible = false;
            lblVal3.Visible = false;
            txtVal3.Visible = false;
            lblVal4.Visible = false;
            txtVal4.Visible = false;
            lblVal5.Visible = false;
            txtVal5.Visible = false;
            lblVal6.Visible = false;
            txtVal6.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            switch (Formula)
            {
                case 1:
                    double Tk = double.Parse(txtVal1.Text);
                    double Tf = (9.0 / 5.0) * (Tk - 273.15) + 32;
                    txtFinal.Text = Tf.ToString() + " " + unidad;
                    break;

                case 2:
                    double Tc = double.Parse(txtVal1.Text);
                    Tf = (9.0 / 5.0) * Tc + 32;
                    txtFinal.Text = Tf.ToString() + " " + unidad;
                    break;

                case 3:
                    Tf = double.Parse(txtVal1.Text);
                    Tc = (5.0 / 9.0) * (Tf - 32);
                    txtFinal.Text = Tc.ToString() + " " + unidad;
                    break;

                case 4:
                    Tk = double.Parse(txtVal1.Text);
                    Tc = Tk - 273.15;
                    txtFinal.Text = Tc.ToString() + " " + unidad;
                    break;

                case 5:
                    Tc = double.Parse(txtVal1.Text);
                    Tk = Tc + 273.15;
                    txtFinal.Text = Tk.ToString() + " " + unidad;
                    break;

                case 6:
                    Tf = double.Parse(txtVal1.Text);
                    Tk = (5.0 / 9.0) * (Tf - 32) + 273.15;
                    txtFinal.Text = Tk.ToString() + " " + unidad;
                    break;
            }
            llenaDataGrid();
        }

        private void llenaDataGrid()
        {
            DataRow row = dt.NewRow();
            row["Id"] = contHisto;
            row["Formula"] = cmbFormula.SelectedItem.ToString();
            row["Resultado"] = txtFinal.Text.ToString();
            dt.Rows.Add(row);
            contHisto++;
        }

        private void listaCoeficientes (string subtema, SQLiteConnection conn)
        {
            if (subtema == "Dilatacion materiales lineal")
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CoefExpLineal";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string materiales = sqlite_datareader.GetString(1);
                    cmbCoef.Items.Add(materiales);
                }
                conn.Close();
            }
        }
    }
}
