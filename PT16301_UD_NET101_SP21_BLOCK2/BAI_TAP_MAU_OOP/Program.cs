using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_TAP_MAU_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ServiceSinhVien servicesv = new ServiceSinhVien();
            // servicesv.bai1TaoDoiTuongSuDungContructor();
            servicesv.bai3TaoNhieuDoiTuongArray();
        }
    }
}
