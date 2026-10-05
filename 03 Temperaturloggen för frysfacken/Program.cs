int[,] frysTemperaturer = new int[3, 2]
{
    {-22, -18 },
    {-25, -21 },
    {-19, -20 },        // Dinglande kommatecken är inget problem - det fixar kompilatorn
};

int varmast = frysTemperaturer[0, 0];
int varmastRad = 0;
int varmastKolumn = 0;

for (int i = 0; i < frysTemperaturer.GetLength(0); i++)
{
    for (int j = 0; j < frysTemperaturer.GetLength(1); j++)
    {
        if (frysTemperaturer[i, j] > varmast)
        {
            varmast = frysTemperaturer[i, j];
            varmastRad = i;
            varmastKolumn = j;
        }
    }
}

Console.WriteLine($"Den varmaste temperaturen är: {varmast} grader");
Console.WriteLine($"Varmaste punkten är i frys {varmastRad}, mätpunkt nummer {varmastKolumn}");





Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();