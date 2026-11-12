namespace ConsoleApp2
{
    internal class Program
    {
        static int validTeamsCount = 0;
        static void Main(string[] args)
        {
            // Четене на първия ред: N, K, L, R
            string[] firstLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);
            int l = int.Parse(firstLine[2]);
            int r = int.Parse(firstLine[3]);

            // Четене на втория ред: точките на учениците
            int[] scores = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            // Стартиране на рекурсивното търсене
            FindTeams(scores, 0, 0, 0, k, l, r);

            // Извеждане на крайния резултат
            Console.WriteLine(validTeamsCount);
        }

        static void FindTeams(int[] scores, int index, int currentCount, int currentSum, int k, int l, int r)
        {
            // Ако вече сме събрали нужния брой ученици (K)
            if (currentCount == k)
            {
                // Проверяваме дали сумата е в интервала [L, R]
                if (currentSum >= l && currentSum <= r)
                {
                    validTeamsCount++;
                }
                return;
            }

            // Ако сме обходили всички ученици, но не сме събрали K на брой, или текущата сума е надхвърлила R
            if (index >= scores.Length || currentSum > r)
            {
                return;
            }

            // Оптимизация: ако оставащите ученици не са достатъчни за запълване на отбора
            if (scores.Length - index < k - currentCount)
            {
                return;
            }

            // Вариант 1: Включваме текущия ученик в отбора
            FindTeams(scores, index + 1, currentCount + 1, currentSum + scores[index], k, l, r);

            // Вариант 2: Пропускаме текущия ученик
            FindTeams(scores, index + 1, currentCount, currentSum, k, l, r);
        }
    }
}
