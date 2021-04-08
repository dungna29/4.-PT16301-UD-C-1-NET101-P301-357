using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP_CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string input;
            ServiceSinhVien sv = new ServiceSinhVien();
            do
            {
                Console.WriteLine("1. Thêm SV");
                Console.WriteLine("2. Xóa SV");
                Console.WriteLine("3. Tìm SV");
                Console.WriteLine("4. Sửa SV");
                Console.WriteLine("5. Sắp xếp SV");
                Console.WriteLine("6. Xuất ds SV");
                Console.WriteLine("7. Thoát");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        sv.themSV();
                        break;
                    case "2":
                        sv.xoaSV();
                        break;
                    case "3":
                        sv.timKiemSV();
                        break;
                    case "4":
                        sv.suaSV();
                        break;
                    case "5":
                        sv.sapXepDsSVTheoTen();
                        break;
                    case "6":
                        sv.xuatDanhSachSv();
                        break;
                    case "7":
                        Console.WriteLine("Hẹn gặp lại lần sau");
                        break;
                    default:
                        Console.WriteLine("Chức năng bạn chọn không tồn tại");
                        break;
                }
            } while (!(input =="7"));
        }
    }
}
