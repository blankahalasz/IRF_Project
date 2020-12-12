using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IRF_beadando
{
    public partial class Form1 : Form
    {

        Database2Entities context = new Database2Entities();
        public Form1()
        {
            InitializeComponent();
            listBoxEdzok.DisplayMember = "Nev";
            listBoxSportolok.DisplayMember = "SNev";
            listEdzok();


        }

        private void CreateChart()
        {
            var selectedsportolo = ((Sportolo)listBoxSportolok.SelectedItem).SFELH_NEV;
            var eredmeny = from x in context.Eredmenies
                           where x.SFELH_NEV_FK == selectedsportolo
                           select x;

            chartEredmenyek.DataSource = eredmeny.ToList();

            var series = chartEredmenyek.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Datum";
            series.YValueMembers = "Pont";

            var legend = chartEredmenyek.Legends[0];
            legend.Enabled = false;

            var chartArea = chartEredmenyek.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

        }

       

        public void listEdzok()
        {
            var edzok = (from x in context.Edzoes
                         select x).ToList();
            listBoxEdzok.DataSource = edzok;
        }

        private void TextBoxEdzok_TextChanged(object sender, EventArgs e)
        {
            listEdzok();
            string ed = textBoxEdzok.Text.ToLower();
            listBoxEdzok.DataSource = (from x in context.Edzoes
                                       where x.NEV.ToLower().Contains(ed) 
                                       select x).
                                       ToList();

        }

        private void ListBoxEdzok_SelectedIndexChanged(object sender, EventArgs e)
        {
            var edzo = ((Edzo)listBoxEdzok.SelectedItem).FELH_NEV;
            var sportolo = from x in context.Sportoloes
                           where x.EDZO_FK == edzo
                           select x;

            listBoxSportolok.DisplayMember = "SNEV";
            listBoxSportolok.DataSource = sportolo.ToList();
              
            
        }

        private void ButtonChart_Click(object sender, EventArgs e)
        {

            CreateChart();

        }

        private void ButtonUjEredemeny_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
