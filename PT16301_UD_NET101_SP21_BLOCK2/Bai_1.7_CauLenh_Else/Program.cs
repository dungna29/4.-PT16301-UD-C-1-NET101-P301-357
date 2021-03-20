using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._7_CauLenh_Else
{
    class Program
    {
        /*
        * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
        * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
        *
        * Cấu trúc: 
        * if (true)
           {
               Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
           }
           else
           {
               Nếu không thỏa mãn IF thì mặc định là vào ELSE
           }
        */
        static void Main(string[] args)
        {
            // if (true)
            // {
            //     
            // }
            // else
            // {
            //     Console.WriteLine("Tất cả các trường hợp còn lại");
            // }

            /*
             * Viết 1 chương trình nhập điểm GPA C#1
             * Nếu điểm từ 9 đến 10 = Xuất sắc
             * Nếu điểm từ 7 đến 9 = giỏi
             * Nếu điểm từ 6 đến 7 = khá
             * Nếu điểm từ 6 đến 7 = khá
             * Nếu điểm từ 5 đến 6 = Yếu
             * Nếu điểm từ 4 đến 0 = Học lại
             *
             */
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bước 1: Xác định số lượng biến cần dùng và lấy giá trị từ bàn phím
            double diemCsharp;
            Console.WriteLine("Mời bạn nhập điểm C#1: ");
            diemCsharp = Convert.ToDouble(Console.ReadLine());
            
            //Bước 2: Xử lý nghiệp vụ
            if (diemCsharp >=9 && diemCsharp <=10)
            {
                Console.WriteLine("Xuất sắc");
            }
            else
            {
                if (diemCsharp >= 7 && diemCsharp < 9)
                {
                    Console.WriteLine("Giỏi");
                }
                else
                {
                    if (diemCsharp >= 6 && diemCsharp < 7)
                    {
                        Console.WriteLine("Khá");
                    }
                    else
                    {
                        if (diemCsharp >= 5 && diemCsharp < 6)
                        {
                            Console.WriteLine("Yếu");
                        }
                        else
                        {
                            Console.WriteLine("Chúc mừng bạn học lại thành công");
                        }
                    }
                }
            }

            
        }
    }
}
