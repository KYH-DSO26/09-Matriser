string[][] tullKanaler = new string[2][];
tullKanaler[0] = new string[] { "REG-111", "REG-222", "REG-333" };
tullKanaler[1] = new string[] { "REG-ABC", "REG-DEF" };

for (int station = 0; station < tullKanaler.Length; station++)
{
    Console.WriteLine($"Station {station + 1}");
    for (int bil = 0; bil < tullKanaler[station].Length; bil++)
    {
        Console.WriteLine($"   Plats {bil + 1}: {tullKanaler[station][bil]}");
    }
}

Console.WriteLine("\n\n[HÄNDELSE]: Första lastbilen i Station 1 klar");
tullKanaler[0][0] = "KLAR / PASSERAD";
Console.WriteLine($"Ny status på plats 1, station 1: {tullKanaler[0][0]}");






Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
