using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Task 1

                //int cavab = number(10, 3);
                //Console.WriteLine(cavab);

                // TAsk 2

                //string cavab = Repeat("abc", 5);
                //Console.WriteLine(cavab);

                // Task 3

                //int Sum = Cem(5, 8, 7, 6);
                //Console.WriteLine(Sum);

                // Task 4(1- Cevrenin sahesi)\

                //int cavab = Sahe(3);
                //Console.WriteLine(cavab);

                //Task 4(Düzbucaqlının sahəsi - S = a*b)

                //int cavab = Sahe(5, 6);
                //Console.WriteLine(cavab);

                int cavab = Sahe(5, 7, 8, 6);
                Console.WriteLine(cavab);




            }
            #region Methosd
            // Task 1
            static int number(int num_1, int num_2)
            {
                return num_1 / num_2;
            }



            //Task 2
            static string Repeat(string A, int n)
            {
                var netice = A;

                for (var i = 0; i < n - 1; i++)
                {
                    netice += A;
                }
                return netice;
            }
            //Task 3
            static int Cem(params int[] arr)
            {
                int sum = 0;

                for (var i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }

            // Task 4(1-Çevrənin sahəsi - S = p*r² (p=3))

            static int Sahe(int a)
            {
                int p = 3;
                return p * (a * a);
            }

            // Task 4(2-Düzbucaqlının sahəsi - S = a*b)

            static int Sahe(int a, int b)
            {
                return a * b;
            }

            //Task 4(3 - Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S = p * r; p = (a + b + c) / 2)
           
            static int Sahe(int a, int b, int c, int r)
            {
                
                int  p = (a + b + c) / 2;

                return p * (r * r);
            }
            #endregion



        }
    }
}
