using System.Security.AccessControl;

string[,] lagerPallar = new string[3, 3]
{
    {"PALL-101", "PALL-102", "TOM" },
    {"TOM", "PALL-205", "PALL-206" },
    {"PALL-301", "TOM", "PALL-309" },
};

Console.Write("Ange pall-ID att söka efter (t.ex. PALL-205): ");
var sökId = Console.ReadLine();

bool hittad = false;
int funnenRad = -1;
int funnenKol = -1;

hittad = HittaPall(lagerPallar, sökId, out funnenRad,out funnenKol);

if (hittad)
{
    Console.WriteLine($"Hurra! {sökId} hittades på Hyllplats: Rad {funnenRad}, Sektion {funnenKol}.");
}
else
{
    Console.WriteLine($"Fel: Kunde inte hitta något objekt med ID '{sökId}' i lagret.");
}



bool HittaPall(string[,]lagerPallar, string? sök, out int rad, out int kolumn)
{
    for (int r = 0; r < lagerPallar.GetLength(0); r++)
    {
        for (int k = 0; k < lagerPallar.GetLength(1); k++)
        {
            if (lagerPallar[r, k].Equals(sökId, StringComparison.OrdinalIgnoreCase))
            {
                hittad = true;
                rad = r;
                kolumn = k;
                return true;              // Vi behöver inte leta mer
            }
        }
    }
    rad = kolumn = -1;
    return false;
}



Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
