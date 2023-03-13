using System;

namespace IntergralTypes
{
    class MainApp
    {
        static void Main(string[] args) //메서드
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");      // 문자열 보관법
            Console.WriteLine("a={0}, b={1}", a, b); // 오리지널 방식

            short c = -30000; // 컴파일러에게 알려주는 데이터의 타입(short) / 변수명 식별자(c)
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000;
            uint f = 3_0000_0000;

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000;

            Console.WriteLine($"g={g}, h={h}");

        }
    }
}