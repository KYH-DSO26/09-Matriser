char[,] hav = new char[3, 3]
{
    {'~', '~', '~' },
    {'~', '~', '~' },
    {'~', '~', '~' },
};

int skattRad = 1;
int skattKol = 2;

Console.WriteLine("--- VÄLKOMMEN TILL SKATTJAKTEN TILL SJÖSS ---");
SkrivUtHav();

while (true)
{
    Console.Write("Gissa rad (0-2): ");
    int gissadRad = int.Parse(Console.ReadLine());

    Console.Write("Gissa kolumn (0-2): ");
    int gissadKol = int.Parse(Console.ReadLine());

    if (gissadRad == skattRad && gissadKol == skattKol)
    {
        hav[skattRad, skattKol] = '$';
        SkrivUtHav();
        Console.WriteLine("Guld! Du hittade den nedsänkta skatten!");
        break;
    }
    else
    {
        Console.WriteLine("Plums... Här finns bara vatten och småfisk.");
    }

}



void SkrivUtHav()
{
    for (int r = 0; r < hav.GetLength(0); r++)
    {
        for (int k = 0; k < hav.GetLength(1); k++)
        {
            Console.Write(hav[r, k]);
        }
        Console.WriteLine();
    }

}



Console.Write("\n\nTryck på en tangent för att stänga fönstret... ");
Console.ReadKey();
