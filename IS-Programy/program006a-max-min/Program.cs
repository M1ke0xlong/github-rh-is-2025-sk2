string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Roman Hozák ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }



    // Hledání maxima, minima a jejich prvních pozic
    int max = myRandNumbs[0]; // předpokládáme, že první prvek v poli je maximem
    int min = myRandNumbs[0]; // předpokládáme, že první prvek v poli je minimem
    int posMax = 0;
    int posMin = 0;
    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }

        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }


    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("=========================================");
    Console.WriteLine();

    // Vykreslení přesypacích hodin
    if (max >= 3)
    {
        for (int i = 0; i < max; i++)
        {
            int spaces, stars;
            if (i < max / 2)
            {
                spaces = i;
                // horní polovina - s každým dalším řádkem ubývají dvě hvězdičky (po jedné z každé strany)
                stars = max - (2 * i);
            }
            else
            {
                spaces = max - i - 1;
                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + 1;
                }
                else
                {
                    stars = stars = 2 * (i - max / 2) + 2;
                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Green;
            // sp - space
            for (int sp = 0; sp < spaces; sp++)
                Console.Write(" ");

            // st - star
            for (int st = 0; st < stars; st++)
                Console.Write("*");

            Console.WriteLine();
            Console.ResetColor();
        
        }    





    }
    else
    {
        Console.WriteLine("Maximum je menší než 3 => obrazec se nevykreslí");
    }



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}