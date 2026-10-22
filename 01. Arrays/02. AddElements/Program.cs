namespace _02._AddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Добавяне на елементи от един ред
            var names=Console.ReadLine().Split(' ').ToArray();

            //I начин за печат
            Console.WriteLine(string.Join(" | ",names));
            Console.WriteLine($"Lenght:{names.Length}");

            //II начин за печат
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names[{i}]:  {names[i]}");
            }

            //III начин за печат
            foreach (var item in names)     //Ivan Petq Katqw
            {
                Console.WriteLine(item); 
            }

        }
    }
}
