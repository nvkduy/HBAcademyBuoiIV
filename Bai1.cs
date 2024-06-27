using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAcademyBuoiIV
{
    internal class Bai1
    {
        public static void Y1()
        {
            Console.Write("Nhập a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tinh cong a+b= {a + b}");
            Console.WriteLine($"Tinh tru a-b= {a - b}");
            Console.WriteLine($"tinh nhan a*b={a * b}");
            Console.WriteLine($"Tinh chia a/b={a / b}");
            Console.WriteLine($"Tính chia lấy dư a%b={a % b}");
        }
        public static void Y2() 
        {
            while (true)
            {
                Console.Write("Toan:");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Ly:");
                float b = float.Parse(Console.ReadLine());
                Console.Write("Hoa:");
                float c = float.Parse(Console.ReadLine());

                if (a >= 9)
                {

                    Console.WriteLine($"Môn toán loại giỏi = {a}");
                }
                if ((a > 7) && (a <9))
                {

                    Console.WriteLine($"Môn toán loại Khá = {a}");
                }
                if ((a >= 5) && (a <= 7))
                {

                    Console.WriteLine($"Môn toán loại TB = {a}");
                }

                if (b >= 9)
                {

                    Console.WriteLine($"Môn Lý loại giỏi = {b}");
                }
                if ((b >7) && (b < 9))
                {

                    Console.WriteLine($"Môn Lý loại Khá = {b}");
                }
                if ((b >= 5) && (b <= 7))
                {

                    Console.WriteLine($"Môn Lý loại TB = {b}");
                }
                if (c >= 9)
                {

                    Console.WriteLine($"Môn toán loại giỏi = {c}");
                }
                if ((c > 7) && (c < 9))
                {

                    Console.WriteLine($"Môn toán loại Khá = {c}");
                }
                if ((c >= 5) && (c <= 7))
                {

                    Console.WriteLine($"Môn toán loại TB = {c}");
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập lại");
                }
            }




        }
        public static void Y3()
        {
            Console.Write("Nhập a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tinh cong a+=b= {a+=b}");
            Console.WriteLine($"Tinh tru a-=b= {a-=b}");
            Console.WriteLine($"tinh nhan a*=b= {a*=b}");
            Console.WriteLine($"Tinh chia a/=b= {a/=b}");
            Console.WriteLine($"Tính chia lấy dư a%=b {a%=b}");
        }
        public static void Y4()
        {
            Console.Write("Nhập a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b = int.Parse(Console.ReadLine());
            int c = (a > b) ? a : b;
            Console.WriteLine(c);
            object KetQua;
            KetQua = (a > b) ? "Max" : b;
            Console.WriteLine(KetQua);
            

        }
        public static void Y5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c:");
            int c = int.Parse(Console.ReadLine());
            if (a >= b && a >= c)
            {
                Console.WriteLine("Max là:" + a);
                if (b >= c)
                {
                    Console.WriteLine("Min là:"+c);
                }
                else if(c >= b)
                {
                    Console.WriteLine("Min là:"+b);
                }
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("Max là:" + b);
                if (a >= c)
                {
                    Console.WriteLine("Min là" + c);
                }
                else if (c >= a)
                {
                    Console.WriteLine("Min là"+a);
                }
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine("Max là:" + c);
                if (a >= b)
                {
                    Console.WriteLine ("Min là:"+b);
                }
                else if (b >= a)
                {
                    Console.WriteLine("Min là:" + a);
                }
                
            }

            

            


        }
    }
}
