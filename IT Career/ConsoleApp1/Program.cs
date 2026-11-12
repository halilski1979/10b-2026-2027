namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] firstLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int d = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);
            int n = int.Parse(firstLine[2]);

            int[] stations = new int[n];

            
            if (n > 0)
            {
                string[] secondLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < n; i++)
                {
                    stations[i] = int.Parse(secondLine[i]);
                }
                
                Array.Sort(stations);
            }

            int currentPosition = 0;
            int chargesCount = 0;
            int iStation = 0;

            
            while (currentPosition + k < d)            {
                int nextPosition = currentPosition;               
                while (iStation < n && stations[iStation] <= currentPosition + k)
                {
                    nextPosition = stations[iStation];
                    iStation++;
                }                
                if (nextPosition == currentPosition)
                {
                    Console.WriteLine(-1);
                    return;
                }               
                currentPosition = nextPosition;
                chargesCount++;
            }           
            Console.WriteLine(chargesCount);
        }
    }
}
