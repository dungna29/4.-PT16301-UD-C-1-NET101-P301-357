using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP
{
    class ServiceSinhVien//Là nơi code các chứng năng của đối tượng
    {
        public ServiceSinhVien()
        {
            
        }

        //Tạo 2 đối tượng bằng bằng contructor có tham số và không tham số
        public void bai1TaoDoiTuongSuDungContructor()
        {
            //Cách 1: Contrcutor có tham số
            SinhVien sv1 = new SinhVien("Tiến", "PH00555", 2000, 5.6);

            //Cách 2: Contrcutor không tham số
            SinhVien sv2 = new SinhVien();
            sv2.Ten = "Long";
            sv2.Msv = "PH00556";
            sv2.NamSinh = 2001;
            sv2.DiemCsharp = 5.9;

            //In ra
            sv1.inRaManHinh();
            sv2.inRaManHinh();
        }

        //Tạo 1 đối tượng do người dùng nhập vào
        public void bai2Tao1DoiTuongDoNguoiDung()
        {
            SinhVien sv1 = new SinhVien();
            Console.Write("Mời bạn nhập tên: ");
            sv1.Ten = Console.ReadLine();
            Console.Write("Mời bạn nhập mã: ");
            sv1.Msv = Console.ReadLine();
            Console.Write("Mời bạn nhập năm sinh: ");
            sv1.NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập điểm C#1: ");
            sv1.DiemCsharp = Convert.ToDouble(Console.ReadLine());

            sv1.inRaManHinh();
        }

        //Tạo nhiều đối tượng sử dụng Array
        public void bai3TaoNhieuDoiTuongArray()
        {
            int input;
            SinhVien[] arrSinhViens;//Khai báo mảng Sinh Viên
            Console.WriteLine("Bạn muốn thêm vào bao nhiêu sinh viên: ");
            input = Convert.ToInt32(Console.ReadLine());
            //Sau khi nhận được số lượng người dùng muốn
            arrSinhViens = new SinhVien[input];//Khởi tạo mảng Sinh viên theo mong muốn người dùng
            for (int i = 0; i < input; i++)
            {
                arrSinhViens[i] = new SinhVien();//KHởi tạo đối tượng tại index
                Console.Write("Mời bạn nhập tên: ");
                arrSinhViens[i].Ten = Console.ReadLine();
                Console.Write("Mời bạn nhập mã: ");
                arrSinhViens[i].Msv = Console.ReadLine();
                Console.Write("Mời bạn nhập năm sinh: ");
                arrSinhViens[i].NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("Mời bạn nhập điểm C#1: ");
                arrSinhViens[i].DiemCsharp = Convert.ToDouble(Console.ReadLine());
            }
            //arrSinhViens[i] = Giá trị đối tượng sinh viên ở vị trí thứ i
            for (int i = 0; i < input; i++)
            {
                arrSinhViens[i].inRaManHinh();//In từng sinh viên ra màn hình
            }
        }
    }
}
