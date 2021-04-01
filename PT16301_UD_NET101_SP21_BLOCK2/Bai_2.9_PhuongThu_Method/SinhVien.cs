using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_PhuongThu_Method
{
    class SinhVien
    {
        private string ten;
        private string msv;
        private int namSinh;
        private double diemCsharp;

        public SinhVien()
        {

        }

        public SinhVien(string ten1, string msv, int namSinh, double diemCsharp)
        {
            ten = ten1;
            this.msv = msv;
            this.namSinh = namSinh;
            this.diemCsharp = diemCsharp;
        }

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

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine("Tên:{0} Mã:{1} Năm Sinh:{2} Điểm C#1:{3}", ten, msv, namSinh, diemCsharp);
        }
    }
}
