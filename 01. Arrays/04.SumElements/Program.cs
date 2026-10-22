namespace _04.SumElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] {2,3,1,5};

            Console.WriteLine(string.Join(" ",num));
            
            
            //Сума на масив
            int s = 0;
            int p = 1;

            for (int i = 0; i < num.Length; i++)
            {
                s += num[i];
            }

            Console.WriteLine($"S={s}");

            for (int i = 0; i < num.Length; i++)
            {
                p *= num[i];
            }
            Console.WriteLine($"P={p}");

        }
    }
}
