using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HBAcademyBuoiIV
{
    internal class BTVNB4Record
    {
        public static void Y1()
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
            float sum = a+b+c+d;
            Console.WriteLine("Tổng 4 số:" + sum);
            float product = a * b * c * d;
            Console.WriteLine("Tích 4 số:"+product);
            float AVG = (a + b + c + d) / 4;      
            Console.WriteLine("Gia trị trung bình của 4 số là:" +AVG );
            float max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            if (d > max)
                max = d;
            Console.WriteLine("Giá trị lớn nhất là:"+max);
            float min = a;
            if(a < min)
                min = a;
            if (b < min)
                min = b;
            if (c < min)
                min = c;
            if (d < min)
                min = d;
            Console.WriteLine("Giá trị nhỏ nhất là:"+min);
        }
        public static void Y2()
        {
            string fatherName, motherName, sisterName, myName;
            int fatheAge, motherAge, myAge,sisterAge;
            Console.WriteLine("*** Thông tin Gia Đình ***");
            Console.Write("Họ Tên bố:");
            fatherName = NormalizeFullName(Console.ReadLine());
            Console.Write("Họ tên Mẹ:");
            motherName = NormalizeFullName(Console.ReadLine());
            Console.Write("Họ tên chị gái:");
            sisterName = NormalizeFullName(Console.ReadLine());
            Console.Write("Tên của tôi:");
            myName = NormalizeFullName(Console.ReadLine());
            Console.Write("Tuổi của tôi:");
            while (!int.TryParse(Console.ReadLine(), out myAge))
            {
                Console.WriteLine("Tuổi phải là số nguyên");
                Console.Write("Tuổi của tôi:");
            }
            Console.Write("Tuổi của chị:");
            while (!int.TryParse(Console.ReadLine(), out sisterAge) || sisterAge <= myAge)
            {
                Console.WriteLine("Tuổi của chị phải lớn hơn hoặc bằng tuổi em và là số nguyên");
                Console.Write("Tuổi của chị:");
            }
            Console.Write("Tuổi của bố");
            while (!int.TryParse(Console.ReadLine(),out fatheAge) || fatheAge <= sisterAge || fatheAge <= myAge)
            {
                Console.WriteLine("Tuổi của bố phải lớn hơn tuổi con và là số nguyên");
                Console.Write("Tuổi của bố");
            }
            Console.Write("Tuổi của mẹ:");
            while (!int.TryParse(Console.ReadLine(), out motherAge) || motherAge <= myAge || motherAge <= sisterAge)
            {
                Console.WriteLine("Tuổi của mẹ phải lớn hơn tuổi con và là số nguyên");
                Console.Write("Tuổi của mẹ:");
            }
            // In thông tin đã nhập
            Console.WriteLine("\n*** Thông tin đã nhập ***");
            Console.WriteLine("Họ Tên bố: " + fatherName);
            Console.WriteLine("Tuổi của bố: " + fatheAge);
            Console.WriteLine("Họ tên Mẹ: " + motherName);
            Console.WriteLine("Tuổi của mẹ: " + motherAge);
            Console.WriteLine("Họ tên chị gái: " + sisterName);
            Console.WriteLine("Tuổi của chị: " + sisterAge);
            Console.WriteLine("Tên của tôi: " + myName);
            Console.WriteLine("Tuổi của tôi: " + myAge);
            // Hàm chuẩn hóa Họ Tên
             static string NormalizeFullName(string input)
            {
                if (string.IsNullOrEmpty(input))
                    return input;

                // Chuẩn hóa chuỗi: loại bỏ dấu cách ở hai đầu, viết hoa chữ cái đầu mỗi từ, giữ một khoảng trắng giữa các từ
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string[] words = input.Trim().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = textInfo.ToTitleCase(words[i]);
                }
                return string.Join(" ", words);
            }






        }

    }
}
