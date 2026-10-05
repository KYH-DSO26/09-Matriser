
string[,] schema = new string[4, 2]
{
    {"Kalle (Morgon)", "Stina (Morgon)" },
    {"Börje (Förmiddag)", "Lotta (Förmiddag)" },
    {"Olle (Dag)", "Anna (Dag)" },
    {"Claes (Natt)", "Erik (Natt)" },
};

int rader = schema.GetLength(0);
int kolumner = schema.GetLength(1);

Console.WriteLine("--- SCHEMA FÖRE VERTIKAL INVERTERING ---");
SkrivUt();

for (int r = 0; r < rader / 2; r++)
{
    for (int k = 0; k < kolumner; k++)
    {
        string temp = schema[r, k];
        schema[r, k] = schema[rader - 1 - r, k];
        schema[rader - 1 - r, k] = temp;
    }
}

Console.WriteLine("\n\n--- SCHEMA EFTER VERTIKAL INVERTERING ---");

SkrivUt();

void SkrivUt()
{
    for (int r = 0; r < rader; r++)
    {
        for (int k = 0; k < kolumner; k++)
        {
            Console.Write($"{schema[r, k]}\t");
        }
        Console.WriteLine();
    }
}



Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
