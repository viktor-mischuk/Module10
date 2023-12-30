namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
           
            try
            {
                Console.Write("Введите первое число: ");
                double numb1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double numb2 = Convert.ToDouble(Console.ReadLine());

                double sum = calculator.Sum(numb1, numb2);
                Console.WriteLine($"Сумма чисел равна - {sum}");

            }
            catch 
            {
                Console.WriteLine("Введено не верное значение");
            }

        }
    }
}
