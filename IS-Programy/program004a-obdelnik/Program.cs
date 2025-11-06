string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("****** Vykreslení obrazců ******");
    Console.WriteLine("********************************");
    Console.WriteLine("********* Roman Hozák **********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    Console.WriteLine("Vyber obrazec k vykreslení:");
    Console.WriteLine("1 - Obdélník");
    Console.WriteLine("2 - Mřížka #");
    Console.WriteLine("3 - Z");
    Console.WriteLine("4 - N");
    Console.Write("Tvoje volba: ");

    int volba;
    while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 4)
    {
        Console.Write("Neplatná volba. Zadejte číslo 1–4: ");
    }

    Console.WriteLine();

    int width = 0, height = 0;

    if (volba == 1)
    {
        Console.Write("Zadejte šířku obrazce (celé číslo): ");
        while (!int.TryParse(Console.ReadLine(), out width))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte šířku znovu: ");
        }

        Console.Write("Zadejte výšku obrazce (celé číslo): ");
        while (!int.TryParse(Console.ReadLine(), out height))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
        }
    }
    else
    {
        Console.Write("Zadejte velikost obrazce (např. 8): ");
        while (!int.TryParse(Console.ReadLine(), out width))
        {
            Console.Write("Nezadali jste celé číslo. Zadejte velikost znovu: ");
        }
        height = width;
    }

    Console.Clear();
    Console.WriteLine();

    switch (volba)
    {
        case 1:
            VykresliObdelnik(width, height);
            break;
        case 2:
            VykresliMrizku(width);
            break;
        case 3:
            VykresliZ(width);
            break;
        case 4:
            VykresliN(width);
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    Console.WriteLine("Pro ukončení stiskněte libovolnou jinou klávesu.");
    again = Console.ReadLine();
}

// 1. Obdélník
void VykresliObdelnik(int width, int height)
{
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(TimeSpan.FromMilliseconds(50));
        }
        Console.WriteLine();
    }
}

// 2. Mřížka #
void VykresliMrizku(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 0 || j % 2 == 0)
                Console.Write("#");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// 3. Písmeno Z
void VykresliZ(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == 0 || i == n - 1 || j == n - 1 - i)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// 4. Písmeno N
void VykresliN(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n - 1 || j == i)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
