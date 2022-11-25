using CSharp_Geometria;

//ESERCIZIO: Prendere dall'utente nome, base e altezza di un rettangolo. Utilizzare metodi della classe per stampare base, altezza, area (base*altezza), perimetro (2*(base+altezza)),
//e fare un disegnino del rettangolo ottenuto. Il disegno viene male perché non so disegnare in ASCII.
//Inoltre stampare alcuni rettangoli a caso per dimostrare il metodo di stampa, I guess

//Dichiariamo il rettangolo dell'utente.

Rettangolo userRettangolo = new Rettangolo();

//Dichiariamo i rettangoli di default.

Rettangolo defaultRettangolo1 = new Rettangolo();
Rettangolo defaultRettangolo2 = new Rettangolo();
Rettangolo defaultRettangolo3 = new Rettangolo();

//Assegnamo nome, base e altezza dei defaultangoli.

defaultRettangolo1.nomeRettangolo = "Smolangolo";
defaultRettangolo1.baseRettangolo = 5;
defaultRettangolo1.altezzaRettangolo = 3;

defaultRettangolo2.nomeRettangolo = "Rettangolone";
defaultRettangolo2.baseRettangolo = 20;
defaultRettangolo2.altezzaRettangolo = 15;

defaultRettangolo3.nomeRettangolo = "Verticangolo";
defaultRettangolo3.baseRettangolo = 5;
defaultRettangolo3.altezzaRettangolo = 15;

//Chiediamo gli attributi dell'userangolo all'utente.

Console.WriteLine("Inserisci un nome per il rettangolo: ");
userRettangolo.nomeRettangolo = Console.ReadLine();

//Se l'utente non mette nulla durante la dichiarazione del nome, sanifica l'input con un nome di default.

if(userRettangolo.nomeRettangolo == null)
{
    userRettangolo.nomeRettangolo = "Nessuno";
}

//Chiediamo base e altezza, sanificando l'input.

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

//Stampiamo tutti i rettangoli, e disegnamo quello dell'utente.

Console.WriteLine("Stampa degli attributi del rettangolo:");
userRettangolo.StampaDettagliRettangolo();
userRettangolo.DisegnaRettangolo();

Console.WriteLine("Stampiamo i rettangoli di default:");
defaultRettangolo1.StampaDettagliRettangolo();
defaultRettangolo2.StampaDettagliRettangolo();
defaultRettangolo3.StampaDettagliRettangolo();