/*Zadatak 4:
Vaš posao je da napišete program za saobraćajnu kameru za mjerenje brzine - radar. 
Radi jednostavnosti, zanemarite detalje poput kamere, senzora itd. 
I fokusirajte se isključivo na logiku. Napišite program koji traži od korisnika 
da unese ograničenje brzine. Jednom postavljen, program traži brzinu kojom se 
automobil kreće. Ako korisnik unese vrijednost manju od ograničenja brzine, 
program bi trebao prikazati poruku OK na konzoli. Ako je vrijednost iznad 
ograničenja brzine, program treba izračunati broj kaznenih bodova. 
Za svakih 5 km / h iznad ograničenja brzine, treba napraviti 1 kazeneni bod 
i prikazati „ukupan broj kaznenih bodova“ na konzoli. Ako je broj kaznenih 
bodova veći od 10, program bi trebao prikazati „vozačka dozvola suspendovana“, 
ako je broj bodova veći od 15 treba prikazati poruku „ponovno polaganje vozačkog ispita“..*/

using System.Reflection;

int ogranicenje;

Console.WriteLine("Unesite ogranicenje: ");
ogranicenje = Convert.ToInt32(Console.ReadLine());

int brzina;

Console.WriteLine("Unesite trenutnu brzinu: ");
brzina = Convert.ToInt32(Console.ReadLine());

if (brzina > ogranicenje)
{
    int prekoracenje = brzina - ogranicenje;
    int bodovi = 0;
    for (int i = 0; i < prekoracenje; i += 5) bodovi += 1;
    Console.WriteLine("Ogranicenje: {0} | Prekoracenje: {1}", ogranicenje, prekoracenje);
    Console.WriteLine("Ukupan broj kaznenih bodova: {0}", bodovi);
    if (bodovi > 10) Console.WriteLine("Vozačka dozvola suspendovana");
    if (bodovi > 15) Console.WriteLine("Ponovno polaganje vozačkog ispita");
}
else Console.WriteLine("OK");

