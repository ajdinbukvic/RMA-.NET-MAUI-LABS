/*Zadatak :6
Napišite program koji tražite od korisnika da unese broj ili "ok" za izlaz. 
Izračunajte sumu svih prethodno unesenih brojeva i prikažite ga na konzoli.*/

string? unos;
int suma = 0;

while (true)
{
    Console.WriteLine("Unesite broj: ('ok' za izlaz): ");
    unos = Console.ReadLine();
    if (unos == "ok") break;
    else suma += Convert.ToInt32(unos);
}

Console.WriteLine("Suma svih unesenih brojeva je: {0}", suma);