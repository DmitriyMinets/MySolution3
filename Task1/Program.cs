namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int.TryParse(Console.ReadLine(), out inputNumber);

            string results = inputNumber switch
            {
                >= 0 and <= 30 => "Число попало в промежуток от 0 до 30",
                >= 31 and <= 60 => "Число попало в промежуток от 31 до 60",
                >= 61 and <= 100 => "Число попало в промежуток от 61 до 100",
                _=> "Я такого числа не знаю"
            };
            Console.WriteLine(results);
        }
    }
}