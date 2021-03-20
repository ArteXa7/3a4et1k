using System;
using System.Collections;

namespace _3a4et
{

    class Fors
    {
        public void for12()
        {
            double p = 1;
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                p = p * (1 + 0.1 * i);
            }
        }
        
        public void for20()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            float n1 = 1;
            float rez = 0;
            

            for (int i = 1; i <= N; i++)
            {
                n1 *= (float)i;
                rez += n1;
            }
        }

        public void for34()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            float a1 = 1, a2 = 2;

            int i;
            float ak;
            for (i = 3; i <= n; ++i)
            {
                ak = (a1 + 2 * a2) / 3;
                a1 = a2;
                a2 = ak;
            }
            return;
        }
    }
    class Whiles
    {
        public void while4()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            while (a > 0) a -= 3;
            if (a == 0)
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
        public void while12()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0, temp = 0;
            while (!(temp + k + 1 > n))
            {
                ++k;
                temp += k;
            }
            return;
        }
        public void while23()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while ((a != 0) & (b != 0))
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return;
        }

    }
    class all_b
    {
        public void series21()
        {
            int n, d = 0, k = 0, b = -1;
            float a = float.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (a > d && d != 0) k++;
                d = a;
                b++;
            }
            if (k == b)
            {
                Console.WriteLine("Y");
            }
            else
            {
                Console.WriteLine("N");
            }
            return;
        }
        public void proc52()
        {
            int year;
            if (year % 4 != 0 && year % 100 != 0 || year % 400 == 0)
            {
                return;
            }
            return;
        }
        
        public void minmax12()
        {

        }
    
        public void array16()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int arr = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                arr = 1 % 90 + 10;
            }
            for (int i = 0; i < n / 2; ++i)
            {
                int ar1 = n - 1 - i;

            }
            if (n % 2 != 0)
            {
                int ar2 = (n / 2);
            }
            return;
        }
        public void array47()
        {

        }
        public void array68()
        {

        }

    }
}

