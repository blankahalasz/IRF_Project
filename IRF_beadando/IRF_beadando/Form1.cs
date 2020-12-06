using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_beadando
{
    public partial class Form1 : Form
    {
        Database1Entities1 context = new Database1Entities1();
        public Form1()
        {
            InitializeComponent();
            listBoxEdzok.DisplayMember = "Nev";
            listBoxSportolok.DisplayMember = "SNev";
            listEdzok();
            

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
    }
}
