using System;

namespace PracticalTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1.1
            Random rnd = new Random();
            var rndLenght = rnd.Next(10, 15);
            int[] arrayNumbers = new int[] {};
            Array.Resize(ref arrayNumbers, rndLenght);

            for(int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = rnd.Next(0, 200);
            }

            Console.WriteLine($"Длинна массива равна {arrayNumbers.Length}");

            foreach(int i in arrayNumbers)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            
            // Task 1.2 
            // Используем для данного задания, ранее созданный массив

            for(int i = 0; i < arrayNumbers.Length; i++)
            {
                if(arrayNumbers[i] > 9 & arrayNumbers[i] % 5 == 0)
                {
                    Console.Write(arrayNumbers[i] + " ");
                }
            }
            Console.WriteLine();
            //Task 1.3

            int number = -20;
            do
            {
                Console.WriteLine(number);
                number -= 20;

            }while(number >= -100);



        }
    }
}
