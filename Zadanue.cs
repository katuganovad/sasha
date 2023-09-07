using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1
{
    class Zadanue
    {
        public void zadan1()
        {
            int n;
            do
            {
                Console.WriteLine("Введите целое число, факториал которого вы хотите найти: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);
           Console.WriteLine("Фактриал числа " + n + " равен " + FindFactorial(n));
            int FindFactorial(int x)
            {
                if ((x==1) || (x==0))
                    return 1;
                return x*FindFactorial(x-1);
            }
            Console.ReadKey();
        }
        public void zadan2()
        {
                double x;
                do
                {
                    Console.WriteLine("Введите значение аргумента X: ");
                    x = double.Parse(Console.ReadLine());
                    if (x > 4)
                    {
                        Console.WriteLine("Значение аргумента Х должно быть меньше или равно 4. ");
                    }
                    else if (x <= 0)
                    {
                        Console.WriteLine("Значение аргумента Х должно быть больше нуля. ");
                    }
                } while ((x <= 0) || (x > 4));
                double a = Math.Round((Math.Sqrt(Math.Log(4 / x)) - (1 / x) - Math.Pow(Math.E, Math.Sin(x))), 2);
                Console.WriteLine("Значение выражения после подстановки " + x + " равно " + a);
                Console.ReadKey();
            
        }
        public void zadan3()
        {
            Console.WriteLine("Введите целое число для последовательности Фибоначчи ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ответ: " + Fiban(f));

            int Fiban(int fi)
            {
                if (fi == 0)
                    return 0;
                return (fi-1) + Fiban(fi);
            }
            
            Console.ReadKey();
        }
    }
}
