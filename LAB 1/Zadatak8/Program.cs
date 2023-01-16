/*Zadatak :8
Napišite program koji bira slučajni broj između 1 i 10. 
Dajte korisniku 4 šanse da pogodi broj. Ako korisnik pogodi broj, 
prikažite "Pobijedili ste", u suprotnom, prikazite "Izgubili ste." 
Tokom pokušaja program treba navoditi korisnika sa porukama 
„Traženi broj je veći odnosno manji“.*/

int sanse = 4;

Random random = new Random();
int broj = random.Next(1, 10);
Console.WriteLine("[ TEST ] Generisani broj: {0}", broj);

int unos;

while (true)
{
    if(sanse == 0)
    {
        Console.WriteLine("Izgubili ste!");
        break;
    }
    Console.WriteLine("Unesite broj izmedju 1 - 10: ");
    unos = Convert.ToInt32(Console.ReadLine());
    if(unos != broj)
    {
        sanse--;
        Console.WriteLine("Trazeni broj je {0}", unos > broj ? "manji" : "veci");    
    }
    else
    {
        Console.WriteLine("Pobijedili ste!");
        break;
    }
}