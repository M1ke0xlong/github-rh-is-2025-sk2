string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Roman Hozák ***************");
    Console.WriteLine("**************** 6.11.2025 ****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*******************************************\n");

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }


    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound; // Dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }



    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound; // Horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }

    // deklarace pole (array)
    int[] myRandNumbs = new int[n];

    // příprava pro využití třídy Random
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(15);

    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}, ", myRandNumbs[i]);

    }
    //maximum
    Console.Write("\nMaximum: {0}, všechny pozice maxima: ", myRandNumbs.Max());
    for (int i = 0;i < n; i++)
    {
        if (myRandNumbs[i] == myRandNumbs.Max())
        {
            Console.Write($"{i}; ");
        }
    }
    //minimum
    Console.Write("\nMinimum: {0}, všechny pozice minima: ", myRandNumbs.Min());
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] == myRandNumbs.Min()) { 
            Console.Write($"{i}; ");
        }
    }
    //sort
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (myRandNumbs[j + 1] > myRandNumbs[j]) { 
                int temp = myRandNumbs[j + 1];
                myRandNumbs[j + 1] = myRandNumbs[j];
                myRandNumbs[j] = temp;
            }
        }
    }
    Console.WriteLine("\nPole po seřazení algoritmem Bubble sort: ");
    for (int i = 0; i < n ; i++) {
        Console.Write($"{myRandNumbs[i]}, ");
    }
    //druhe treti ctvrte
    int unique = 0;
    int lastValue = int.MinValue;
    int druhy = 0, treti = 0, ctvrty = 0;
    for (int i = 0; i < n; i++)
    {
        if (myRandNumbs[i] != lastValue) {
            unique++;
            lastValue = myRandNumbs[i];
            if (unique == 2) { druhy = myRandNumbs[i]; }
            if (unique == 3) { treti = myRandNumbs[i]; }
            if (unique == 4) { ctvrty = myRandNumbs[i]; }
        }
    }
    Console.WriteLine($"\nDruhé největší číslo: {druhy}");
    Console.WriteLine($"Třetí největší číslo: {treti}");
    Console.WriteLine($"Čtvrte největší číslo: {ctvrty}");
    //median
    int median = 0;
    if (n%2 == 1)
    {
        median = myRandNumbs[n / 2];
    } else
    {
        median = (myRandNumbs[n / 2 - 1] + myRandNumbs[n / 2]) / 2;
    }
    Console.WriteLine($"Medián generovaných čísel = {median}");
    //ctvrte do bin
    string bin = "";
    int x = ctvrty;
    while (x > 0) {
        bin = (x%2) + bin;
        x = x / 2;
    }
    Console.WriteLine($"Čtvrté největší číslo převedené do binární soustavy: {ctvrty}(2) = {bin}");
    //obrazec
    int height = median;
    int width = treti;

    Console.WriteLine($"Obrazec jehož výška je {height} a šířka je {width}");
    Console.WriteLine();

    int part = height / 3;

    int smallWidth;
    int indent;

    if (width % 2 == 0)
    {
        smallWidth = 2;
        indent = (width - 2) / 2;
    }
    else
    {
        smallWidth = 3;
        indent = (width - 3) / 2;
    }

    for (int i = 0; i < height; i++)
    {
        if (i < part)
        {
            for (int s = 0; s < indent; s++)
                Console.Write("  ");

            for (int j = 0; j < smallWidth; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
        else if (i < height - part)
        {
            for (int j = 0; j < width; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
        else
        {
            for (int s = 0; s < indent; s++)
                Console.Write("  ");

            for (int j = 0; j < smallWidth; j++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}

