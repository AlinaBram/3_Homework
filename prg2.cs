using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в 
//новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.
//Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
namespace _3_Homework2
{
    class Math
    {
        int sum = 0;

        public int Summa(int i)
        {
            if (i != 0 && i > 0 && i % 2 == 1)
            {
                sum += i;
                return sum;
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;

            do
            {
                try
                {
                    do
                    {
                        Console.Write("Введите целое число. Число 0 - окончание счета:");
                        i = int.Parse(Console.ReadLine());
                        Math obj = new Math();
                        sum = sum + obj.Summa(i);

                    } while (i != 0);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nОшибка, попробуйте еще раз\n");

                }
            } while (true);

            Console.WriteLine($"Сумма всех нечетных положительных чисел: {sum}");
            Console.ReadKey();
        }
    }
}
