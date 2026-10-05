// Sätt upp en Jagged Array. Observera syntaxen!
string[][] hamnBryggor = new string[3][];
hamnBryggor[0] = new string[3];
hamnBryggor[1] = new string[5];
hamnBryggor[2] = new string[2];

int totalKapacitet = 0;

for (int i = 0; i < hamnBryggor.Length; i++)
{
    for (int j = 0; j < hamnBryggor[i].Length; j++)
    {
        hamnBryggor[i][j] = "Tom";
        totalKapacitet++;
    }
}

Console.WriteLine($"Totalt antal båtplatser i hela hamnen: {totalKapacitet} st.");





Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();