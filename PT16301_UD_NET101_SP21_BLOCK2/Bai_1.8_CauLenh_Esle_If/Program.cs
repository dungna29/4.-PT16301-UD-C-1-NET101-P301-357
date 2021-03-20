using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._8_CauLenh_Esle_If
{
    class Program
    {
        /*
       * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện khác nhau và thực hành động tương ứng với từng điều kiện. Else If phải luôn True thì mới thực hiện hành động bên trong nó.
       *
       * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong điều kiện đó mà thôi.
       *
       * Công thức:
       *   if (true)
          {
              //Thực hiện 1 hành động nếu If đúng
          }else if (<Điều kiện 1>)
          {
              //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
          }else if (<Điều kiện 2>)
          {
              //Tương tự
          }else
          {
              //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
          }
       */
        static void Main(string[] args)
        {
            /*
                 Tạo 1 menu gồm 3 chức năng:
                 1. Phép cộng
                 2. Phép trừ
                 3. Phép nhân
            Thông báo chức năng không tồn tại
            *
            */
            //resharper + đăng ký tài khoản mail fpt.edu.vn
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            string input;
            Console.WriteLine(" Menu ");
            Console.WriteLine(" 1. Phép cộng ");
            Console.WriteLine(" 2. Phép trừ ");
            Console.WriteLine(" 3. Phép nhân ");
            Console.WriteLine("Mời bạn chọn chức năng: ");
            input = Console.ReadLine();
            if (input == "1")
            {
                Console.WriteLine("Phép cộng");
            }else if (input == "2")
            {
                Console.WriteLine("Phép trừ");
            }
            else if (input == "3")
            {
                Console.WriteLine("Phép nhân");
            }
            else
            {
                Console.WriteLine("Chức năng bạn chọn không tồn tại");
            }
        }
    }
}
