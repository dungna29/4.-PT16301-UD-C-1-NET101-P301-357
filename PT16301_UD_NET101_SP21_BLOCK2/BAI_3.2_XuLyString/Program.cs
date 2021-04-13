using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._2_XuLyString
{
    class Program
    {
        /*
         * Xử lý chuỗi
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string[] arrNames =
            {
                "Nguyễn Văn A", "Nguyễn Văn B", "Nguyễn Văn C", "Lê Văn A", "Lê Văn B", "Trần Văn A", "Trần Văn B",
                "Trần Văn C", "Lý Công A"
            };
            //Tìm kiếm gần đúng dùng startwith(Chuỗi)
            // foreach (var x in arrNames.Where(c=>c.StartsWith("L")))
            // {
            //     Console.WriteLine(x);
            // }

            foreach (var x in arrNames)
            {
                if (x.StartsWith("L"))
                {
                    Console.WriteLine(x);
                }
            }

            method1();

        }

        static void method1()
        {   //Anh Chị Em
            //Chị. Loan - Giới Tính Nữ
            string name = "Long";
            string gt = "Nữ"; //Do người dùng nhập vào
            int ns = 19; //Do người dùng nhập vào
            int nsBanThan = 18;//Fix cứng tuổi mình

            string anh = (gt == "Nam") && (ns > nsBanThan) ? "Anh" : null;
            string chi = (gt == "Nữ") && (ns > nsBanThan) ? "Chị" : null;
            Console.WriteLine("Chào {0} {1}", (anh == null && chi == null) ? "Em" : anh != null ? "Anh" : "Chị", name);


        }
    }
}
