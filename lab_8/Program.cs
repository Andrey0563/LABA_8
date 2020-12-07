using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class MyComplex
    {
        private double re;
        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        private double im;
        public double Im
        {
            get { return im; }
            set { im = value; }
        }
        public MyComplex(string n = "", double a = 0, double b = 0)
        {
            re = a; im = b;
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex { re = a.re - b.re, im = a.im - b.im };

        }
        public static MyComplex operator *(MyComplex a, double b)
        {
            return new MyComplex { re = a.re - b, im = a.im - b };
        }
        public static MyComplex operator *(double b, MyComplex a)
        {
            return new MyComplex { re = a.re - b, im = a.im - b };
        }
        public static MyComplex operator -(MyComplex a)//конвертация
        {
            return new MyComplex { Re = -1 * a.Re, Im = -1 * a.Im };
        }



        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex { re = a.re + b.re, im = a.im + b.im };

        }
        public static MyComplex operator +(MyComplex a, double b)
        {
            return new MyComplex { re = a.re + b, im = a.im + b };
        }
        public static MyComplex operator +(double b, MyComplex a)
        {
            return new MyComplex { re = a.re + b, im = a.im + b };
        }
        public override string ToString()//пере
        {
            if (Im < 0)
                return +Re + Im + "*i";
            else
                return +Re + "+" + Im + "*i";
        }
    }


    class InputFromTerminal//вводим даные с терминалу
    {
        private double re, a, b;
        public double Ret
        {
            get { return re; }
            set { re = value; }
        }

        private double im;
        public double Imt
        {
            get { return im; }
            set { im = value; }
        }


        public void InpUTTerminal()

        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введіть дійсну частину числа:");
                    a = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("помилка");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введіть уявну частину числа:");
                    b = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("помилка");
                }
            }

            Dictionary<string, double> c = new Dictionary<string, double>(2);//создадим словарь , запишем даные и выведим
            re = a; im = b;
            c.Add("realValue", re);
            c.Add("imageValue", im);
            Console.WriteLine($"Re()={ c["realValue"]}, Im() = {c["imageValue"]}");
        }

        public static InputFromTerminal operator *(InputFromTerminal a, InputFromTerminal b)
        {
            return new InputFromTerminal { re = a.re - b.re, im = a.im - b.im };

        }
        public static InputFromTerminal operator *(InputFromTerminal a, double b)
        {
            return new InputFromTerminal { re = a.re - b, im = a.im - b };
        }
        public static InputFromTerminal operator *(double b, InputFromTerminal a)
        {
            return new InputFromTerminal { re = a.re - b, im = a.im - b };
        }
        public static InputFromTerminal operator -(InputFromTerminal a)//конвертация
        {
            return new InputFromTerminal { Ret = -1 * a.Ret, Imt = -1 * a.Imt };
        }

        public static InputFromTerminal operator +(InputFromTerminal a, InputFromTerminal b)
        {
            return new InputFromTerminal { re = a.re + b.re, im = a.im + b.im };


        }
        public static InputFromTerminal operator +(InputFromTerminal a, double b)
        {
            return new InputFromTerminal { re = a.re + b, im = a.im + b };
        }
        public static InputFromTerminal operator +(double b, InputFromTerminal a)
        {
            return new InputFromTerminal { re = a.re + b, im = a.im + b };
        }
        public override string ToString()
        {
            if (Imt < 0)
                return +Ret + Imt + "*i";
            else
                return +Ret + "+" + Imt + "*i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            MyComplex A = new MyComplex("A", 10, 10);//визов першого класу і надання йому значень

            Dictionary<string, double> i = new Dictionary<string, double>(2);
            i.Add("realValue", A.Re);
            i.Add("imageValue", A.Im);



            MyComplex B = new MyComplex("B", 1, 3);
            Dictionary<string, double> g = new Dictionary<string, double>(2);
            g.Add("realValue", B.Re);
            g.Add("imageValue", B.Im);



            MyComplex c;
            c = A * B;
            Console.WriteLine($"c={c}");
            c = A * 5.5;
            Console.WriteLine($"c={c}");
            c = 5.5 * A;
            Console.WriteLine($"c={c}");
            c = -B;

            Console.WriteLine($"A = {A}, B = {B},C={c}");
            Console.WriteLine($"Re(A)={ i["realValue"]}, Im(A) = {i["imageValue"]}");
            Console.WriteLine($"Re(B)={ g["realValue"]}, Im(C) = {g["imageValue"]}");


            InputFromTerminal D = new InputFromTerminal();
            D.InpUTTerminal();
            InputFromTerminal K = new InputFromTerminal();
            K.InpUTTerminal();
            InputFromTerminal C;
            C = D * K;//перевіряю чи працює мій перегружений оператор

            Console.WriteLine(C);
            Console.ReadLine();
        }
    }
}