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
        private double coef, TempSustFus, TempSustEvap;
        private string unidad, cmbVal1, cmbVal2, cmbVal3, cmbVal4, cmbVal5;
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
            cargaFases(DB.CreateConnection());


            dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Formula");
            dt.Columns.Add("Resultado");
            dgvAnteriores.DataSource = dt;
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

        private void cargaFases(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM CalFusVap";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string tema = sqlite_datareader.GetString(1);
                cmbSust.Items.Add(tema);
            }
            conn.Close();
        }

        private void actSustFases(object sender, EventArgs e)
        {
            SQLiteConnection conn = DB.CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM CalFusVap where Sustancia = '" + cmbSust.SelectedItem.ToString() + "'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                TempSustFus = sqlite_datareader.GetDouble(2);
                TempSustEvap = sqlite_datareader.GetDouble(4);
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
            ocultaValores();
        }

        private void actSubtemas(object sender, EventArgs e)
        {
            cmbCoef.Visible = false;
            cmbSubtema.Items.Clear();
            cargaSubtemas(DB.CreateConnection());
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

        private void actFormulas(object sender, EventArgs e)
        {
            cmbFormula.Items.Clear();
            cmbCoef.Visible = false;
            cargaFormula(DB.CreateConnection());
            listaCoeficientes(cmbSubtema.SelectedItem.ToString(), DB.CreateConnection());
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
                    cmbConv1.Visible = true;
                    break;

                case 2:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    lblVal2.Visible = true;
                    txtVal2.Visible = true;
                    showcmbVal2();
                    break;

                case 3:
                    lblVal1.Visible = true;
                    txtVal1.Visible = true;
                    lblVal2.Visible = true;
                    txtVal2.Visible = true;
                    lblVal3.Visible = true;
                    txtVal3.Visible = true;
                    showcmbVal2();
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
                    showcmbVal2();
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
                    showcmbVal2();
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

        private void listaCoeficientes(string subtema, SQLiteConnection conn)
        {
            cmbCoef.Items.Clear();
            cmbCoefCal.Items.Clear();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            if (subtema == "Dilatacion materiales lineal" || subtema == "Dilatacion materiales por volumen")
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CoefExpLineal";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string materiales = sqlite_datareader.GetString(1);
                    cmbCoef.Items.Add(materiales);
                }
                conn.Close();
                cmbCoef.Visible = true;
            }
            if (subtema == "Calorimetria sin cambio de fase")
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CalorEspecifico";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string sustancias = sqlite_datareader.GetString(1);
                    cmbCoefCal.Items.Add(sustancias);
                }
                conn.Close();
                cmbCoefCal.Visible = true;
            }
            if (subtema == "Calorimetria con cambio de fase")
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CalFusVap";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string sustancias = sqlite_datareader.GetString(1);
                    cmbCoefCal.Items.Add(sustancias);
                }
                conn.Close();
                cmbCoefCal.Visible = true;
            }

            if (subtema == "Conduccion de calor") 
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CondTermicas";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string sustancias = sqlite_datareader.GetString(1);
                    cmbCoefCal.Items.Add(sustancias);
                }
                conn.Close();
                cmbCoefCal.Visible = true;
            }
        }

        private void actCoef(object sender, EventArgs e)
        {
            SQLiteConnection conn = DB.CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            if (cmbSubtema.SelectedItem.ToString() == "Dilatacion materiales lineal" || cmbSubtema.SelectedItem.ToString() == "Dilatacion materiales por volumen")
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CoefExpLineal where Material = '" + cmbCoef.SelectedItem.ToString() + "'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {

                    double coe = sqlite_datareader.GetDouble(2);
                    coef = coe;
                    if (cmbSubtema.Text == "Dilatacion materiales por volumen")
                    {
                        coef = coe * 3;
                    }
                    txtVal1.Text = coef.ToString();
                }
            }
            
            if (cmbSubtema.SelectedItem.ToString() == "Calorimetria sin cambio de fase")
            {
                double calorEsp;

                if (cmbFormula.SelectedItem.ToString() == "Q = n.C.dT" || cmbFormula.SelectedItem.ToString() == "n = Q / (C.dT)" || cmbFormula.SelectedItem.ToString() == "dT = Q / (n.C)")
                {
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM CalorEspecifico where Sustancia = '" + cmbCoefCal.SelectedItem.ToString() + "'";
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    while (sqlite_datareader.Read())
                    {
                        calorEsp = sqlite_datareader.GetDouble(4);
                        txtVal1.Text = calorEsp.ToString();
                    }
                }
                else
                {
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM CalorEspecifico where Sustancia = '" + cmbCoefCal.SelectedItem.ToString() + "'";
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    while (sqlite_datareader.Read())
                    {
                        calorEsp = sqlite_datareader.GetDouble(2);
                        txtVal1.Text = calorEsp.ToString();
                    }
                }
            }

            if (cmbFormula.SelectedItem.ToString() == "Q = m.L (fusion)" || cmbFormula.SelectedItem.ToString() == "Q = - (m.L) (fusion)")
            {

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CalFusVap where Sustancia = '" + cmbCoefCal.SelectedItem.ToString() + "'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    double Lf = sqlite_datareader.GetDouble(3);
                    txtVal1.Text = Lf.ToString();
                }
            }

            if (cmbFormula.SelectedItem.ToString() == "Q = m.L (ebullicion)" || cmbFormula.SelectedItem.ToString() == "Q = - (m.L) (ebullicion)")
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CalFusVap where Sustancia = '" + cmbCoefCal.SelectedItem.ToString() + "'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    double Lv = sqlite_datareader.GetDouble(5);
                    txtVal1.Text = Lv.ToString();
                }
            }

            if (cmbSubtema.SelectedItem.ToString() == "Conduccion de calor")
            {
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM CondTermicas where Sustancia = '" + cmbCoefCal.SelectedItem.ToString() + "'";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    double k = sqlite_datareader.GetDouble(2);
                    txtVal1.Text = k.ToString();
                }
            }

            conn.Close();
        }

        private void faseSust(object sender, EventArgs e)
        {
            try
            {
                double tempActual = double.Parse(txtTemp.Text);            
                if (tempActual >= TempSustEvap)
                {
                    lblEstado.Text = "Gaseoso";
                }
                else
                {
                    if (tempActual < TempSustFus)
                    {
                        lblEstado.Text = "Sólido";
                    }
                    else
                    {
                        lblEstado.Text = "Líquido";
                    }
                }
            }
            catch
            {}
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Tk, Tf, Tc, dL, a, L0, dT, L, T0, T, b, V0, V, dV, c, Q, m, C, n, Q1, Q2, H, dQ, k, A, Th, em, _x, _A, _k, _w;
            double o = 0.000000056704;

            switch (Formula)
            {
                case 1:
                    Tk = double.Parse(txtVal1.Text);
                    Tf = (9.0 / 5.0) * (Tk - 273.15) + 32;
                    txtFinal.Text = Tf.ToString() + " " + unidad;
                    break;

                case 2:
                    Tc = double.Parse(txtVal1.Text);
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

                case 7:
                    a = double.Parse(txtVal1.Text);
                    L0 = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    dL = a * L0 * dT;
                    txtFinal.Text = dL.ToString() + " " + unidad;
                    break;

                case 8:
                    a = double.Parse(txtVal1.Text);
                    L0 = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    L = L0 + (a * L0 * dT);
                    txtFinal.Text = L.ToString() + " " + unidad;
                    break;

                case 9:
                    a = double.Parse(txtVal1.Text);
                    dL = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    L0 = dL / (a * dT);
                    txtFinal.Text = L0.ToString() + " " + unidad;
                    break;

                case 10:
                    a = double.Parse(txtVal1.Text);
                    dL = double.Parse(txtVal2.Text);
                    L0 = double.Parse(txtVal3.Text);
                    dT = dL / (a * L0);
                    txtFinal.Text = dT.ToString() + " " + unidad;
                    break;

                case 11:
                    a = double.Parse(txtVal1.Text);
                    T0 = double.Parse(txtVal2.Text);
                    dL = double.Parse(txtVal3.Text);
                    L0 = double.Parse(txtVal4.Text);
                    T = T0 + (dL / (a * L0));
                    txtFinal.Text = T.ToString() + " " + unidad;
                    break;

                case 12:
                    a = double.Parse(txtVal1.Text);
                    T = double.Parse(txtVal2.Text);
                    dL = double.Parse(txtVal3.Text);
                    L0 = double.Parse(txtVal4.Text);
                    T0 = T - (dL / (a * L0));
                    txtFinal.Text = T0.ToString() + " " + unidad;
                    break;

                case 13:
                    b = double.Parse(txtVal1.Text);
                    V0 = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    dV = b * V0 * dT;
                    txtFinal.Text = dV.ToString() + " " + unidad;
                    break;

                case 14:
                    b = double.Parse(txtVal1.Text);
                    V0 = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    V = V0 + (b * V0 * dT);
                    txtFinal.Text = V.ToString() + " " + unidad;
                    break;

                case 15:
                    b = double.Parse(txtVal1.Text);
                    dV = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    V0 = dV / (b * dT);
                    txtFinal.Text = V0.ToString() + " " + unidad;
                    break;

                case 16:
                    b = double.Parse(txtVal1.Text);
                    dV = double.Parse(txtVal2.Text);
                    V0 = double.Parse(txtVal3.Text);
                    dT = dV / (b * V0);
                    txtFinal.Text = dT.ToString() + " " + unidad;
                    break;

                case 17:
                    b = double.Parse(txtVal1.Text);
                    T0 = double.Parse(txtVal2.Text);
                    dV = double.Parse(txtVal3.Text);
                    V0 = double.Parse(txtVal4.Text);
                    T = T0 + (dV / (b * V0));
                    txtFinal.Text = T.ToString() + " " + unidad;
                    break;

                case 18:
                    b = double.Parse(txtVal1.Text);
                    T = double.Parse(txtVal2.Text);
                    dV = double.Parse(txtVal3.Text);
                    V0 = double.Parse(txtVal4.Text);
                    T0 = T - (dV / (b * V0));
                    txtFinal.Text = T0.ToString() + " " + unidad;
                    break;

                case 19:
                    c = double.Parse(txtVal1.Text);
                    m = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    Q = m * c * dT;
                    txtFinal.Text = Q.ToString() + " " + unidad;
                    break;

                case 20:
                    c = double.Parse(txtVal1.Text);
                    Q = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    m = Q / (c * dT);
                    txtFinal.Text = m.ToString() + " " + unidad;
                    break;

                case 21:
                    c = double.Parse(txtVal1.Text);
                    Q = double.Parse(txtVal2.Text);
                    m = double.Parse(txtVal3.Text);
                    dT = Q / (c * m);
                    txtFinal.Text = dT.ToString() + " " + unidad;
                    break;

                case 22:
                    C = double.Parse(txtVal1.Text);
                    n = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    Q = n * C * dT;
                    txtFinal.Text = Q.ToString() + " " + unidad;
                    break;

                case 23:
                    C = double.Parse(txtVal1.Text);
                    Q = double.Parse(txtVal2.Text);
                    dT = double.Parse(txtVal3.Text);
                    n = Q / (C * dT);
                    txtFinal.Text = n.ToString() + " " + unidad;
                    break;

                case 24:
                    C = double.Parse(txtVal1.Text);
                    Q = double.Parse(txtVal2.Text);
                    n = double.Parse(txtVal3.Text);
                    dT = Q / (C * n);
                    txtFinal.Text = dT.ToString() + " " + unidad;
                    break;

                case 25:
                    c = double.Parse(txtVal1.Text);
                    m = double.Parse(txtVal2.Text);
                    Q = double.Parse(txtVal3.Text);
                    T0 = double.Parse(txtVal4.Text);
                    T = (Q / (m * c)) + T0;
                    txtFinal.Text = T.ToString() + " " + unidad;
                    break;

                case 26:
                    c = double.Parse(txtVal1.Text);
                    m = double.Parse(txtVal2.Text);
                    Q = double.Parse(txtVal3.Text);
                    T = double.Parse(txtVal4.Text);
                    T0 = T - (Q / (m * c));
                    txtFinal.Text = T0.ToString() + " " + unidad;
                    break;

                case 27:
                    L = double.Parse(txtVal1.Text);
                    m = double.Parse(txtVal2.Text);
                    Q = m * L;
                    txtFinal.Text = Q.ToString() + " " + unidad;
                    break;

                case 28:
                    L = double.Parse(txtVal1.Text);
                    m = double.Parse(txtVal2.Text);
                    Q = -1 * (m * L);
                    txtFinal.Text = Q.ToString() + " " + unidad;
                    break;

                case 29:
                    L = double.Parse(txtVal1.Text);
                    m = double.Parse(txtVal2.Text);
                    Q = m * L;
                    txtFinal.Text = Q.ToString() + " " + unidad;
                    break;

                case 30:
                    L = double.Parse(txtVal1.Text);
                    m = double.Parse(txtVal2.Text);
                    Q = -1 * (m * L);
                    txtFinal.Text = Q.ToString() + " " + unidad;
                    break;

                case 31:
                    Q1 = double.Parse(txtVal1.Text);
                    Q2 = double.Parse(txtVal2.Text);
                    Q = Q1 + Q2;
                    txtFinal.Text = Q.ToString() + " " + unidad;
                    break;

                case 32:
                    Q = double.Parse(txtVal1.Text);
                    Q1 = double.Parse(txtVal2.Text);
                    Q2 = Q - Q1;
                    txtFinal.Text = Q2.ToString() + " " + unidad;
                    break;

                case 33:
                    dQ = double.Parse(txtVal1.Text);
                    dT = double.Parse(txtVal2.Text);
                    H = dQ + dT;
                    txtFinal.Text = H.ToString() + " " + unidad;
                    break;

                case 34:
                    k = double.Parse(txtVal1.Text);
                    A = double.Parse(txtVal2.Text);
                    Th = double.Parse(txtVal3.Text);
                    Tc = double.Parse(txtVal4.Text);
                    L = double.Parse(txtVal5.Text);
                    H = k * A * ((Th - Tc) / L);
                    txtFinal.Text = H.ToString() + " " + unidad;
                    break;

                case 35:
                    k = double.Parse(txtVal1.Text);
                    H = double.Parse(txtVal2.Text);
                    Th = double.Parse(txtVal3.Text);
                    Tc = double.Parse(txtVal4.Text);
                    L = double.Parse(txtVal5.Text);
                    A = H / (k * (Th - Tc) / L);
                    txtFinal.Text = A.ToString() + " " + unidad;
                    break;

                case 36:
                    k = double.Parse(txtVal1.Text);
                    H = double.Parse(txtVal2.Text);
                    L = double.Parse(txtVal3.Text);
                    A = double.Parse(txtVal4.Text);
                    Tc = double.Parse(txtVal5.Text);
                    Th = ((H * L) / (k * A)) + Tc;
                    txtFinal.Text = Th.ToString() + " " + unidad;
                    break;

                case 37:
                    k = double.Parse(txtVal1.Text);
                    H = double.Parse(txtVal2.Text);
                    L = double.Parse(txtVal3.Text);
                    A = double.Parse(txtVal4.Text);
                    Th = double.Parse(txtVal5.Text);
                    Tc = Th - ((H * L) / (k * A));
                    txtFinal.Text = Tc.ToString() + " " + unidad;
                    break;

                case 38:
                    A = double.Parse(txtVal1.Text);
                    em = double.Parse(txtVal2.Text);
                    T = double.Parse(txtVal3.Text);
                    H = A * em * o * Math.Pow(T, 4);
                    txtFinal.Text = H.ToString() + " " + unidad;
                    break;

                case 39:
                    H = double.Parse(txtVal1.Text);
                    em = double.Parse(txtVal2.Text);
                    T = double.Parse(txtVal3.Text);
                    A = H / (em * o * Math.Pow(T, 4));
                    txtFinal.Text = A.ToString() + " " + unidad;
                    break;

                case 40:
                    H = double.Parse(txtVal1.Text);
                    A = double.Parse(txtVal2.Text);
                    T = double.Parse(txtVal3.Text);
                    em = H / (A * o * Math.Pow(T, 4));
                    txtFinal.Text = em.ToString() + " " + unidad;
                    break;

                case 41:
                    H = double.Parse(txtVal1.Text);
                    A = double.Parse(txtVal2.Text);
                    em = double.Parse(txtVal3.Text);
                    T = Math.Sqrt(Math.Sqrt(H / (A * o * em)));
                    txtFinal.Text = T.ToString() + " " + unidad;
                    break;

                case 42:
                    _x = double.Parse(txtVal1.Text);
                    _A = double.Parse(txtVal2.Text);
                    _k = double.Parse(txtVal3.Text);
                    _w = double.Parse(txtVal3.Text);
                    Ondas ondas = new Ondas(_x, _A, _k, _w);
                    ondas.Show();
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

        private void ocultaValores()
        {
            lblVal1.Visible = false;
            txtVal1.Visible = false;
            cmbConv1.Visible = false;
            txtVal1.Text = "";
            lblVal2.Visible = false;
            txtVal2.Visible = false;
            cmbConv2.Visible = false;
            txtVal2.Text = "";
            lblVal3.Visible = false;
            txtVal3.Visible = false;
            cmbConv3.Visible = false;
            txtVal3.Text = "";
            lblVal4.Visible = false;
            txtVal4.Visible = false;
            cmbConv4.Visible = false;
            txtVal4.Text = "";
            lblVal5.Visible = false;
            txtVal5.Visible = false;
            cmbConv5.Visible = false;
            txtVal5.Text = "";
            lblVal6.Visible = false;
            txtVal6.Visible = false;
            cmbConv6.Visible = false;
            txtVal6.Text = "";
            //cmbCoef.Visible = false;
        }

        //------------------- cmb conversores ----------------------------

        private void showcmbVal2()
        {
            if (lblVal2.Text == "L0 (en m)" || lblVal2.Text == "dL (en m)")
            {
                cmbConv2.Visible = true;
                cmbConv2.Items.Clear();
                cmbConv2.Items.Add("m");
                cmbConv2.Items.Add("mm");
                cmbConv2.Items.Add("km");
                cmbVal2 = "longitud";
            }
            if (lblVal2.Text == "T0 (en ºC)" || lblVal2.Text == "T (en ºC)")
            {
                cmbConv2.Visible = true;
                cmbConv2.Items.Clear();
                cmbConv2.Items.Add("ºC");
                cmbConv2.Items.Add("K");
                cmbConv2.Items.Add("ºF");
                cmbVal2 = "temperatura";
            }
            if (lblVal2.Text == "V0 (en m3)")
            {
                cmbConv2.Visible = true;
                cmbConv2.Items.Clear();
                cmbConv2.Items.Add("m3");
                cmbConv2.Items.Add("cm3");
                cmbVal2 = "volumen";
            }
            if (lblVal2.Text == "m (en kg)")
            {
                cmbConv2.Visible = true;
                cmbConv2.Items.Clear();
                cmbConv2.Items.Add("kg");
                cmbConv2.Items.Add("g");
                cmbConv2.Items.Add("mg");
                cmbVal2 = "masa";
            }
            if (lblVal2.Text == "Q (en J)")
            {
                cmbConv2.Visible = true;
                cmbConv2.Items.Clear();
                cmbConv2.Items.Add("J");
                cmbConv2.Items.Add("cal");
                cmbConv2.Items.Add("kcal");
                cmbConv2.Items.Add("Btu");
                cmbVal2 = "calor";
            }
            if (lblVal2.Text == "A (en m2)")
            {
                cmbConv2.Visible = true;
                cmbConv2.Items.Clear();
                cmbConv2.Items.Add("m2");
                cmbConv2.Items.Add("cm2");
                cmbConv2.Items.Add("km2");
                cmbVal2 = "superficie";
            }
        }

        private void convVal2(object sender, EventArgs e)
        {
            if (cmbVal2 == "longitud")
            {
                if(cmbConv2.SelectedItem.ToString()=="mm")
                {
                    txtVal2.Text = mmTom(double.Parse(txtVal2.Text)).ToString();
                }
                if (cmbConv2.SelectedItem.ToString() == "km")
                {
                    txtVal2.Text = kmTom(double.Parse(txtVal2.Text)).ToString();
                }
            }
            if (cmbVal2 == "temperatura")
            {
                if (cmbConv2.SelectedItem.ToString() == "K")
                {
                    txtVal2.Text = kToc(double.Parse(txtVal2.Text)).ToString();
                }
                if (cmbConv2.SelectedItem.ToString() == "ºF")
                {
                    txtVal2.Text = fToc(double.Parse(txtVal2.Text)).ToString();
                }
            }
            if (cmbVal2 == "masa")
            {
                if (cmbConv2.SelectedItem.ToString() == "mg")
                {
                    txtVal2.Text = mgTokg(double.Parse(txtVal2.Text)).ToString();
                }
                if (cmbConv2.SelectedItem.ToString() == "g")
                {
                    txtVal2.Text = gTokg(double.Parse(txtVal2.Text)).ToString();
                }
            }
        }

        //------------------- conversiones -------------------------------

        private double mmTom (double mm)
        {
            double m = mm / 1000;
            return m;
        }

        private double kmTom (double km)
        {
            double m = km * 1000;
            return m;
        }

        private double kToc (double k)
        {
            double c = k - 273.15;
            return c;
        }

        private double fToc(double f)
        {
            double c = (5.0 / 9.0) * (f - 32);
            return c;
        }

        private double mgTokg(double mg)
        {
            double kg = mg / 1000000;
            return kg;
        }

        private double gTokg(double g)
        {
            double kg = g / 1000;
            return kg;
        }
    }
}
