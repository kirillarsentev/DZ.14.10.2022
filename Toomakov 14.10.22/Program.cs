using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toomakov_14._10._22
{
    internal class Program
    {

        static string  Сounter(char[] arr)
        {
            char[] glas = "aeiouy".ToCharArray();
            char[] soglas = "bcdfghjklmnpqrstvwxyz".ToCharArray();
            int countglas = 0;
            int countsoglas = 0;

            foreach (char ch in arr)
            {
                foreach (char g in glas)
                {

                    if (ch == g)
                    {
                        countglas++;
                    }
                }
            }
            foreach (char ch in arr)
            {
                foreach (char g in soglas)
                {

                    if (ch == g)
                    {
                        countsoglas++;
                    }
                }
            }
        return "Количество гласных: " + Convert.ToString(countglas) + '\n' + "Количество согласных : " +  Convert.ToString(countsoglas);
            

        }


        static int[,] Mat(int[,] array1, int[,] array2)
        {
            try
            {
                int len1_0 = array1.GetLength(0);  // число строк 1 матрицы
                int len1_1 = array1.GetLength(1);
                int len2_0 = array2.GetLength(0); // число строк
                int len2_1 = array2.GetLength(1);

                if (len1_1 == len2_0)
                {
                    int[,] new_matr = new int[len1_0, len2_1];

                    for (int i = 0; i < len1_0; i++)
                    {
                        for (int j = 0; j < len2_1; j++)
                        {
                            for (int k = 0; k < len1_1; k++)
                            {
                                new_matr[i, j] += array1[i, k] * array2[k, j];
                            }
                        }
                    }
                    return new_matr;
                }
                else
                {
                    Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй!");
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
        static void PrintMat(int[,] new_matr, int[,] array1, int[,] array2)
        {
            for (int y = 0; y < Mat(array1, array2).GetLength(0); y++)
            {
                for (int x = 0; x < Mat(array1, array2).GetLength(1); x++)
                {
                    Console.Write(Mat(array1, array2)[y, x] + "\t");
                }
                Console.WriteLine();
            }



        }
        static void Main(string[] args)
        {

            Console.WriteLine("ДЗ.Задача 6.1");
            string str = "c:users\\admin\\github\\toomakov";
            char[] arr = str.ToCharArray();

            Console.WriteLine(Сounter(arr));


            Console.WriteLine("ДЗ.Задача 6.2");
            int[,] array1 = new int[,]
            {
                {1, 2, 3},
                {5, 6, 8},

            };
            int[,] array2 = new int[,]
            {
                {9, 2},
                {4, 7},
                {8, 4}

            };
            PrintMat(Mat(array1, array2), array1, array2);


        }
    }
}
