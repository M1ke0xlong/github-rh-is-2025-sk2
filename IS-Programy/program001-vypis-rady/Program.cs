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
Console.WriteLine("Zadejte poslední číslo řady (celé číslo):");
while (!int.TryParse(Console.ReadLine(), out last))
{
    Console.WriteLine("Špatně zadaný vstup, zkuste to znovu a jako celé číslo");
}
Console.WriteLine("Zadejte diferenci (celé číslo):");
while (!int.TryParse(Console.ReadLine(), out step))
{
    Console.WriteLine("Špatně zadaný vstup, zkuste to znovu a jako celé číslo");
}
//výstup zadaných hodnot
Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine("Zadali jste tyto hodnoty:");
Console.WriteLine("První číslo řady: {0}", first);
Console.WriteLine("Poslední číslo řady: {0}", last);
Console.WriteLine("Diference číslé řady: {0}", step);
Console.WriteLine("===========================================================================");
Console.WriteLine("První číslo řady: {0}, Poslední číslo řady: {1}, Diference číslé řady: {2}", first, last, step);
Console.WriteLine("===========================================================================");
for (int i = first; i < last; i = i+step) {
    Console.WriteLine(i);
}