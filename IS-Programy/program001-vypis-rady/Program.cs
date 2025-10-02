//print v konzoli
Console.WriteLine("************************");
Console.WriteLine("***Výpis číselné řady***");
Console.WriteLine("*******Roman Hozák******");
Console.WriteLine("********2.10.2025*******");
Console.WriteLine("************************");
Console.WriteLine("************************");

//definování proměnných
int first, last, step;
//lepsi vstup
Console.WriteLine("Zadejte první číslo řady (celé číslo):");
while (!int.TryParse(Console.ReadLine(), out first))
{
    Console.WriteLine("Špatně zadaný vstup, zkuste to znovu a jako celé číslo");
}
/*
//první číslo
Console.WriteLine("first = ");
first = int.Parse(Console.ReadLine());
//poslední číslo
Console.WriteLine("last = ");
last = int.Parse(Console.ReadLine());
//kroky
Console.WriteLine("step = ");
step = int.Parse(Console.ReadLine());
//vypsání prvního čísla a loop
Console.WriteLine("\n" + first);
while (true)
{
    if ((first + step) <= last)
    {
        first = first + step;
        Console.WriteLine(first);
    }
    else
    {
        break;
    }
}
*/