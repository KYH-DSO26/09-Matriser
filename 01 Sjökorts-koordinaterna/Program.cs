string[,] sjökort = new string[3, 3]
{
    {"Öppet hav", "Klippa",    "Öppet hav" },
    {"Öppet hav", "Ö",         "Klippa" },
    {"Grund",     "Öppet hav", "Öppet hav" }
};

string mittRuta = sjökort[1, 1];
Console.WriteLine($"Innehåll i mittrutan: {mittRuta}");







Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();