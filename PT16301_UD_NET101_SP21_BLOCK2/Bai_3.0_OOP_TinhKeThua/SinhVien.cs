using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_OOP_TinhKeThua
{
    /*
     * Muốn sử dụng kế thừa sử dụng dấu : <Tên lớp cha>
     * 1 con thì chỉ có 1 cha
     * Khi đã kế thừa lớp con hoàn toàn kế thừa lại những thuộc tính và phương thức mà cha nó cho phép
     */
    class SinhVien : Person
    {
        //Các thuộc tính lớp con sẽ chỉ cần là các thuộc tính đặc trưng riêng của đối tượng
        private string msv;
        private double diemJava;
        private double diemCsharp;

        public SinhVien()
        {

        }

        /*
         * Bước 1: Chuột phải vào Class Cha kế thừa ở trên chọn Quick Action.... -->Contructor
         * Bước 2: Bôi vào thuộc tính của lớp con chọn Add Param...-->Chọn đến contructor vừa tạo
         */
        public SinhVien(string ho, string tenDem, string ten, string sdt, string email, string msv, double diemJava, double diemCsharp) : base(ho, tenDem, ten, sdt, email)
        {
            this.msv = msv;
            this.diemJava = diemJava;
            this.diemCsharp = diemCsharp;
            //this: Dùng để tham chiếu đến thuộc tính và phương thức của lớp hiện tại
            //base: Dùng để tham chiếu đến thuộc tính và phương thức của lớp cha
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public double DiemJava
        {
            get => diemJava;
            set => diemJava = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }
        public void inRaManHinhCuaSinhVien()
        {
            Console.WriteLine("Họ Và Tên: {0} | Sdt:{1} Email:{2} Msv:{3} DiemJava:{4}  DiemCharp:{5}", (Ho + TenDem + Ten), Sdt, Email, msv, diemJava, diemCsharp);
        }

        //Đây là phương thức được kế thừa của lớp cha. sử dụng từ khóa override. Không được phép sửa tên, thêm tham số truyền vào.
        public override void inRaManHinhCuaChaChoConSuDung()
        {
            //base.inRaManHinhCuaChaChoConSuDung();
            Console.WriteLine("Đây là text in ra inRaManHinhCuaChaChoConSuDung() nằm ở bên lớp Con");

            //Khi ghi đè phương thức của lớp cha bạn có toàn quyền code lại nội dung bên trong
        }
    }
}
