using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Modules
{
    internal class Logger : ILogger
    {
        public void CorrectData(ref long val)
        {
            if (long.TryParse(Console.ReadLine(), out val) == false)
            {
                throw new FormatException("Введите корректные данные...");
            }
        }

        public void Solve(IAddition addition)
        {
            try
            {
                long Value1 = default(long);
                long Value2 = default(long);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Введите значение 1: ");
                CorrectData(ref Value1);

                Console.Write("Введите значение 2: ");
                CorrectData(ref Value2);

                
                long result = addition.Sum(Value1, Value2);
                addition.ShowResult(Value1, Value2, result);
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Значение результата находится за пределами диапазона допустимых значений\n" +
                    $"{long.MinValue} < Результат должен быть < {long.MaxValue}");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
       
    }
}
