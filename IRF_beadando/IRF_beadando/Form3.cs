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
        public Form3()
        {
            InitializeComponent();
            context.Eredmenies.Load();
            eredmenyBindingSource.DataSource = context.Eredmenies.Local;
        }

        private void ButtonMentes_Click(object sender, EventArgs e)
        {
           
        }
    }
}
