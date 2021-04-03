using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_OOP_TinhKeThua
{
    /*
     * Lớp Person là lớp cha sẽ chưa các thuộc tính chung của lớp con. Trong OOP người ta sẽ đưa các thuộc tính chung lên lớp cha và có thể cả phương thức.
     */
    class Person
    {
        private string ho;
        private string tenDem;
        private string ten;
        private string sdt;
        private string email;

        public Person()
        {
            
        }

        public Person(string ho, string tenDem, string ten, string sdt, string email)
        {
            this.ho = ho;
            this.tenDem = tenDem;
            this.ten = ten;
            this.sdt = sdt;
            this.email = email;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public string TenDem
        {
            get => tenDem;
            set => tenDem = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public void inRaManHinhCuaCha()
        {
            Console.WriteLine("Đây là text in ra từ inRaManHinhCuaCha()");
        }
        private void inRaManHinhCuaChaPrivate()
        {
            Console.WriteLine("Đây là text in ra từ inRaManHinhCuaCha()");
        }

        //Khi sử dụng từ khóa virtual trên phương thức của lớp cha thì lớp con có thể ghi đè lại phương thức này đây gọi là overiding trong tính đa hình của OOP
        public virtual void inRaManHinhCuaChaChoConSuDung()
        {
            Console.WriteLine("Đây là text in ra từ inRaManHinhCuaChaChoConSuDung()");
        }
    }
}
