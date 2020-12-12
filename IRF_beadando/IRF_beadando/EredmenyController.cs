using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRF_beadando
{
    public class EredmenyController
    {
        public IEredmenyManager EredmenyManager { get; set; }
        public EredmenyController()
        {
            EredmenyManager = new EredmenyManager();
        }

        public Eredmeny Letrehoz(string sfelhnev, string efelhnev, System.DateTime datum, int pont)
        {
            if (!ValidateDatum(datum))
                throw new ValidationException(
                    "A megadott dátum nem megfelelő formátumú");
            if (!ValidatePont(pont))
            {
                throw new ValidationException(
                "A megadott pont csak szám formátumban megfelelő!");
            }

            var eredmeny = new Eredmeny()
            {
                SFELH_NEV_FK = sfelhnev,
                EDZO_FELH_NEV_FK = efelhnev,
                DATUM = datum,
                PONT = pont
            };
            var newEredmeny = EredmenyManager.CreateEredmeny(eredmeny);
            return newEredmeny;

        }

        public bool ValidatePont(int pont)
        {
            return Regex.IsMatch(
                pont.ToString(),
                 "^[0-9]{1,3}");

        }

        public bool ValidateDatum(DateTime datum)
        {
            return Regex.IsMatch(
                datum.ToString(),
                "(19|20)[0-9]{2}.(0[1-9]|1[012]).(0[1-9]|[12][0-9]|3[01])");
        }
    }
}
