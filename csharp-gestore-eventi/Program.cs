// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;
using System.Text;
Console.OutputEncoding = Encoding.Default;



Console.WriteLine("Inserisci il nome del tuo programma di eventi:");
string titoloProgramma = Console.ReadLine();
ProgrammaEventi nuovoProgrammaEventi = new ProgrammaEventi(titoloProgramma);
Console.WriteLine("Quanti eventi vuoi che contenga il tuo programma?");
uint numeroEventiDaProgrammare = uint.Parse(Console.ReadLine());

while (nuovoProgrammaEventi.NumeroEventi() != numeroEventiDaProgrammare)
{
    try
    {
        Console.WriteLine("Inserisci il titolo di un evento da inserire:");
        string titolo = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Inserisci la data dell'evento (dd/mm/yyyy)");
        string data = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Inserisci la capienza massima dell'evento");
        uint CapienzaEvento = uint.Parse(Console.ReadLine());
        Console.WriteLine();
        Evento Eventoutente = new Evento(titolo, data, CapienzaEvento);
        nuovoProgrammaEventi.AggiungiEvento(Eventoutente);
        Console.WriteLine(Eventoutente);
        Console.WriteLine("Capienza Massima Evento: " + Eventoutente.GetCapienzaMassima());
        Console.WriteLine("Numero Posti Prenotati: " + Eventoutente.GetNumeroPostiPrenotati());
        Console.WriteLine();
    }
    catch (FormatException e)
    {
        Console.WriteLine("La data inserita è in formato errato");
    }
    catch (OverflowException e)
    {
        Console.WriteLine("Non puoi inserire numeri negativi");
    }
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
Conferenza conferenzaDiProva = new Conferenza("Bryan Lucchetta", "CsharpShop - la vendetta", "14/12/2022", 26, 15.60);
nuovoProgrammaEventi.AggiungiEvento(conferenzaDiProva);
Console.WriteLine("Gli eventi programmati sono: " + nuovoProgrammaEventi.NumeroEventi());
Console.WriteLine("Gli eventi programmati sono: " + nuovoProgrammaEventi.ToString());
Console.WriteLine("Inserisci una data di cui vuoi visualizzare gli eventi (dd/mm/yyyy):");
string dataUtente = Console.ReadLine();
Console.WriteLine(ProgrammaEventi.StampaListaInConsole(nuovoProgrammaEventi.EventiInData(dataUtente)));
nuovoProgrammaEventi.SvuotaListaEventi();





/*Console.WriteLine("Vuoi prenotare dei posti? (y/n)");
string InputUtente = Console.ReadLine();
while (InputUtente == "y")
{
    Console.WriteLine("Quanti Posti desideri prenotare?");
    uint postiDaPrenotare = uint.Parse(Console.ReadLine());
    Eventoutente.PrenotaPosti(postiDaPrenotare);
    Console.WriteLine();
    uint postiDisponibili = Eventoutente.GetCapienzaMassima() - Eventoutente.GetNumeroPostiPrenotati();
    Console.WriteLine("Posti Disponibili Evento: " + postiDisponibili);
    Console.WriteLine("Numero Posti Prenotati: " + Eventoutente.GetNumeroPostiPrenotati());
    Console.WriteLine();
    Console.WriteLine("Vuoi prenotare altri posti? (y/n)");
    InputUtente = Console.ReadLine();

}
Console.WriteLine();

Console.WriteLine("Vuoi disdire dei posti? (y/n)");
InputUtente = Console.ReadLine();
while (InputUtente == "y")
{
    Console.WriteLine("Quanti Posti desideri disdire?");
    uint postiDaDisdire = uint.Parse(Console.ReadLine());
    Eventoutente.DisdiciPosti(postiDaDisdire);
    Console.WriteLine();
    uint postiDisponibili = Eventoutente.GetCapienzaMassima() - Eventoutente.GetNumeroPostiPrenotati();
    Console.WriteLine("Posti Disponibili Evento: " + postiDisponibili);
    Console.WriteLine("Numero Posti Prenotati: " + Eventoutente.GetNumeroPostiPrenotati());
    Console.WriteLine();
    Console.WriteLine("Vuoi disdire altri posti? (y/n)");
    InputUtente = Console.ReadLine();

}
Console.WriteLine();
Console.WriteLine("Buona Giornata!");
*/