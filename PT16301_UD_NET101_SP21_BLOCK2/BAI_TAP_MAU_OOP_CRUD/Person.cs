using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP_CRUD
{
    class Person //Lớp cha
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

        public virtual void inRaManHinh()
        {

        }
    }
}
