namespace _05._MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine(string.Join(' ',num));

            double max=double.MinValue; //Най-малкото число от тип double
            double min=double.MaxValue;



            for (int i = 0; i < num.Length; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }

                if (min > num[i])
                {
                    min = num[i];
                }
            }
            Console.WriteLine($"Max={max}");
            Console.WriteLine($"Min={min}");
        }
    }
}
