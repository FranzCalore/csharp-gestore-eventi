// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;

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
Console.WriteLine(Eventoutente);
Console.WriteLine("Capienza Massima Evento: " + Eventoutente.GetCapienzaMassima());
Console.WriteLine("Numero Posti Prenotati: " + Eventoutente.GetNumeroPostiPrenotati());
Console.WriteLine();
Console.WriteLine("Vuoi prenotare dei posti? (y/n)");
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