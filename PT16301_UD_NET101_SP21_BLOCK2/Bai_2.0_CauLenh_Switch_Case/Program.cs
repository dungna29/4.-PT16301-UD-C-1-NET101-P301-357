using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bai_2._0_CauLenh_Switch_Case
{
    class Program
    {
        /*
         * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
         *
         * Công thức: sw + tab
         *
         *  switch (<Biểu thức>)
            {
                case <giá trị 1>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break; 
                case <giá trị 2>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                .......
                case <giá trị n>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                default:
                    Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                    break;
            }
         */
        static void Main(string[] args)
        {
            switch (1)//Sử dụng kiểu số nguyên
            {
                case 1:
                    //Thực hiện 1 hành động nào đó
                    break;  
                case 2:
                    break; 
                case 3:
                    break; 
                case 4:
                    break;
                default:
                    break;
            }

            switch ("1")//Sử dụng chuỗi
            {
                case "1":
                   //Code chức năng
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;
            }

            switch ('a')//Kiểu char
            {
                case 'a':
                    break;
                case 'b':
                    break;
                case 'c':
                    break;
                case 'd':
                    break;
                default:
                    break;
            }
        }
    }
}
