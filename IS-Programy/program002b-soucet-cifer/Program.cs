
        Console.Write("Zadej celé číslo: ");
        string input = Console.ReadLine();

        // Pokud je číslo záporné, odstraníme znaménko '-'
        if (input.StartsWith("-"))
            input = input.Substring(1);

        // Rozdělení na jednotlivé znaky
        char[] znaky = input.ToCharArray();

        int soucet = 0;
        int soucin = 1;

        foreach (char znak in znaky)
        {
            int cifra = znak - '0'; // převod z char na číslo
            soucet += cifra;
            soucin *= cifra;
        }

        Console.WriteLine("Součet cifer: " + soucet);
        Console.WriteLine("Součin cifer: " + soucin);
