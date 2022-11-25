using CSharp_Geometria;

Rettangolo userRettangolo = new Rettangolo();

Console.WriteLine("Inserisci un nome per il rettangolo: ");
userRettangolo.nomeRettangolo = Console.ReadLine();

if(userRettangolo.nomeRettangolo == null)
{
    userRettangolo.nomeRettangolo = "Nessuno";
}

do
{
    Console.WriteLine("Inserisci la base del rettangolo");
    int.TryParse(Console.ReadLine(), out userRettangolo.baseRettangolo);

} while (userRettangolo.baseRettangolo == 0);

do
{
    Console.WriteLine("Inserisci la altezza del rettangolo");
    int.TryParse(Console.ReadLine(), out userRettangolo.altezzaRettangolo);

} while (userRettangolo.altezzaRettangolo == 0);

Console.WriteLine("Stampa degli attributi del rettangolo:");
userRettangolo.StampaDettagliRettangolo();
userRettangolo.DisegnaRettangolo();