namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var rndLenght = rnd.Next(10, 20);
            int[] arrayNumbers = new int[] { };
            Array.Resize(ref arrayNumbers, rndLenght);

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = rnd.Next(0, 40); // Правая граница не включается
            }
            Console.WriteLine($"Длинна массива равна {arrayNumbers.Length}\n");
            for (int i = 0; arrayNumbers.Length > i; i++)
            {
                int temp; // Переменная для хранения временного значения
                for (int j = i + 1; j < arrayNumbers.Length; j++)
                {
                    if (arrayNumbers[i] > arrayNumbers[j])
                    {
                        temp = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[j];
                        arrayNumbers[j] = temp;
                    }

                }
            }

            foreach (int i in arrayNumbers)
            {
                Console.Write(i + " ");
            }
        }
    }
}