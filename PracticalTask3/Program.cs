using System;

namespace PracticalTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputChar = Convert.ToChar(Console.ReadLine().ToUpper());
            var results = inputChar switch
            {
                'W' => "Фигуру нужно переместить вверх",
                'A' => "Фигуру нужно переместить влево",
                'S' => "Фигуру нужно переместить вниз",
                'D' => "Фигуру нужно переместить вправо",
                _ => "Фигуру не нужно перемещать",
            };
            Console.WriteLine(results);


        }
    }
}
