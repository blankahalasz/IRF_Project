using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadando
{
    public partial class Form3 : Form
    {
        Database2Entities context = new Database2Entities();
        BindingList<Eredmeny> er = new BindingList<Eredmeny>();
        public Form3()
        {
            InitializeComponent();
            context.Eredmenies.Load();
            eredmenyBindingSource.DataSource = context.Eredmenies.Local;
        }

        private void ButtonMentes_Click(object sender, EventArgs e)
        {
            
            Eredmeny ed = new Eredmeny();

            string Sfelh = textBoxSFelhnev.Text.ToString();
            ed.SFELH_NEV_FK = Sfelh;
            string Felhnev = textBoxFelhnev.Text.ToString();
            ed.EDZO_FELH_NEV_FK = Felhnev;
            string Datum = textBoxDatum.Text.ToString();
            ed.DATUM = Convert.ToDateTime(Datum);
            string Pont = textBoxPont.Text.ToString();
            ed.PONT = Convert.ToInt32(Pont);
            context.Eredmenies.Add(ed);
            
            try
            {
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dataGridViewEredmeny.Refresh();
            
        }
    }
}
