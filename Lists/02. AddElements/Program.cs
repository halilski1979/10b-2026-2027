namespace _02._AddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I начин
            List<int> num = new List<int>();
            num.Add(4);
            num.Add(15);
            num.Add(5);
            num.Add(-12);

            Console.WriteLine(num[2]);
            Console.WriteLine(string.Join("=>",num));
            Console.WriteLine();
            
            //II начин
            var number = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"number[{i}]=");
                number.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join(" ",number));

        }
    }
}
