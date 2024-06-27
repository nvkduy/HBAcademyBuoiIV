using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAcademyBuoiIV
{
    internal class BTVN
    {
        public static void Y1()
        {
            Console.Write("Nhập:");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Tổng 2 số a+b là :"+(a+b));
            Console.WriteLine("Phần nguyên a/b là:{0}\n Phần Dư a%b là:{1}",(a/b),a%b);
            Console.WriteLine($"Phép cộng a + b = {a+b}\nPhép trừ a - b = {a-b}\nPhép nhân a * b = {a*b}\nPhép chia a / b = {a/b}");
        }
        public static void Y2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Trước khi trao tráo đổi:\n a = {0}\n b = {1}",a,b);
            int temp = a;
            a=b;
            b=temp;
            Console.WriteLine("Sau khi tráo đổi:\n a = {0}\n b = {1}",a,b);
        }
        public static void Y3()
        {
            int a;
            int temp;
            Console.Write("Nhập số:");
            a = int.Parse(Console.ReadLine());
            for (temp = 0; temp <= 10;temp++)
            {
                Console.WriteLine($"a * {temp} = {a*temp}");
               
            }       
        }
        public static void Y4()
        {
            float a,b,c,d;
            Console.Write("Nhập số thứ nhất:");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ hai:");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ ba:");
            c = float.Parse(Console.ReadLine());
            Console.Write("Nhập số thứ tư:");
            d = float.Parse(Console.ReadLine());
            float AVG = (a + b + c + d) / 4;
            Console.Write("Gia trị trung bình của 4 số là:" +AVG );
        }
        public static void Y5()
        {
            float a;
            Console.Write("Nhập số độ C cần chuyển:");
            a = float.Parse(Console.ReadLine());
            float ToF = (9f/5f) * a + 32;
            float ToK= a+273.15f;
            Console.WriteLine("Chuyển đổi {0} độ C sang độ F = {1}",a,ToF);
            Console.WriteLine("Chuyển đổi độ {0} độ C sang độ K = {1}",a,ToK);


        }
    }   
}
