int[,] djupKarta = new int[4, 4]
{
    { 12, 15, 3, 2 },
    { 20, 8, 14, 18 },
    { 4, 22, 30, 25 },
    { 11, 13, 9, 16 }
};

int gränsFörGrund = 5;

for (int r = 0; r < djupKarta.GetLength(0); r++)
{
    for (int k = 0; k < djupKarta.GetLength(1); k++)
    {
        if (djupKarta[r, k] < gränsFörGrund)
        {
            Console.WriteLine($"[VARNING]: Grund detekterat på Rad {r}, Kolumn {k} ({djupKarta[r, k]}m)");

            if (k + 1 < djupKarta.GetLength(1) && djupKarta[r, k + 1] < gränsFörGrund)
            {
                Console.WriteLine($" [ALERT]: Större sammanhängande grund! Kolumn {k + 1} är också grund ({djupKarta[r, k + 1]}m).");
            }
        }
    }
}



Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
