using System;
using System.Text;

namespace NumericArrays_04_Honcharuk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //Array1();
            Array2();
            Console.ReadKey(true);
        }


        static void Array1()
           
        {
            int[] myArray1 = { -12, 23, -44, 56, -9, 45, 77, 88, -3, 5 };
            int[] myArray2 =  new int[myArray1.Length];
            
            for (int i = myArray1.Length -1, j = myArray2.Length -1 ; i > 0  ; i--)
            {
                
                if ( (myArray1[i] > 0))
                {
                    myArray2[j] = myArray1[i];
                    j--;
                }
            }
            var str = string.Join(", ", myArray2);
            Console.WriteLine(str);


        }

        private static void Array2()
        {
            int m, n;
            
            Console.Write("N= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("M= ");
            m = int.Parse(Console.ReadLine());
            

            int[,] arr = new int[m, n];
            #region random
            Random random = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(9999);
                }
            }
            #endregion

            #region вивод
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+"\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            #endregion

            int[,] b = Transport(arr);
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        public static int[,] Transport(int[,] arr)
        {
            int a;
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);


            for (int i = 0; i < m / 2; i++)
            
                for (int j = 0; j < n ; j++)
                {
                    a = arr[i, j];
                    arr[i, j] = arr[m / 2 +i, j];
                    arr[m / 2 + i, j] = a;
                }
            
            return arr;
        }
       

    }
}
