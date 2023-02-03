using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            Console.WriteLine("***Implicit Conversion***");

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:"+d);

            long h = d;
            Console.WriteLine("h:"+h);

            float i = h;
            Console.WriteLine("i:"+h);

            string e = "Fatma Zehra";
            char f = 'r';

            object g = e + f + d;
            Console.WriteLine("g:"+g);

            // Explicit Conversion
            Console.WriteLine("***Explicit Conversion***");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);


            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:"+v);

            //  ToString 
            Console.WriteLine("*** ToString ***");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:"+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:"+zz);

            // System.Convert
            Console.WriteLine("*** System.Convert ***");

            string s1 = "10", s2 = "20";
            int num1, num2, sum;
            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);
            sum = num1 + num2;
            Console.WriteLine("sum:"+sum);

            // Parse
            Console.WriteLine("*** Parse Method ***");
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string page1 = "10";
            string page2 = "10.25";
            int number1;
            double double1;

            number1 = Int32.Parse(page1);
            double1 = Double.Parse(page2);

            Console.WriteLine("number1:"+number1);
            Console.WriteLine("double1:"+double1);
        }
    }
}
