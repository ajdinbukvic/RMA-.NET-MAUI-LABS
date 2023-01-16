/*Zadatak :7
Napišite program koji tražite od korisnika da unese broj. 
Izračunajte faktorijel unesenog broja i ispišite ga na konzoli.*/

int faktorijel (int br)
{
    if (br == 0) return 1;
    return br * faktorijel(br - 1);
}

int broj;

Console.WriteLine("Unesite broj: ");
broj = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Faktorijel od broja {0} iznosi: {1}", broj, faktorijel(broj));