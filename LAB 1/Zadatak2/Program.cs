/*Zadatak 2:
Napišite program koji uzima dva broja s konzole i ispisuje veći broj.*/

int br1, br2;

Console.WriteLine("Unesite prvi broj: ");
br1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Unesite drugi broj: ");
br2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veci broj je: {0}", br1 > br2 ? br1 : br2);




