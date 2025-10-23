string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("***** Největší ze tří čísel ******");
    Console.WriteLine("**********************************");
    Console.WriteLine("************Roman Hozák***********");
    Console.WriteLine("**********************************");
    Console.WriteLine();

    Console.Write("Zadejte celočíselnou hodnotu prvního čísla: ");
    int a,b,c;

    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první hodnotu znovu: ");
    }

    Console.Write("Zadejte celočíselnou hodnotu druhého čísla: ");
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte druhou hodnotu znovu: ");
    }

    Console.Write("Zadejte celočíselnou hodnotu třetího čísla: ");
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte třetí hodnotu znovu: ");
    }

    Console.WriteLine("\n=========================");
    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší je první číslo= {a}");
        else
            Console.WriteLine($"Největší je třetí číslo = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší je druhé číslo = {b}");
        else
            Console.WriteLine($"Největší je třetí číslo = {c}");
    }
    Console.WriteLine("=========================");

    Console.WriteLine("\nPro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

}


