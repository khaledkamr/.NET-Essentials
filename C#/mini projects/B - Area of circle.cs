// See https://aka.ms/new-console-template for more information
Console.WriteLine("---------------welcome to area of circle programe---------------\n");

try
{
    Console.Write("radius= ");
    //double.TryParse(Console.ReadLine(), out double r);
    double r = Convert.ToDouble(Console.ReadLine());
    double area = 3.14 * r * r;
    Console.WriteLine($"area= {area}");
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}