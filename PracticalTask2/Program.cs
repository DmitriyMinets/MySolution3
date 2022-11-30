using System;

namespace PracticalTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*В массиве A(N) каждый элемент равен 0, 1 или 2. Переставить элементы массива так, 
             * чтобы сначала располагались все нули, затем все двойки и, наконец, 
             * все единицы (дополнительного массива не заводить).*/

            Random rnd = new Random();
            var rndLenght = rnd.Next(10, 15);
            int[] arrayNumbers = new int[] { };
            Array.Resize(ref arrayNumbers, rndLenght);

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = rnd.Next(0, 3); // Правая граница не включается
            }
            Console.WriteLine($"Длинна массива равна {arrayNumbers.Length}\n");
            for(int i = 0; arrayNumbers.Length > i; i++)
            {
                int temp; // Переменная для хранения временного значения
                for(int j = i + 1; j < arrayNumbers.Length; j++)
                {
                    if(arrayNumbers[i] > arrayNumbers[j])
                    {
                        temp = arrayNumbers[i];
                        arrayNumbers[i] = arrayNumbers[j];
                        arrayNumbers[j] = temp;
                    }
                    if(arrayNumbers[i] == 1 & arrayNumbers[j] == 2)
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
