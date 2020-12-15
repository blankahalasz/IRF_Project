using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadando
{
    public partial class Form3 : Form
    {
        Database2Entities context = new Database2Entities();
        public Form3()
        {
            InitializeComponent();
            context.Eredmenies.Load();
            eredmenyBindingSource.DataSource = context.Eredmenies.Local;
            dataGridViewEredmeny.Columns[5].Visible = false;
            dataGridViewEredmeny.Columns[6].Visible = false;
        }
        private void TextBoxSFelhnev_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxSFelhnev.Text))
            {
                var sfelhasznalo = (from x in context.Sportoloes
                                    where textBoxSFelhnev.Text == x.SFELH_NEV
                                    select x).FirstOrDefault();

                if (sfelhasznalo != null)
                {
                    textBoxSFelhnev.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév");
                }


            }

            else
            {
                e.Cancel = true;
                textBoxSFelhnev.BackColor = Color.LightCoral;
            }
        }

        private void TextBoxFelhnev_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxFelhnev.Text))
            {
                var felhasznalo = (from x in context.Edzoes
                                   where textBoxFelhnev.Text == x.FELH_NEV
                                   select x).FirstOrDefault();

                if (felhasznalo != null)
                {
                    textBoxFelhnev.BackColor = Color.LightGreen;
                }
                else
                {
                    MessageBox.Show("Hibás felhasználónév");
                }


            }

            else
            {
                e.Cancel = true;
                textBoxFelhnev.BackColor = Color.LightCoral;
            }
        }

        private void TextBoxDatum_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex("(19|20)[0-9]{2}.(0[1-9]|1[012]).(0[1-9]|[12][0-9]|3[01])");

            if (regex.IsMatch(textBoxDatum.Text))
            {
                e.Cancel = false;

                if (!string.IsNullOrWhiteSpace(textBoxDatum.Text))
                {
                    textBoxDatum.BackColor = Color.LightGreen;
                }

            }
            else
            {

                e.Cancel = true;
                textBoxDatum.BackColor = Color.LightCoral;
                MessageBox.Show("A dátumot yyy.mm.dd. formátumban adja meg!");

            }

        }



        private void ButtonMentes_Click(object sender, EventArgs e)
        {
            if (!ValidatePont(textBoxPont.Text))
            {
                MessageBox.Show("Nem megfelelő a pontszám!");
            }

            else
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
                dataGridViewEredmeny.Update();
            }
           

                
            
        }

        public bool ValidatePont(string pont)
        {
            return Regex.IsMatch(
                pont,
                @"[0-9]{2,3}$");
        }
    }
}
