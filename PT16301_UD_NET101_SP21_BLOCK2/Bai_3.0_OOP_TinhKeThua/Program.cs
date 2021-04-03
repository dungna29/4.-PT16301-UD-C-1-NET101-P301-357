using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_OOP_TinhKeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            //Tạo 3 lớp đối tượng
            /*
             * 1. SinhVien(ten,ho,tendem,sdt,email,msv,diemJava,diemCsharp)
             * 2. GiaoVien(ten,ho,tendem,sdt,email,mgv,gioDay)
             * 3. KeToan(ten,ho,tendem,sdt,email,mnv,luong)
             */

            //Chương trình đối tượng sinh viên
            SinhVien sv1 = new SinhVien();
            // Console.Write("Mời bạn nhập Họ: ");
            // sv1.Ho = Console.ReadLine();
            // Console.Write("Mời bạn nhập Tên Đệm: ");
            // sv1.TenDem = Console.ReadLine();
            // Console.Write("Mời bạn nhập Tên: ");
            // sv1.Ten = Console.ReadLine();
            // Console.Write("Mời bạn nhập Sđt: ");
            // sv1.Sdt = Console.ReadLine();
            // Console.Write("Mời bạn nhập Email: ");
            // sv1.Email = Console.ReadLine();
            // Console.Write("Mời bạn nhập Msv: ");
            // sv1.Msv = Console.ReadLine();
            // Console.Write("Mời bạn nhập Điểm Java: ");
            // sv1.DiemJava = Convert.ToDouble(Console.ReadLine());
            // Console.Write("Mời bạn nhập Điểm C#1: ");
            // sv1.DiemCsharp = Convert.ToDouble(Console.ReadLine());
            // sv1.inRaManHinhCuaSinhVien();

            sv1.inRaManHinhCuaCha();
            sv1.inRaManHinhCuaChaChoConSuDung();
        }
    }
}
