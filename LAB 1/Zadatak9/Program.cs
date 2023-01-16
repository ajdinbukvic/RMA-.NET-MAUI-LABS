/*Zadatak :9
Napišite program koji tražite od korisnika da unese niz brojeva odvojenih zarezom. 
Pronađite maksimalan broj i prikažite ga na konzoli. Na primjer, 
ako korisnik unese „5, 3, 8, 1, 4", program bi trebao ispisati: 
Maksimalni broj iz niza je 8.*/

string? unos;

Console.WriteLine("Unesite brojeve odvojene zarezom: ");
unos = Console.ReadLine();

string[] str = unos.Split(",");

List<int> brojevi = new List<int>();

foreach(string s in str)
{
    brojevi.Add(Convert.ToInt32(s.Trim()));
}

Console.WriteLine("Maksimalni broj iz niza je: {0}", brojevi.Max());
