int[,] terminal = new int[4, 4]
{
    {24,    15,     30,     18 },
    {8,     42,     12,     25 },
    {19,    22,     5,      31 },
    {35,    14,     28,     20 },
};

Console.WriteLine("--- CONTAINERHAMNENS VIKTKARTA (TON) ---");

for (int r = 0; r < terminal.GetLength(0); r++)
{
    for (int k = 0; k < terminal.GetLength(1); k++)
    {
        Console.Write($"{terminal[r, k]}\t");
        //Console.Write($"{terminal[r, k]:F8}"); 
    }
    Console.WriteLine();
}






Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
