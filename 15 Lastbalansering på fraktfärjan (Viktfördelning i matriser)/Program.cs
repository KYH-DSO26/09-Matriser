int[,] lastDäck = new int[4, 4]
{
    { 500, 300, 400, 400 },
    { 700, 200, 100, 800 },
    { 450, 450, 300, 300 },
    { 100, 600, 200, 500 }
};

int viktBabord = 0;
int viktStyrbord = 0;

for (int r = 0; r < lastDäck.GetLength(0); r++)
{
    for (int k = 0; k < lastDäck.GetLength(1); k++)
    {
        if (k <= 1) viktBabord += lastDäck[r, k];
        else viktStyrbord += lastDäck[r, k];
    }
}

int skillnad = Math.Abs(viktBabord - viktStyrbord);
Console.WriteLine($"Skillnad: {skillnad} kg. Skutan är {(skillnad > 500 ? "OBALANSERAD" : "STABIL")}.");










Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
