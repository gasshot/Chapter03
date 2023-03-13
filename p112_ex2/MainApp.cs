using System;


namespace p112_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("현재년도를 입력하세요.");
            string age = Console.ReadLine();

            Console.WriteLine("출생년도를 입력하세요.");
            string birth = Console.ReadLine();

            int a = Convert.ToInt32(age);
            int b = Convert.ToInt32(birth);
            int c = (a - b) + 1;


            Console.WriteLine("저의 나이는 :   {0}세.",c);
            Console.WriteLine($"저의 나이는 : 만{int.Parse(age)-int.Parse(birth)}세.");
        }
    }
}
