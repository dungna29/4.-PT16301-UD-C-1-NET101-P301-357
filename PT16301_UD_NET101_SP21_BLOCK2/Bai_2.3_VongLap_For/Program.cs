using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._3_VongLap_For
{
    class Program
    {
        /*
         * Vòng lặp for
         *
         * Cách gõ: for + tab
         * Công thức:
         *  for (int i = 0; i < UPPER; i++)
            {
                //Thực hiện 1 hành động lặp lại 1 công việc nào đó.
            }
            int i = 0: Điểm bắt đầu của vòng lặp
            i < UPPER: Điều kiện để ngắt vòng lặp
            i++: Tăng i lên 1
         */
        static void Main(string[] args)
        {
            //Bảng cửu chương nhân 8
            int a = 8, c;
            //Cách 1: Sử dụng for
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",a,i,a*i);
            }

            //Cách 2: While
            int b = 1;
            while (b < 10)
            {
                Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
                b++;
            }

            //Cách 3: Do While
            b = 1;
            do
            {
                Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
                b++;
            } while (b < 10);

            while (false)
            {
                Console.WriteLine("Khi while False");
            }

            do
            {
                Console.WriteLine("Khi while False");
            } while (false);
        }
    }
}
