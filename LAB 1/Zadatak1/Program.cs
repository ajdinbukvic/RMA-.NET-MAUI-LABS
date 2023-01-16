/*Zadatak 1:
Napišite program i koji od korisnika zahtjeva da unese broj. 
Broj bi trebao biti između 1 i 10. Ako korisnik unese važeći broj, 
na konzoli prikažite "Validan". U suprotnom, prikazati "Netačan broj. 
Molimo unesite broj između 1 i 10". (Ova logika se često koristi u 
aplikacijama gdje vrijednosti koje se unose u forme za unos trebaju biti validirane.)*/

int broj;

do
{
    Console.WriteLine("Unesite broj izmedju 1 - 10: ");
    broj = Convert.ToInt32(Console.ReadLine());
    if (broj < 1 || broj > 10) Console.WriteLine("Netacan broj - Unesite broj izmedju 1 - 10");
    else
    {
        Console.WriteLine("Validan");
        break;
    }
} while (broj < 1 || broj > 10);
