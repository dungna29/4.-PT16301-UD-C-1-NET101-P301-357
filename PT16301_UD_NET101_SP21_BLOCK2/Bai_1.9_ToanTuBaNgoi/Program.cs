using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._9_ToanTuBaNgoi
{
    class Program
    {
        /*
        * TOÁN TỬ 3 NGÔI
        * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Ví dụ 1:
            string kq = 5 > 1 ? "Đúng" : "Sai";
            Console.WriteLine(kq);

            //Ví dụ 2:
            int nghi = 4;
            double diemCsharp = 5, gpa = 5;
            string kqHoc = (nghi <= 4 || diemCsharp >= 5 || gpa >= 5) ? "Qua môn" : "Toang";
            Console.WriteLine(kqHoc);

            //Ví dụ 3 các kiểu dữ liệu khác nhau
            int logic1 = 5 > 5 ? 55 : 56;//Kết quả trả ra phải đúng kiểu dữ liệu
            bool logic2 = 5 > 5 ? true : false;

            //Ví dụ 4: Viết 1 chương trình đăng nhập
            while (true)
            {
                string id, pass, result;
                Console.Write("Id = ");
                id = Console.ReadLine();
                Console.Write("Pass = ");
                pass = Console.ReadLine();
                result = id == "admin" && pass == "123" ? "Đăng nhập thành công" : "Thất bại";
                Console.WriteLine(result);
            }
        }
    }
}
