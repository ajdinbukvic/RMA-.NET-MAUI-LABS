/*Zadatak :5
Napišite program za brojanje koliko je brojeva između 1 i 100 djeljivo sa 3. 
Prikažite ukupan broj na konzoli.*/

List<int> brojevi = new List<int> ();

for(int i = 1; i <= 100; i++)
{
    if(i % 3 == 0) brojevi.Add (i); 
}

foreach(int broj in brojevi)
{
    Console.WriteLine ("{0}, ", broj);
}

Console.WriteLine ("Ukupno brojeva izmedju 1 - 10 djeljivih s 3: {0}", brojevi.Count);