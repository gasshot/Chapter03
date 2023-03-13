using System;


namespace FloatToLintergral
{
    class MainApp
    {
        static void Main(string[] args) // 키보드 데이터는 문자열
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);
        }
    }
}
