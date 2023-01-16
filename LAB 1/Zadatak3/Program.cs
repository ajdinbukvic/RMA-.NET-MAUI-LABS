/*Zadatak 3:
Napišite program i koji od korisnika zahtjeva da unese širinu i visinu slike. 
Zatim određuje da li je slika pejzažna ili portretna.*/

int sirina, visina;

Console.WriteLine("Unesite sirinu: ");
sirina = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Unesite visinu: ");
visina = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Slika je: {0}", sirina > visina ? "pejzazna" : "portretna");