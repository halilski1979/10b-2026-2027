namespace _03.AddElements_OneLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" | ",num));
            Console.WriteLine();


            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine($"  num[{i}] = {num[i]}");
            }
        }
    }
}
