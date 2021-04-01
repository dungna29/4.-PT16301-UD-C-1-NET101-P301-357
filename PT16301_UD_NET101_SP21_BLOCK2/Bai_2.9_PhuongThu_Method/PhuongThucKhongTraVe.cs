using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_PhuongThu_Method
{
    class PhuongThucKhongTraVe
    {
        /*
         *  Phương thức không trả về là : Void
         *   Công thức chung:
         *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
         *  {
         *          Body code
         *  }
         */

        //Phương thức không trả về và không tham số
        public void tinhTong2So()//Vì bên trong ngoặc không có tham số
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số thứ 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số thứ 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tổng 2 số bạn vừa nhập vào là : " + (a+b));
        }
        //Phương thức không trả về và có tham số

        //Phương thức dưới đây không sử dụng được vì trùng tên với phương thức trên
        // public void tinhTongSo()
        // {
        //
        // }

        //Phước thức trùng tên nhưng khác tham số được gọi là nạp chồng phương thức Overloading
        public void tinhTongSo(int a, int b)//int a, int b được gọi là tham số truyền vào
        {
            Console.WriteLine("Tổng 2 số bạn vừa nhập vào là : " + (a + b));
        }

        public void tinhTong2So(int a, int b,int c)//int a, int b được gọi là tham số truyền vào
        {
            Console.WriteLine("Tổng 2 số bạn vừa nhập vào là : " + (a + b + c));
        }
        public void tinhTong2So(int a, int b, int c,int d)//int a, int b được gọi là tham số truyền vào
        {
            Console.WriteLine("Tổng 2 số bạn vừa nhập vào là : " + (a + b + c + d));
        }

        //Lưu ý: Tham số có thể là những liểu dữ liệu khác nhau
        public void method1(int a, string b, int[] arr, string[] arrName, List<SinhVien> lstSinhViens, SinhVien sv)
        {
            
        }
    }
}
