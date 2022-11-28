using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la 1 la 21 pentru selectarea unei probleme!");
            switch (Console.ReadLine())
            {
                case "1":
                    P1();
                    break;
                case "2":
                    P2();
                    break;
                case "3":
                    P3();
                    break;
                case "4":
                    P4();
                    break;
                case "5":
                    P5();
                    break;
                case "6":
                    P6();
                    break;
                case "7":
                    P7();
                    break;
                case "8":
                    P8();
                    break;
                case "9":
                    P9();
                    break;
                case "10":
                    P10();
                    break;
                case "11":
                    P11();
                    break;
                case "12":
                    P12();
                    break;
                case "13":
                    P13();
                    break;
                case "14":
                    P14();
                    break;
                case "15":
                    P15();
                    break;
                case "16":
                    P16();
                    break;
                case "17":
                    P17();
                    break;
                case "18":
                    P18();
                    break;
                case "19":
                    P19();
                    break;
                case "20":
                    P20();
                    break;
                case "21":
                    P21();
                    break;

            }
        }

        private static void P1()
        {
            double a, b;
            Console.Write("Introduceti numarul a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduceti numarul b: ");
            b = Convert.ToDouble(Console.ReadLine());

            //ax + b = 0

            double x = -b / a;

            Console.WriteLine("x = " + x);
            Console.ReadLine();
        }
        private static void P2()
        {
            int a, b, c;

            //ax^2 + bx + c = 0
            Console.Write("Introduceti numarul a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti numarul b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti numarul c: ");
            c = Convert.ToInt32(Console.ReadLine());

            double delta = (b * b - 4 * a * c);
            double solutie1;
            double solutie2;

            if (delta > 0)
            {
                solutie1 = ((-b + Math.Sqrt(delta)) / 2 * a);
                solutie2 = ((-b - Math.Sqrt(delta)) / 2 * a);
                Console.Write("Solutiile sunt: \n x1 = " + solutie1 + " x2 = " + solutie2);
            }
            else if (delta == 0)
            {
                solutie1 = (-b / 2 * a);
                solutie2 = (-b / 2 * a);
                Console.Write("Solutiile sunt: \n x1 = " + solutie1 + " x2 = " + solutie2);
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii reale!");
            }

            Console.ReadKey();
        }
        private static void P3()
        {
            float n = float.Parse(Console.ReadLine());
            float k = float.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("{0} se  divide cu {1}", n, k);
            }
            else
            {
                Console.WriteLine("{0} nu se divide cu {1}", n, k);
            }
            Console.ReadKey();
        }
        private static void P4()
        {
            Console.WriteLine("Introduceti un an");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 0))
            {
                Console.WriteLine(y + " este an bisect");
            }
            else { Console.WriteLine(y + " nu este an bisect"); }
            Console.ReadKey();
        }
        private static void P5()
        {
            Console.Write("Introduceti un numar: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n >= 10)
            {
                n /= 10;
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
        private static void P6()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c && a + c > b && c + b > a)
            {
                Console.WriteLine("{0}, {1} si {2} pot fi laturile unui triungi", a, b, c);
            }
            else
            {
                Console.WriteLine("{0}, {1} si {2} nu pot fi laturile unui triunghi", a, b, c);
            }
            Console.ReadKey();
        }
        private static void P7()
        {
            int a, b, c;
            Console.Write("Introduceti un numar: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un alt numar: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.ReadKey();
        }
        private static void P8()
        {
            int a, b;
            Console.Write("Introduceti un numar: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un alt numar: ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.ReadKey();
        }
        private static void P9()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    i = i - 1;
                }
            }
            Console.ReadKey();
        }
        private static void P10()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = 0;
            for (int i = a; i > 0; i--)
            {
                if (a % i == 0)
                {
                    b++;
                    i = i - 1;
                }
            }
            if (b == 2)
            {
                Console.WriteLine("Este prim");
            }
            else
            {
                Console.WriteLine("Nu este prim");
            }
            Console.ReadKey();
        }
        private static void P11()
        {
            int a;
            int r, s = 0;
            Console.Write("Introduceti un numar: ");
            a = Convert.ToInt32(Console.ReadLine());

            while (a > 0)
            {
                r = a % 10;
                a = a / 10;
                s = (s * 10) + r;
            }
            Console.Write(s);
            Console.ReadKey();
        }
        private static void P12()
        {
            Console.Write("Introduceti intervalul [a,b]: ");
            int counter = 0;
            int a, b;
            string[] line = Console.ReadLine().Split(' ', ';', '.');


            a = int.Parse(line[0]);
            b = int.Parse(line[1]);

            Console.Write("Introduceti un numar: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    counter++;
            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
        private static void P13()
        {
            int an1, an2;
            Console.Write("Introduceti primul an: ");
            an1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti al doilea an: ");
            an2 = Convert.ToInt32(Console.ReadLine());

            int aniBis = (an2 / 4 - an2 / 100 + an2 / 400) - (an1 / 4 - an1 / 100 + an1 / 400);
            Console.WriteLine($"{aniBis} ani bisecti sunt intre {an1} si {an2}");
            Console.ReadKey();
        }
        private static void P14()
        {
            int num, temp, revnum = 0, rem;
            Console.WriteLine("Inserati un numar: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;
                revnum = revnum * 10 + rem;
                num = num / 10;
            }
            if (revnum == temp)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
            Console.ReadLine();
        }
        private static void P15()
        {
            int a, b, c;

            string[] tokens = Console.ReadLine().Split(' ', ';', ':');

            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);


            int aux;
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }

            Console.WriteLine($"{a} {b} {c}");
            Console.ReadKey();
        }
        public static void swap(ref int num1, ref int num2)
        {
            int aux;

            aux = num1;
            num1 = num2;
            num2 = aux;
        }
        private static void P16()
        {
            int a, b, c, d, e;

            Console.Write("Introduceti un numar a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un numar b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un numar c = ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un numar d = ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduceti un numar e = ");
            e = Convert.ToInt32(Console.ReadLine());

            if (a > b) { swap(ref a, ref b); }
            if (a > c) { swap(ref a, ref c); }
            if (a > d) { swap(ref a, ref d); }
            if (a > e) { swap(ref a, ref e); }
            if (b > c) { swap(ref b, ref c); }
            if (b > d) { swap(ref b, ref d); }
            if (b > e) { swap(ref b, ref e); }
            if (c > d) { swap(ref c, ref d); }
            if (c > e) { swap(ref c, ref e); }
            if (d > e) { swap(ref d, ref e); }



            Console.WriteLine($"{a} {b} {c} {d} {e} ");
            Console.ReadKey();
        }
        private static void P17()
        {
            int a, b, n, m;
            Console.Write("Introduceti dou numere a si b: ");
            string[] tokens = Console.ReadLine().Split(' ');

            a = Convert.ToInt32(tokens[0]);
            b = Convert.ToInt32(tokens[1]);
            n = a;
            m = b;
            while (m != n)
            {
                if (n < m)
                {
                    n = n + a;
                }
                if (n > m)
                {
                    m = m + b;
                }
            }
            while (m != n)
            {
                if (n < m)
                {
                    n = n - a;
                }
                if (n > m)
                {
                    m = m - b;
                }
            }


            int cmmmc = m + n;
            int cmmdc = m - n;
            Console.WriteLine($"Cel mai mic multiplu comun al lui {a} si {b} este " + cmmmc + $"\n iar cel mai mare divizor comun al lui {a} si {b} este: " + cmmdc);

            Console.ReadKey();
        }
        private static void P18()
        {
            Console.Write("Introduceti un numar n: ");
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p;
            while (n > 1)
            {

                p = 0;
                while (n % d == 0)
                {
                    ++p;
                    n /= d;
                }
                if (p != 0)
                    Console.Write($"{d}^{p} x ");
                ++d;
                if (n > 1 && d * d > n)
                {
                    d = n;
                }
                Console.ReadKey();
            }
        }
        private static void P19()
        {

        }
        private static void P20()
        {

        }
        private static void P21()
        {
            int x, nr;

            Random rnd = new Random();
            x = rnd.Next(1, 1024);

            do
            {
                Console.Write("Introduceti un numar intre 1 si 1024: ");
                nr = Convert.ToInt32(Console.ReadLine());
                if (nr > x)
                {
                    Console.WriteLine("Numarul introdus este prea mare!");
                }
                if (nr < x)
                {
                    Console.WriteLine("Numarul introdus este prea mic!");
                }
                if (nr == x)
                {
                    Console.WriteLine("Felicitari ati ghicit numarul!");
                    Console.ReadLine();
                }
            }
            while (nr != x);
            Console.WriteLine("Numarul selectat de calculator este: {0}", x);
        }
    }

}