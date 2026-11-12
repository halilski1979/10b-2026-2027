namespace _04._Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход на елементи от 1 ред
            List<int> num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(' ',num));

            //Добавяне на елемент в края
            num.Add(123);
            num.Add(124);
            Console.WriteLine(string.Join(' ', num));

            //Печат MAX
            Console.WriteLine($"Max={num.Max()}");

            //Печат MIN
            Console.WriteLine($"MIN: {num.Min()}");

            //Печат SUM
            Console.WriteLine($"Sumata e: {num.Sum()}");

            //Сортиране на списък SORT
            num.Sort();
            Console.WriteLine(string.Join(' ', num));

            //Обръщане на елементите на масив
            num.Reverse();
            Console.WriteLine(string.Join(' ', num));

            



        }
    }
}
