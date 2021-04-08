using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP_CRUD
{
    class Student:Person//Lớp Sinh Viên kế thừa lớp Person
    {
        private string msv;
        private double diemCharp;

        public Student()
        {
            
        }

        public Student(string ho, string tenDem, string ten, string sdt, string email, string msv, double diemCharp) : base(ho, tenDem, ten, sdt, email)
        {
            this.msv = msv;
            this.diemCharp = diemCharp;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public double DiemCharp
        {
            get => diemCharp;
            set => diemCharp = value;
        }

        public override void inRaManHinh()
        {
            Console.WriteLine("Tên: {0} - Sdt: {1} - Email: {2} - Msv: {3} - Điểm C#1: {4}", (Ho + TenDem + Ten),Sdt,Email,msv,diemCharp);
        }
    }
}
