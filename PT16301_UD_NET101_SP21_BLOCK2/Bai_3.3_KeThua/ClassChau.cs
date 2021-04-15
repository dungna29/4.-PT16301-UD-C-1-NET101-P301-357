using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_KeThua
{
    class ClassChau:ClassCon
    {
        private string thuocTinhChau1;

        public ClassChau()
        {
            
        }

        public ClassChau(string thuocTinhCha1, string thuocTinhCha2, string thuocTinhCha3, string thuocTinhCon1, string thuocTinhCon2, string thuocTinhChau1) : base(thuocTinhCha1, thuocTinhCha2, thuocTinhCha3, thuocTinhCon1, thuocTinhCon2)
        {
            this.thuocTinhChau1 = thuocTinhChau1;
        }

        public string ThuocTinhChau1
        {
            get => thuocTinhChau1;
            set => thuocTinhChau1 = value;
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
