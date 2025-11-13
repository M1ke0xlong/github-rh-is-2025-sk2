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

    int[] myRandNumbs = new int[n];

    Random myRandNumb = new Random();

    int negativeNumbs = 0; 
    int positiveNumbs = 0; 
    int zeros = 0; 

    
    int evenNumbs = 0;
    int oddNumbs = 0;




    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Náhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);

        if (myRandNumbs[i] < 0)
            negativeNumbs++;
        else if (myRandNumbs[i] > 0)
            positiveNumbs++;
        else
            zeros++;

        if (myRandNumbs[i] % 2 == 0)
            evenNumbs++;
        else
            oddNumbs++;    

    }

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet záporných: {0}", negativeNumbs);
    Console.WriteLine("Počet kladných: {0}", positiveNumbs);
    Console.WriteLine("Počet nul: {0}", zeros);
    Console.WriteLine("=============================================");
    Console.WriteLine("Počet sudých: {0}", evenNumbs);
    Console.WriteLine("Počet lichých: {0}", oddNumbs);
    Console.WriteLine("=============================================");
    Console.WriteLine("=============================================");


    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}