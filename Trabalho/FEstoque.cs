using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trabalho
{
    public partial class FEstoque : Form
    {
        public FEstoque()
        {
            InitializeComponent();
            /*
            //Limpar series
            chart1.Series.Clear();

            //Adicionar 2 Series
            chart1.Series.Add(new Series());
            chart1.Series.Add(new Series());




            //Titulo do gráfico
            chart1.Titles.Add("Estoque");
            //legenda do eico x
            chart1.ChartAreas[0].AxisX.Title = "Produto";
            //legenda do eico y
            chart1.ChartAreas[0].AxisY.Title = "Vendeu";
            //legenda da série
            chart1.Series[0].Name = "Quantidade vendida";

            chart1.Series[0].ChartType = SeriesChartType.Column;
            */
            //  chart1.Series[0].ChartType = SeriesChartType.Line;

            
            //Configurar serie 1
           // chart1.Series[1].Name = "Média";
           // chart1.Series[1].ChartType = SeriesChartType.Line;//Series são as linhas ou colunas, ou seja, são as informações, como cada matéria de um gráfico de boletim
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
