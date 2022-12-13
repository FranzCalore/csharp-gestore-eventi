using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private uint capienzaMassima;
        private uint numeroPostiPrenotati;

        public Evento (string titolo, string dataStringa, uint capienzaMassima)
        {
            SetTitolo(titolo);

            SetData(dataStringa);
            
            this.capienzaMassima = capienzaMassima;
            this.numeroPostiPrenotati = 0;
        }

        public string GetTitolo()
        {
            return this.titolo;
        }

        public DateTime GetData()
        {
            return this.data;
        }

        public uint GetCapienzaMassima()
        {
            return this.capienzaMassima;
        }

        public uint GetNumeroPostiPrenotati()
        {
            return this.numeroPostiPrenotati;
        }

        public void SetTitolo(string titolo)
        {
            if (titolo != null && titolo.Trim() != "")
            {
                this.titolo = titolo;
            } else
            {
                throw new Exception("Il titolo non può essere vuoto");
            }
            
        }

        public void SetData(string stringdata)
        {
            DateTime datainserita = DateTime.Parse(stringdata);
            if (datainserita > DateTime.Now)
            {
                this.data = datainserita;
            }
            else
            {
                throw new Exception("La data inserita è già passata");
            }
        }

        public void PrenotaPosti(uint numeroPosti)
        {
            uint numeroPostiDisponibili = this.capienzaMassima-this.numeroPostiPrenotati;
            if (numeroPostiDisponibili==0 || DateTime.Now > this.GetData() || numeroPosti > numeroPostiDisponibili)
            {
                throw new Exception("Non è possibile prenotare posti per questo evento");
            } else
            {
                this.numeroPostiPrenotati += numeroPosti;
            }
        }
        public void DisdiciPosti(uint numeroPosti)
        {
            if (this.numeroPostiPrenotati==0 || DateTime.Now > this.GetData())
            {
                throw new Exception("Non è possibile disdire posti per questo evento");
            }
            else
            {
                this.numeroPostiPrenotati-= numeroPosti;
            }
        }

        public override string ToString()
        {
            string stringData = this.GetData().ToString("dd/MM/yyyy");
            return stringData + " - " + this.GetTitolo();
        }
    }
}
