using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_1._2_BienLaGi
{
    class Program
    {

        /*
         * Bài 1.1 Khai báo biến
         * Định nghĩa biến: Dùng để lưu trữ giá trị hoặc 1 tập giá trị và biến
         * được khở tạo trong bộ nhớ ảo khi chương trình khởi chạy.
         *
         * Công thức: <Kiểu dữ liệu> <Tên Biến> = <Giá trị>;
         *      Khai báo nhiều biến có cùng kiểu dữ liệu trên cùng 1 dòng:
         *      <Kiểu dữ liệu> <Tên Biến1> = <Giá trị>, <Tên Biến2> = <Giá trị>, <tên biến n>;
         *
         * 1. <Kiểu dữ liệu>
         *  + Số nguyên:sbyte, byte, long, int
         *  + Sô thực: float, double, decimal
         *  + Chuỗi hoặc ký tự: string, char
         *  + Logic: bool
         *  + var: nó có thể đại diện là tất cả các kiểu dữ liệu.
         * 2. <Tên Biến>
         *  + Quy tắc:
         *      - Tên biến phải có nghĩa
         *      - Có phân biệt chữ hoa chữ thường
         *      - Không bắt đầu bởi số, không dùng từ khóa
         *      - Cố gắng làm quen đặt tên biến với Tiếng Anh
         *
         *  + Khai báo tên biến với 2 từ trở lên:
         *      - Cách 1: normal = firstname
         *      - Cách 2: CamelCase = FirstName, firstName
         *      - Cách 3: Under_Score = first_name, first_Name
         *  + Biến cục bộ: là biến được khai báo bên trong 1 hàm.
         *  + Biến toàn cục: là biến được khai báo bên ngoài hàm.
         *      - Khi khai báo biến toàn cục sử dụng dấu gạch dưới _ trước tên biến.
         *      - int _year = 1989;
         * 3.<Giá trị>
         *  + Khi khai báo biến có thể khởi tạo giá trị hoặc không khởi tạo giá trị.
         *  + Giá trị phải đúng các quy tắc với kiểu dữ liệu
         *
         */
        private static int _year1 = 2021;//Khai báo biến toàn cục
        static void Main(string[] args)
        {
            int year = 2021;//Biến cục bộ

            //string - chuỗi
            string name = "Long";

            //Logic - True, False
            bool logic1 = true;
            bool logic2 = false;

            //var 
            var string1 = "Long";
            var double1 = 8.6;
            var logic3 = true;
            var char1 = '5';
        }
    }
}
