using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversationsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("implicit conversion");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "akbaba";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: " + g);

            Console.WriteLine("explicit conversion");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " + y);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            Console.WriteLine("toString method");
            int xx = 7;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " + zz);

            Console.WriteLine("System.Convert");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int sum;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            sum = sayi1 + sayi2;
            Console.WriteLine("sum: " + sum);

            Console.WriteLine("parse method");

            string text1 = "10";
            string text2 = "10.25";
            int number1;
            double number2;

            number1 = Int32.Parse(text1);
            number2 = Double.Parse(text2);

            Console.WriteLine("number1: " + number1);
            Console.WriteLine("number2: " + number2);

            Console.ReadLine();
        }
    }
}
