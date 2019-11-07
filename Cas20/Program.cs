using System;


namespace Cas20
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 32;
            //int c = 0, r1 = 2, r2 = 4;

            //CalculateValue(2, 4, ref c, out r1, out r2);
            //Console.WriteLine("CalculateValue(2, 4): c = {0}, r1 = {1}, r2 = {2}", c, r1, r2);

            //Console.WriteLine("Values before Swap(): {0}, {1}", a, b);
            //c = Swap(ref a, ref b);
            //Console.WriteLine("Values after Swap(): {0}, {1} / {2}", a, b, c);
            //Console.WriteLine("Factorial of 7 is {0}", Factorial(7));
            //Console.WriteLine("Factorial of 3 is {0}", Factorial(3));

            int num;
            num = Convert.ToInt32(Console.ReadLine());

            int r = SumaCifara(num);
            Console.WriteLine("Suma cifara broja {0} je {1}", num, r);

            Console.ReadKey();
        }

        static int SumaCifara(int num)
        {
            string n = Convert.ToString(num);
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += Convert.ToInt32(n.Substring(i, 1));
            }
            return sum;
        }


        static int Factorial(int num)
        {
            Console.WriteLine("Inside Factorial(): {0}", num);
            int result;
            if (num == 1)
            {
                return 1;
            } else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }

        static int Swap(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
            return num1 + num2;
        }

        static void CalculateValue(int a, int b, ref int c, out int r1, out int r2)
        {
            r1 = a + b;
            if (a > b)
            {
                r2 = b - a;
            } else
            {
                r2 = a - b;
            }
            c = a * b;
        }
    }
}
