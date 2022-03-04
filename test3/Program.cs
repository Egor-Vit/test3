using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите А");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите А");
            Console.WriteLine("Решение:\n+Сложение, \n-Вычетание, \n*Умножение, \n/Деление");
            string X = Console.ReadLine();
            string plus;
            string minus;
            string um;
            string del;

            if (X == "+")
            {
                int C = A + B;
                Console.WriteLine("Ответ:" + C);
            }
            else if (X == "-")
            {
                int C = A - B;
                Console.WriteLine("Ответ:" + C);
            }
            else if (X == "*")
            {
                int C = A * B;
                Console.WriteLine("Ответ:" + C);
            }
        }
    }
}
