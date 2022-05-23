using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisica_II
{
    public partial class Ondas : Form
    {
        private double A, k, w, x;
        private DataTable dt;

        public Ondas(double _x, double _A, double _k, double _w)
        {
            InitializeComponent();
            x = _x;
            A = _A;
            k = _k;
            w = _w;
        }
        
        private void Ondas_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("t");
            dt.Columns.Add("A cos ( k x  - w t )");
            dgvTabla.DataSource = dt;

            chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            calculaTabla();
        }

        private void calculaTabla()
        {
            for (int t = 1; t < 11; t++)
            {
                double resultado = A * Math.Cos((k * x) - (w * t));

                DataRow row = dt.NewRow();
                row["t"] = t;
                row["A cos ( k x  - w t )"] = resultado;
                dt.Rows.Add(row);
                //grafica(t, resultado);
            }
        }

        private void grafica (int t, double resultado)
        {
            chart1.Series["Series1"].Points.AddXY(t, resultado);
        }
    }
}
