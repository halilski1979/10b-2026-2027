namespace _01._Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Int={a}");

            double b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Double={b}");

            string name= Console.ReadLine();
            Console.WriteLine($"String: {name}");

            char ch=char.Parse(Console.ReadLine());
            Console.WriteLine($"Char: {ch}");

            bool flag=false;
            Console.WriteLine($"Bool: {flag}");

            
        }
    }
}
