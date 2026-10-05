string[,] sittplatser = new string[4, 2];
for (int rad = 0; rad < 4; rad++)
{
    for (int stol = 0; stol < 2; stol++)
    {
        sittplatser[rad, stol] = "Ledig";
    }
}

sittplatser[0, 0] = "Anna";
sittplatser[2, 1] = "Björn";

for (int rad = 0; rad < sittplatser.GetLength(0); rad++)
{
    for (int stol = 0; stol < sittplatser.GetLength(1); stol++)
    {
        Console.Write($"[Rad {rad}, Stol {stol}: {sittplatser[rad, stol]}]    ");
    }
    Console.WriteLine();
}





Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();