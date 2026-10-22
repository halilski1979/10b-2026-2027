namespace _06._MetodsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {2,4,5,6,1,3};
            Console.WriteLine(string.Join(' ',num));

            //Сума на масив
            int s = num.Sum();
            Console.WriteLine($"Suma: {s}");

            //Mин и Макс на масив
            Console.WriteLine($"Min={num.Min()}");
            Console.WriteLine($"Max={num.Max()}");

            Console.WriteLine($"average={num.Average()}");
            Console.WriteLine( num.Length);

            
            Console.WriteLine(string.Join(' ',num.Reverse()));
        }
    }
}
