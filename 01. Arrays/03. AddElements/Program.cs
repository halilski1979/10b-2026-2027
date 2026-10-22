namespace _03._AddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}]=");
                num[i]=int.Parse( Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ",num));
        }
    }
}
