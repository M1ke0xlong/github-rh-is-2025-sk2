static void Main(string[] args)
{
    // Nastavení kódování pro správné zobrazení češtiny
    Console.OutputEncoding = Encoding.UTF8;
    Console.InputEncoding = Encoding.UTF8;

    // 1. Seznam 20+ českých slov (musí mít přesně 5 písmen)
    string[] slova = new string[]
    {
        "KOČKA", "DŮRAZ", "CESTA", "MĚSTO", "ŠKOLA",
        "KNIHA", "STROM", "PÍSEŇ", "KAPKA", "RÁDIO",
        "TÝDEN", "MĚSÍC", "BRÁNA", "HLAVA", "SRDCE",
        "ŽIVOT", "TRÁVA", "BARVA", "POKOJ", "MRKEV",
        "LÁSKA", "DVEŘE", "JELEN", "BANÁN", "DÁREK"
    };

    // Výběr náhodného slova
    Random rnd = new Random();
    string tajenka = slova[rnd.Next(slova.Length)].ToUpper();

    // Počet pokusů
    int maxPokusu = 6;
    bool uhadnuto = false;

    Console.WriteLine("--- KONZOLOVÉ WORDLE ---");
    Console.WriteLine("Uhádkni slovo na 5 písmen (používej diakritiku: háčky/čárky).");
    Console.WriteLine("LEGENDA: Zelená = správně, Žlutá = špatné místo, Šedá = není ve slově.\n");

    // Hlavní smyčka hry
    for (int pokus = 1; pokus <= maxPokusu; pokus++)
    {
        Console.Write($"Pokus {pokus}/{maxPokusu} > ");
        string vstup = Console.ReadLine();

        // Validace vstupu
        if (string.IsNullOrWhiteSpace(vstup) || vstup.Length != 5)
        {
            Console.WriteLine("Chyba: Slovo musí mít přesně 5 písmen. Zkus to znovu.");
            pokus--; // Nepočítat tento pokus
            continue;
        }

        vstup = vstup.ToUpper();

        // Vykreslení barevného výsledku
        VykresliObarveneSlovo(vstup, tajenka);

        // Kontrola výhry
        if (vstup == tajenka)
        {
            uhadnuto = true;
            break;
        }
    }

    // Konec hry
    Console.WriteLine();
    if (uhadnuto)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("GRATULUJI! Uhádl jsi tajenku.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Bohužel, pokusy došly. Tajenka byla: {tajenka}");
    }

    Console.ResetColor();
    Console.WriteLine("Stiskni Enter pro ukončení...");
    Console.ReadLine();
}

static void VykresliObarveneSlovo(string vstup, string tajenka)
{
    // Pole pro uložení stavu barev (0 = šedá, 1 = žlutá, 2 = zelená)
    int[] barvy = new int[5];

    // Pomocné pole znaků tajenky, abychom mohli "škrtat" již použité písmena
    char[] znakyTajenky = tajenka.ToCharArray();
    bool[] pouzitoVTajence = new bool[5]; // Indikuje, zda jsme tuto pozici v tajence už spárovali

    // 1. PRŮCHOD: Hledáme ZELENÉ (přesná shoda pozice a znaku)
    for (int i = 0; i < 5; i++)
    {
        if (vstup[i] == tajenka[i])
        {
            barvy[i] = 2; // Zelená
            pouzitoVTajence[i] = true; // Toto písmeno v tajence je vyřešené
        }
    }

    // 2. PRŮCHOD: Hledáme ŽLUTÉ (písmeno je jinde)
    for (int i = 0; i < 5; i++)
    {
        if (barvy[i] == 2) continue; // Už je zelené, přeskakujeme

        for (int j = 0; j < 5; j++)
        {
            // Pokud pozice J v tajence ještě nebyla použita A znaky se shodují
            if (!pouzitoVTajence[j] && vstup[i] == znakyTajenky[j])
            {
                barvy[i] = 1; // Žlutá
                pouzitoVTajence[j] = true; // Odškrtneme, aby se jedno písmeno v tajence nepoužilo pro dvě žluté
                break;
            }
        }
    }

    // 3. VYKRESLENÍ: Podle vypočítaných barev
    Console.Write("Výsledek: ");
    for (int i = 0; i < 5; i++)
    {
        switch (barvy[i])
        {
            case 2:
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                break;
            case 1:
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                break;
            default:
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }

        Console.Write($" {vstup[i]} "); // Písmeno s mezerami pro lepší vzhled
        Console.ResetColor(); // DŮLEŽITÉ: Resetovat barvu hned po písmenu
        Console.Write(" "); // Mezera mezi dlaždicemi
    }
    Console.WriteLine(); // Odřádkování
}