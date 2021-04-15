using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_KeThua
{
    class ClassCon:ClassCha
    {
        private string thuocTinhCon1;
        private string thuocTinhCon2;

        public ClassCon()
        {
            
        }

        public ClassCon(string thuocTinhCha1, string thuocTinhCha2, string thuocTinhCha3, string thuocTinhCon1, string thuocTinhCon2) : base(thuocTinhCha1, thuocTinhCha2, thuocTinhCha3)
        {
            this.thuocTinhCon1 = thuocTinhCon1;
            this.thuocTinhCon2 = thuocTinhCon2;
        }

        public string ThuocTinhCon1
        {
            get => thuocTinhCon1;
            set => thuocTinhCon1 = value;
        }

        public string ThuocTinhCon2
        {
            get => thuocTinhCon2;
            set => thuocTinhCon2 = value;
        }

        public override void methodCha1()
        {
            base.methodCha1();
        }

        public override void methodCha2()
        {
            base.methodCha2();
        }
    }
}
