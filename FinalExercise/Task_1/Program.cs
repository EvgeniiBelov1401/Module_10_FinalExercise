using Task_1.Modules;

namespace Task_1
{
    internal class Program
    {
        /*
         * Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел. 
         * Определите интерфейс для функции сложения числа и реализуйте его.
         * Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.
         */
    
        static void CorrectData(ref long val)
        {
            if (long.TryParse(Console.ReadLine(), out val) == false)
            {
                throw new FormatException("Введите корректные данные...");
            }  
        }
        static void Solve()
        {
            try
            {
                long Value1 = default(long);
                long Value2 = default(long);

                Console.Write("Введите значение 1: ");
                CorrectData(ref Value1);

                Console.Write("Введите значение 2: ");
                CorrectData(ref Value2);

                IAddition addition = new AddingTwoNumbers();
                long result = addition.Sum(Value1, Value2);
                addition.ShowResult(Value1, Value2, result);
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Solve();

                Console.ReadLine();
                Console.Clear();
            }
            
            
        }
    }
}
