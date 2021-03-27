using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._5_BaiTongHop
{
    class Program
    { /*
        * Bài tập ôn tập tổng hợp:
        * Viết 1 chương trình có menu sử dụng switch case và vòng lặp:
        *         ------Chương trình 1-------
        *       1. In bảng cửu chương đơn
        *       2. In bảng cửu theo khoảng
        *       3. Kiểm tra học lực Sinh Viên Poly
        *       4. Nhập thông tin sinh viên
        *       5. Thoát.
        *
        * Giải thích:
        *1. In bảng cửu chương đơn: Mời người dùng nhập vào tên 1 bảng cửu chương mà họ muốn sau đó in ra màn hình.
        *
        * 2. In bảng cửu theo khoảng: Mời người dùng nhập vào tên bảng cửu chương theo khoảng. Ví dụ: từ bảng nhân 5 đến nhân 8.
        *
        *3. Kiểm tra học lực Sinh Viên Poly: Cho sinh viên POLY nhập vào điểm tổng kết môn C# và thông báo xếp loại học lực:
        *  diem<=5 --> Yếu
        *  diem<=7 --> Khá 
        *  diem<=8 --> Tiên Tiến
        *  diem<=9 --> Giỏi
        *  diem<=10 --> Xuất sắc
        *
          4. Nhập thông tin nhiều sinh viên gồm các thông tin sau: Tên, Mã Sinh Viên, Năm Sinh. In thông tin sinh viên ra 
            Tên + Mã Sinh Viên + Năm Sinh + Tuổi.
        */
        static void Main(string[] args)
        {
            //Nhập vào 1 dãy số nguyên sau đó in ra màn hình
            int[] arrNumber;
            int sizeArr;
            Console.Write("Bạn muộn nhập bao nhiêu số: ");
            sizeArr = Convert.ToInt32(Console.ReadLine());//Lấy được kích thước mảng do người dùng nhập vào
            arrNumber = new int[sizeArr];//Khởi tạo kích thước mảng sau khi người dùng nhập vào
            while (true)
            {
               
                Console.WriteLine("1. Nhập số");
                Console.WriteLine("2. Xuất số");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        for (int i = 0; i < sizeArr; i++)
                        {
                            Console.WriteLine("Mời bạn nhập số thứ " + i);
                            arrNumber[i] = Convert.ToInt32(Console.ReadLine());//Gán giá trị cho mảng
                         
                        }
                        break;
                    case "2":
                        Console.WriteLine("Dãy số bạn vừa nhập vào là: ");
                        foreach (var x in arrNumber)
                        {
                            Console.Write(x + " ");
                        }
                        break;
                } 
            }
        }
    }
}
