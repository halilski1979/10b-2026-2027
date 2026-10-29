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

            
            //Обръщане на елементите на масив
            Array.Reverse(num);
            Console.WriteLine(string.Join(',',num));

            //Сортиране на масив
            Array.Sort(num);
            Console.WriteLine(string.Join(' ',num));


            //Произведение на масив
            int pr = 1;
            for (int i = 0; i < num.Length; i++)
            {
                pr *= num[i];
            }
            Console.WriteLine($"Proizvedenie: {pr}");

            //Печат на четни числа
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]%2==0)
                {
                    Console.Write($" {num[i]}");
                }
            }
            int sumNechetni = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 1)
                {
                    sumNechetni+=num[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine(sumNechetni);


        }
    }
}
