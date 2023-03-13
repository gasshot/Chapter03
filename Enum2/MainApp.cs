using System;

namespace Enum2
{
    class MainApp
    {
        int a; // 전역변수
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
        static void Main(string[] args)
        {
            int b = 50;

            DialogResult result = DialogResult.YES; // "=" 대입연산자

            Console.WriteLine(result == DialogResult.YES);  // "==" 비교연산자
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }

        static void A()
        {
            int b = 100;

            //MainApp mainapp = 


        }

    }
}