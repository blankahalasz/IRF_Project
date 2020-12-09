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
    public partial class Form2 : Form
    {
        Database1Entities1 context = new Database1Entities1();
        public Form2()
        {
            InitializeComponent();
            textBoxJelszo.PasswordChar = '*';

        }

        private void ButtonBelep_Click(object sender, EventArgs e)
        {
            var felhasznalo = (from x in context.Edzoes
                              where textBoxFelhnev.Text == x.FELH_NEV 
                              select x).FirstOrDefault();
            if (felhasznalo != null)
            {
                if (textBoxJelszo.Text == felhasznalo.JELSZO)
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                }
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó");
            }
        }
    }
}
