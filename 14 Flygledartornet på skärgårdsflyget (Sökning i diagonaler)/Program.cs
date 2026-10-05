string[,] radar = new string[4, 4]
{
    { "Flyg-A", "TOM", "TOM", "TOM" },
    { "TOM", "TOM", "TOM", "TOM" },
    { "TOM", "TOM", "Flyg-B", "TOM" },
    { "TOM", "TOM", "TOM", "TOM" }
};

for (int i = 0; i < radar.GetLength(0); i++)
{
    string objekt = radar[i, i];
    if (objekt != "TOM")
    {
        Console.WriteLine($"[KONTAKT]: Objekt ({objekt}) upptäckt på diagonalen [{i}, {i}].");
    }
}





Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
