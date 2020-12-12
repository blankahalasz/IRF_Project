using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_beadando
{
    public interface IEredmenyManager
    {
        BindingList<Eredmeny> Eredmenies { get; }
        Eredmeny CreateEredmeny(Eredmeny eredmeny);
    }
}
