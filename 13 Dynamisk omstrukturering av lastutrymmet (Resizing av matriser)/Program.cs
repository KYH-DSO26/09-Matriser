string[,] gammaltDäck = new string[3, 3]
{
    { "Bil A", "Bil B", "Bil C" },
    { "Bil D", "TOM", "Bil E" },
    { "Bil F", "Bil G", "TOM" }
};

Console.WriteLine("--- GAMMALT DÄCK ---");
SkrivUtDäck(gammaltDäck);

string[,] nyttDäck = new string[5, 5];

for (int r = 0; r < 5; r++)
{
    for (int k = 0; k < 5; k++)
    {
        nyttDäck[r, k] = "TOM";
    }
}

for (int r = 0; r < gammaltDäck.GetLength(0); r++)
{
    for (int k = 0; k < gammaltDäck.GetLength(1); k++)
    {
        nyttDäck[r, k] = gammaltDäck[r, k];
    }
}

Console.WriteLine("\n\n--- SKALAT LASTDÄCK ---");
SkrivUtDäck(nyttDäck);


void SkrivUtDäck(string[,] däck)
{
    for (int r = 0; r < däck.GetLength(0); r++)
    {
        Console.Write($"Däck {r} -- ");
        for (int k = 0; k < däck.GetLength(1); k++)
        {
            Console.Write($"{däck[r, k]}\t");
        }
        Console.WriteLine();
    }
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
