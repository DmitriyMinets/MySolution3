namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = 200, maxValue = 500;
            string results =string.Empty;
            while(minValue <= maxValue)
            {
                if(minValue % 17 == 0)
                {
                    results += $"{minValue} "; 
                }
                minValue++;
            }
            results = results.Trim();
            Console.WriteLine(results.Replace(' ', ','));
        }
    }
}