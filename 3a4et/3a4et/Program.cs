using System;
using System.Collections;

namespace _3a4et
{

    class Fors
    {
        static void for12()
        {
            float p = 1;
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N:");

            for (int i = 1; i <= N; i++)
            {
                p = p * (1 + 0.1 * i);
            }
            Console.WriteLine(p);
        }
        
        static void for20()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N:");
            float n1 = 1;
            float res = 0;
            

            for (int i = 1; i <= N; i++)
            {
                n1 *= (float)i;
                res += n1;
            }
            Console.WriteLine(res);
        }

        static void for34()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N:");
            double a1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            for (i = 3; i <= n; ++i)
            {
                double ak = (a1 + 2 * a2) / 3;
                a1 = a2;
                a2 = ak;
                Console.WriteLine(ak);
            }
            return;
        }
    }
    
    class Whiles
    {
        
        static void while4()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N:");
            while (N > 0)
            { 
                N /= 3;
            }
            
            if (N == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        
        static void while12()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N:");
            int k = 0, temp = 1;
            while (k <= N)
            {
                temp += k;
                k++;
            }
            return;
            Console.WriteLine();
        }
        
        static void while23() //я тут затупил
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while ((a != 0) & (b != 0))
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return;
            Console.WriteLine();
        }

    }
    
    class all_b
    {
        
        static void Series21()
        {
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            for (int i = 0; i < n; i++)
                array[i] = double.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                if (array[i] < array[i - 1])
                {
                    Console.WriteLine("False");
                    return;
                }
            }

            Console.WriteLine("True");
        }
        
        static void proc52(int year)
        {
            if (year % 4 != 0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            return;
        }
        
        static void minmax12()
        {
            int n = int.Parse(Console.ReadLine());
            int[] N = new int[n];
            for (int i = 0; i < n; i++)
            {
                N[i] = int.Parse(Console.ReadLine());
            }      
        Console.WriteLine(CalculateMinInt(N));
        }
        static int CalculateMinInt(int[] nums)
        {
            int min;
            min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            if (min < 0)
                return 0;
            else
                return min;
            return 0;
        }
        
        static void array16()
        {

        }
        public void array47()
        {

        }
        public void array68()
        {

        }

    }
}

