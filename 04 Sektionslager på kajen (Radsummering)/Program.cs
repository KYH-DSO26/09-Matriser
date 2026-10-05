int[,] lagerBoxar = new int[3, 4]
{
    {5, 8, 1, 4 },
    {10, 12, 6, 9 },
    {3, 0, 7, 1 },
};

int totaltRadTvå = 0;
int måladRad = 1;

for (int kolumn = 0; kolumn < lagerBoxar.GetLength(1); kolumn++)
{
    totaltRadTvå += lagerBoxar[måladRad, kolumn];
}

Console.WriteLine($"Totalt antal paket i den andra raden: {totaltRadTvå} st.");



Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();