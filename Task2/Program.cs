using System.Runtime.CompilerServices;

namespace Task2
{
    internal class Program
    {
       static ILogger Logger {  get; set; }   
        static void Main(string[] args)
        {
          Logger = new Logger();

            Calculator calculator = new Calculator(Logger);

            try
            {
                Console.Write("Введите первое число: ");
                double numb1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double numb2 = Convert.ToDouble(Console.ReadLine());

                double sum = calculator.Sum(numb1, numb2);

                
                Console.WriteLine($"Сумма чисел равна - {sum}");
                Console.WriteLine();
                Logger.Event("Значение вычислена корректно");


            }
            catch
            {
                Console.WriteLine("Введено не верное значение");
                Logger.Error("Значение не вычислено");
                
            }






        }


    }
}
