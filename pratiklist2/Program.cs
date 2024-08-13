Console.WriteLine("Saldırbaksa hoş geldiniz ");
List<string> list = new List<string>();

for (int i = 1; i <= 5; i++)
{
    Console.Write($"{i}. Kahve --> ");
    string kahveisim = Console.ReadLine();
    list.Add( kahveisim );
}

Console.WriteLine("!!!! SALDIRBAKS KAHVE ÇEŞİTLERİ !!!!");
foreach (var kahve in list)
{
    Console.WriteLine(kahve);
}