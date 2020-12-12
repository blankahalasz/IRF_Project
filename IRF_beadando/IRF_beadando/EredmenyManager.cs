using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadando
{
    public class EredmenyManager
    {
        BindingList<Eredmeny> eredmenyek { get; } = new BindingList<Eredmeny>();
        public Eredmeny CreateEredmeny(Eredmeny eredmeny)
        {
            var letezoEredmeny = (from x in eredmenyek
                                  where x.DATUM.Equals(eredmeny.DATUM)
                                  select x).FirstOrDefault();
            if (letezoEredmeny != null)
            {
                throw new ApplicationException(
                    "Ezzel a dátummal már lett rögzítve eredmény!");
            }

            eredmenyek.Add(eredmeny);

            return eredmeny;
        }
    
    }
}
