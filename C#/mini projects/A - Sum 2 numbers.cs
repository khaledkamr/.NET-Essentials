namespace sum_2_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------welcome to sum 2 numbers---------------\n");

            try
            {
                Console.Write("first number: ");
                //int.TryParse(Console.ReadLine(), out int x);
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("second number: ");
                //int.TryParse(Console.ReadLine(), out int y);    
                int y = Convert.ToInt32(Console.ReadLine());

                int res = x + y;
                Console.WriteLine("result= " + x + "+" + y + " = " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
        }
    }
}
