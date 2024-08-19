// See https://aka.ms/new-console-template for more information
Console.WriteLine("-------------------compare 3 numbers-------------------\n");

Console.Write("number 1: ");
int.TryParse(Console.ReadLine(), out int x);
Console.Write("number 2: ");
int.TryParse(Console.ReadLine(), out int y);
Console.Write("number 3: ");
int.TryParse(Console.ReadLine(), out int z);

Console.WriteLine("\nthe correct order:");
if(x > y && x > z)
{
    Console.WriteLine((y > z) ? $"{x} > {y} > {z}" : $"{x} > {z} > {y}");
}
else if(y > x && y > z)
{
    Console.WriteLine((x > z) ? $"{y} > {x} > {z}" : $"{y} > {z} > {x}");
}
else
{
    Console.WriteLine((x > y) ? $"{z} > {x} > {y}" : $"{z} > {y} > {x}");
}

