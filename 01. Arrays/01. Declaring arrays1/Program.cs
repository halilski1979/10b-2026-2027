namespace _01._Declaring_arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Деклариране 1

            // 2. Деклариране на масив от 5 цели числа
           int[] num= { 1, 32, 53,11,22,45,65};
           

            //3. Деклариране на масив от имена
            string[] names = {"Ivan","Petar","Kiko","Ani"};

           
            //ПЕЧАТ 1  -   с цикъл FOR
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            Console.WriteLine();
            //Печат 2
            foreach (var element in num)
            {
                Console.WriteLine(element);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //ПЕЧАТ 3
            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine(string.Join(", ",names));




        }
    }
}
