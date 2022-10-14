﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tumka
{
    internal class Program
    {
        static void Zad1(params char[] array)
        {
            int g = 0;
            int s = 0;
            char[] glasn = { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (char c in array)
            {
                if (glasn.Contains(c))
                {
                    g++;
                }
                else
                {
                    s++;
                }
            }
            Console.WriteLine($"Гласных {g}");
            Console.WriteLine($"Согласных {s}");
        }

        static void Zad21(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static int[,] Zad22(int[,] arr, int[,] arrr)
        {
            if (arr.GetLength(1) != arrr.GetLength(1)) throw new Exception("Матрицы нельзя перемножить");
            int[,] ar = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arrr.GetLength(0); j++)
                {
                    for (int k = 0; k < arr.GetLength(1); k++)
                    {
                        ar[i, j] += arr[i, k] * arrr[i, k];
                    }
                }
            }
            return ar;
        }
        static string Zad3()
        {
            Random rnd = new Random();
            int[,] mesyac = new int[12, 30];
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 30; y++)
                {
                    
                    mesyac[x, y] = rnd.Next( 30);
                }
            }

            float sred = 0;
            float[] ar = new float[12];
            for (int m = 0; m < ar.Length; m++)
            {
                for (int d = 0; d < mesyac.GetLength(1); d++)
                {
                    sred += mesyac[m, d];
                }
                ar[m] += sred / mesyac.GetLength(1);
                sred = 0;
            }
            Array.Sort(ar);
            string st = String.Join(" ", ar);
            return st;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6.1 тумка");
            string path = @"C:\Users\zigan\source\repos";
            char[] bukvi = File.ReadAllText(path).ToArray<char>();
            Zad1(bukvi);


            /*Console.WriteLine("Задание 6.2 тумка");
            Console.WriteLine("Введите размерность первой матрицы: ");
            int[,] myArray = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write("myArray[{0},{1}] = ", i, j);
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите размерность второй матрицы: ");
            int[,] myArray1 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < myArray1.GetLength(0); i++)
            {
                for (int j = 0; j < myArray1.GetLength(1); j++)
                {
                    Console.Write("myArray1[{0},{1}] = ", i, j);
                    myArray1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] ar = Zad22(myArray, myArray1); 
            Zad21(ar);


            Console.WriteLine("Задание 6.3 тумка");
            Console.WriteLine(Zad3());*/


            Console.ReadKey();
        }
    }
}