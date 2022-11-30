using System;

namespace PracticalTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int[] arrayNumbers = new int[] { 1, 2, 4, 5, 12, 5, 3, 5 };

            marker:
            Console.Write(arrayNumbers[index] + " ");
            if(arrayNumbers.Length - 1 > index)
            {
                index++;
                goto marker;
            }

        }
    }
}
