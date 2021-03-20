using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._4_EpKieu
{
    class Program
    {
        /*
         * P1: Ép kiểu - Chuyển đổi từ kiểu dữ liệu số sang dạng số khác - Không đổ kiểu dữ liệu lớn về bé mà chỉ bé lên lớn ví dụ int lớn hơn byte hoặc long nhất trong số nguyên. Ngoài ra các bạn có thể tham khảo lại trong bảng kích thước kiểu dữ liệu.
         *
         * Công thức ép kiểu tường minh:
         *        (<kiểu dữ liệu>) <biến cần ép kiểu>;
         *
         * P2: Ép kiểu từ string về số
         *  + Phương thức Parse()
         *  + Lớp Convert()
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Bước 1: Xác định số lượng biến cần dùng
            string a, b,c;
            //Bước 2: Triển khai 
            Console.WriteLine("Mời bạn nhập số thứ 1: ");
            a = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập số thứ 2: ");
            b = Console.ReadLine();
            c = a + b;
            Console.WriteLine("{0} + {1} = {2}",a,b,c);

            //Cách 1: Ép kiểu string về số sử dụng Convert.
            int kq = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine("Sử dụng Convert {0} + {1} = {2}", a, b, kq);
            
            //Cách 2: Ép kiểu string về số sử dụng parse
            int kq1 = int.Parse(a) + int.Parse(b);
            Console.WriteLine("Sử dụng Parse {0} + {1} = {2}", a, b, kq1);
            
            //Ép kiểu ngay khi nhập liệu
            int year;
            Console.WriteLine("Mời bạn nhập năm hiện tại: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Năm hiện tại : " + year);
              /*
               Bài 1: Chương trình cho phép nhập họ và tên sinh viên, năm sinh, mã sinh viên từ bàn phím và xuất ra định dạng sau: 
               “Chào bạn <<họ và tên>> | <<năm sinh>>  | <<mã sinh viên>> 
               đến với chương trình Csharp1 đầu tiên.”

                Bài 2: Nhập 3 đầu điểm Địa, Toán, Văn sau đó tính điểm trung bình của 3 đầu điểm đó.
               */
        }
    }
}
