using System;

namespace Char
{
    class MainApp
    {
        static void Main(string[] args)
        {
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);
            Console.WriteLine();

            Console.WriteLine($"{a}{b}{c}{d}{e}!");
            Console.WriteLine("{0},{1},{2},{3},{4} !", a, b, c, d, e);
            Console.WriteLine(a + b + c + d + e);
        }
    }
}