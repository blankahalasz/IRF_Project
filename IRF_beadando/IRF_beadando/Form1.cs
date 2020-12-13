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
        public List<Bullet> _bullets = new List<Bullet>();

        private BulletFactory _factory;
        public BulletFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }
        public Form1()
        {
            InitializeComponent();
            listBoxEdzok.DisplayMember = "Nev";
            listBoxSportolok.DisplayMember = "SNev";
            listBoxEredmenyek.DisplayMember = "Pont";
            listEdzok();
            Factory = new BulletFactory();



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
            series.XValueMember = ("Datum");
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

        private void ListBoxSportolok_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sportolo = ((Sportolo)listBoxSportolok.SelectedItem).SFELH_NEV;
            var eredmeny = from x in context.Eredmenies
                           where x.SFELH_NEV_FK == sportolo
                           select x;

            listBoxEredmenyek.DisplayMember = "PONT";
            listBoxEredmenyek.DataSource = eredmeny.ToList();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
            {
                DrawImage(e.Graphics);
            }
        }
        public void DrawImage(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 5);
            g.FillEllipse(new SolidBrush(Color.Black), 450, 0, 30, 30);
            g.FillRectangle(new SolidBrush(Color.Black), 450, 30, 30, 50);
            g.DrawLine(pen, 450, 40, 420, 50);
            g.DrawLine(pen, 478, 40, 510, 50);
            g.DrawLine(pen, 460, 80, 460, 110);
            g.DrawLine(pen, 470, 80, 470, 110);
            Image imageFile = Image.FromFile("Images/gun.png");
            g.DrawImage(imageFile, new Rectangle(-30, -5, 80, 50));

           

        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var bullet = Factory.CreateNew();
            _bullets.Add(bullet);
            bullet.Left = 48;
            panel1.Controls.Add(bullet);
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var bullet in _bullets)
            {
                bullet.MoveBullet();
                if (bullet.Left > maxPosition)
                {
                    maxPosition = bullet.Left;
                }
                   
            }

            if (maxPosition > 448)
            {
                var oldestBullet = _bullets[0];
                panel1.Controls.Remove(oldestBullet);
                _bullets.Remove(oldestBullet);
            }
        }
    }
}
