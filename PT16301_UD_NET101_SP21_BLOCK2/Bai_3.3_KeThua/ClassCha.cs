using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_KeThua
{
    class ClassCha
    {
        private string thuocTinhCha1;
        private string thuocTinhCha2;
        private string thuocTinhCha3;

        public ClassCha()
        {
            
        }

        public ClassCha(string thuocTinhCha1, string thuocTinhCha2, string thuocTinhCha3)
        {
            this.thuocTinhCha1 = thuocTinhCha1;
            this.thuocTinhCha2 = thuocTinhCha2;
            this.thuocTinhCha3 = thuocTinhCha3;
        }

        public string ThuocTinhCha1
        {
            get => thuocTinhCha1;
            set => thuocTinhCha1 = value;
        }

        public string ThuocTinhCha2
        {
            get => thuocTinhCha2;
            set => thuocTinhCha2 = value;
        }

        public string ThuocTinhCha3
        {
            get => thuocTinhCha3;
            set => thuocTinhCha3 = value;
        }

        public virtual void methodCha1()
        {

        } 
        public virtual void methodCha2()
        {

        }
    }
}
