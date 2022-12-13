using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Conferenza : Evento
    {
        private string relatore;
        private double prezzo;

        public Conferenza(string relatore, string titolo, string dataStringa, uint capienzaMassima, double prezzo) : base(titolo, dataStringa, capienzaMassima)
        {
            this.relatore = relatore;
            this.prezzo = prezzo;
        }

        public string GetRelatore()
        {
            return this.relatore;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        public void SetRelatore(string relatore)
        {
            this.relatore = relatore;
        }

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        public string GetPrezzoStringa(double prezzo)
        {
            return prezzo.ToString("C");
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.GetRelatore() + " - " + this.GetPrezzoStringa(this.GetPrezzo());
        }
    }
}
