using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_PhuongThu_Method
{
    class PhuongThucTraVe
    {
        /*
         *  Phương thức trả về là :
         *   Công thức chung:
         *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
         *  {
         *          Body code
         *  }
         */

        //Phương thức trả về không tham số
        /*
         * Hướng dẫn sử dụng:
         *      1. Phương thức phải có kiểu trả về là các kiểu dữ liệu
         *      2. Phải Sử dụng return <giá trị hoặc tập giá trị....> đúng với kiểu dữ liệu
         */
        public int tinhTong()
        {
            int a, b;
            Console.WriteLine("Mời bạn nhập số thứ 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời bạn nhập số thứ 2: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Không quan trọng số lượng dòng code ở trên luôn phải trả về đúng kiểu dữ liệu của phương thức
            return a + b;//Trả về đúng kiểu dữ liệu
        }

        public string[] getYears()
        {
            string[] arrYears = new string[200];
            int temp = 1900;
            for (int i = 0; i < arrYears.Length; i++)
            {
                arrYears[i] = Convert.ToString(temp);
                temp++;
            }
            return arrYears;
        }

        public SinhVien getSV()
        {
            SinhVien sv1 = new SinhVien("Tú", "PH000", 2000, 5.6);
            return sv1;
        }

        //Phương thức trả về không tham số sử dụng như bên không trả về
        public SinhVien getSV(string ten,string msv,int namsinh, double diem)
        {
            SinhVien sv1 = new SinhVien(ten, msv, namsinh, diem);
            return sv1;
        }
    }
}
