using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        private string titolo;
        private List<Evento> eventi;


        public ProgrammaEventi(string titolo)
        {
            this.titolo = titolo;
            this.eventi = new List<Evento>();
        }

        public string GetTitolo()
        {
            return this.titolo;
        }

        public void AggiungiEvento(Evento Evento)
        {
            this.eventi.Add(Evento);
        }
        public List<Evento> EventiInData(string stringData)
        {
            DateTime data = DateTime.Parse(stringData);
            List<Evento> ListaEventiInData= new List<Evento>();
            foreach(Evento evento in this.eventi)
            {
                if (evento.GetData() == data)
                {
                    ListaEventiInData.Add(evento);
                }
            }
            return ListaEventiInData;
        }

        public static string StampaListaInConsole(List<Evento> ListaEventi)
        {
            string stringaEventi = "\n";
            foreach (Evento evento in ListaEventi)
            {
                stringaEventi += evento.ToString();
                stringaEventi += "\n";
            }
            return stringaEventi;
        }

        public int NumeroEventi()
        {
            return eventi.Count();
        }

        public void SvuotaListaEventi()
        {
            eventi.Clear();
        }

        public override string ToString()
        {
            string stringaListaEventi = this.GetTitolo() + ":\n";
            stringaListaEventi += ProgrammaEventi.StampaListaInConsole(this.eventi);            
            return stringaListaEventi;
        }
    }
}
