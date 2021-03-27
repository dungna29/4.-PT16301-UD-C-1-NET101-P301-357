using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._6_OOP
{
    //class: Lớp
    class SinhVien//Tạo đối tượng SinhVien và phải viết hoa chữ cái đầu của từ bên trong đối tượng.
    {
        //Phần 1: Khai báo tất cả các thuộc tính (Thông tin) mà đối tượng phải có
        private string ten;
        private string msv;
        private string queQuan;
        private int tuoi;
        private string school = "FPOLY";

        //Phần 2: Contructor được gọi là hàm tạo phải giống với tên của class đối tượng. Được chạy đầu tiên khi đối tượng được khởi tạo.

        //Phần 2.1: Contructor không tham số = ctor + tab
        public SinhVien()
        {
            Console.WriteLine("Đây là text in ra từ COntructor không tham số");
        }

        //Phần 2.2 Contructor có tham số =
        public SinhVien(string ten, string msv, string queQuan, int tuoi)
        {
            this.ten = ten;
            this.msv = msv;
            this.queQuan = queQuan;
            this.tuoi = tuoi;
           
        }
        //Phần 3: Getter và Setter
        
        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public string QueQuan
        {
            get => queQuan;
            set => queQuan = value;
        }

        public int Tuoi
        {
            get => tuoi;
            set => tuoi = value;
        }

        public string School
        {
            get => school;
            set => school = "FPOLY";
        }

        //Phần 4: Các phương thức của đối tượng
        public void inThongTinSinhVien()
        {
            Console.WriteLine("Tên: {0} - Mã: {1} - Quê: {2} - Tuổi {3} - Trường: {4}",ten,msv,queQuan,tuoi,school);
        }
    }
}
