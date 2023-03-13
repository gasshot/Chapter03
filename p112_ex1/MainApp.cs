using System;

namespace p112_ex1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();
            

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();


            //int a = int.Parse(width);
            int a = Convert.ToInt32(width);
            //int b = int.Parse(height);
            int b = Convert.ToInt32(height);
            int c = a * b;


            Console.WriteLine("사각형의 넓이는 : {0}",c);
            //Console.WriteLine($"사각형의 넓이는 :  {int.Parse(width)*int.Parse(height)}");
        }
    }
}
