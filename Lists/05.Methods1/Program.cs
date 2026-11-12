namespace _05.Methods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> num=new List<int>() {2,4,5,11,12,7,8,4};
            Console.WriteLine(string.Join(' ',num));


            //1. RemoveAt - изтрива по индекс
            num.RemoveAt(4);
            Console.WriteLine(string.Join(' ', num));

            //2. Remove - изтрива първият елемент ссъ стойност N
            num.Remove(4);
            Console.WriteLine(string.Join(' ', num));

            //3. Count - броя на елементите
            Console.WriteLine($"Broy elementi: {num.Count()}");

            
            
            //4. Insert(M,N) - вмъква елемента N на индекс M
            //   num.Insert(3,5) - вмъква елемента 5 на индекс 3
            num.Insert(3,1111);
            Console.WriteLine(string.Join(' ', num));

            Console.WriteLine(num.Contains(5));
        }
    }
}
