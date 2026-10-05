char[,] radarSkärm = new char[5, 5];
for (int r = 0; r < 5; r++)
{
    for (int k = 0; k < 5; k++)
    {
        radarSkärm[r, k] = '.';
    }
}

radarSkärm[1, 3] = 'B';
radarSkärm[4, 2] = 'K';

// Skriv ut hela radarskärmen först:
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(radarSkärm[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine("\n\n");

for (int rad = 0; rad < 5; rad++)
{
    for (int kol = 0; kol < 5; kol++)
    {
        if (radarSkärm[rad, kol] == 'B')
        {
            Console.WriteLine($"Båt ('B') upptäckt på koordinbater: Rad {rad}, Kolumn {kol}");
        }
        else if (radarSkärm[rad, kol] == 'K')
        {
            Console.WriteLine($"Klippa ('K') upptäckt på koordinbater: Rad {rad}, Kolumn {kol}");
        }
    }
}





Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();