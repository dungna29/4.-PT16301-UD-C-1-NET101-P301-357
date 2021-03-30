using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP
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

        public SinhVien(string ten, string msv, int namSinh, double diemCsharp)
        {
            this.ten = ten;
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
            Console.WriteLine("Tên:{0} Mã:{1} Năm Sinh:{2} Điểm C#1:{3}",ten,msv,namSinh,diemCsharp);
        }
    }
}
