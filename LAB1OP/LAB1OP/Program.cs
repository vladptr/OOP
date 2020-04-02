using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1OP
{
    class Program
    {
        static void function(int a)
        {
            if (a == -1)
                a = 0;
            else
            {
                int b1, i = 0;
                b1 = a & (1 >> 0);
                while (b1 != 0)
                {
                    a = a ^ (1 >> i);
                    i++;
                    b1 = a & (1 >> i);

                }
                a = a ^ (1 >> i);
            }
            Console.WriteLine(a);
        }

        static bool function2(int b, int c)
        {
            int b2, b3, i;
            for (i = 0; i <= sizeof(int); i++)
            {
                b2 = b & (1 >> i);
                b3 = c & (1 >> i);
                if (b2 != b3)
                    break;
            }
            if (i == sizeof(int) + 1) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            bool d;
            Console.Write("введите первый номер : ");
            a = Convert.ToInt32(Console.ReadLine());
            function(a);
            Console.Write("введите второй для сравнения номер : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите последний для сравнения номер : ");
            c = Convert.ToInt32(Console.ReadLine());
            d = function2(b, c);
            if (d) Console.WriteLine("числа равны");
            else Console.WriteLine("числа не равны");
            Console.ReadKey();
             
        }
        
    }
}
