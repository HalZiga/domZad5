using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace tumka
{

    internal class Program
    {
        static void MultMatric(LinkedList<LinkedList<int>> a, LinkedList<LinkedList<int>> b)
        {

            int i = a.Count;
            int j = b.Count;
            var newlist = new List<List<int>>();
            var list = Enumerable.ToList(a);
            var blist = Enumerable.ToList(b);
            for (int q = 0, r = 0; q < i; q++, r++)
            {
                var lst = Enumerable.ToList(list[q]);
                var blst = Enumerable.ToList(blist[r]);

                if (lst.Count > blst.Count)
                {
                    var newl = new List<int>();
                    for (int q1 = 0, r1 = 0; q1 < lst.Count; q1++, r1++)
                    {
                        try
                        {
                            var xer = lst[q1] * blst[q1];
                            newl.Add(xer);
                        }
                        catch
                        {
                            var xer = 0;
                            newl.Add(xer);
                        }

                    }
                    newlist.Add(newl);
                }
                else if (lst.Count < blst.Count)
                {
                    var newl = new List<int>();
                    for (int q1 = 0, r1 = 0; q1 < blst.Count; q1++, r1++)
                    {
                        try
                        {
                            var xer = lst[q1] * blst[q1];
                            newl.Add(xer);
                        }
                        catch
                        {
                            var xer = 0;
                            newl.Add(xer);
                        }

                    }
                    newlist.Add(newl);
                }
                else
                {
                    var newl = new List<int>();
                    for (int q1 = 0, r1 = 0; q1 < blst.Count; q1++, r1++)
                    {
                        try
                        {
                            var xer = lst[q1] * blst[q1];
                            newl.Add(xer);
                        }
                        catch
                        {
                            var xer = 0;
                            newl.Add(xer);
                        }

                    }
                    newlist.Add(newl);
                }
            }
            CheckListList(newlist);
        }
        static void CheckListList(List<List<int>> a)  // Метод Проверки
        {
            foreach (var i in a)
            {
                foreach (var j in i)
                {
                    Console.Write($"{j} ");
                }
                Console.Write("\n");
            }
        }

        /*static void Swap<T>(T[] a)//Тут ещё чтобы вводилось лист и массив
        {
            int g = 0;
            int s = 0;
            char[] glasn = { 'a', 'e', 'i', 'o', 'u', 'y' };//ffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffкак сделать так чтобы можно было ввести в метод массив и список
            for (int i = 0; i < a.Length; i++)
            {
                if (glasn.Contains(a[i]))
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
        }*/
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
        static void Zad1(List<char> array)
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
            if (arr.GetLength(1) != arrr.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] ar = new int[arr.GetLength(0), arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arrr.GetLength(1); j++)
                {
                    for (int k = 0; k < arrr.GetLength(0); k++)
                    {
                        ar[i, j] += arr[i, k] * arrr[k, j];
                    }
                }
            }
            return ar;
        }
        static List<List<int>> ZadL2(List<List<int>> a, List<List<int>> b)
        {
            List<List<int>> list = new List<List<int>>();
            

            int cnt = 0;
            foreach (var item in a)
            { cnt++; }
            int[,] ar = new int[cnt, a.Count];
            foreach (var list1 in a)
            {
                for (int i = 0; i < list1.Count; i++)
                {


                }

            }
                return list;
        }

        static string Zad3()
        {
            Random rnd = new Random();
            int[,] mesyac = new int[12, 30];
            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 30; y++)
                {

                    mesyac[x, y] = rnd.Next(30);
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
        /*static int[,] Zadd62()
        {

            return;
        }*/
        
        static void Main(string[] args)
        {
            /*Console.WriteLine("Задание 6.1 тумка");
            string path = @"C:\Users\zigan\source\repos\domZad5\TextFile1.txt";
            char[] bukvi = File.ReadAllText(path).ToArray<char>();
            Zad1(bukvi);


            Console.WriteLine("Задание 6.2 тумка");
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
            Console.WriteLine(Zad3());


            Console.WriteLine("Задание 6.1_2");
            List<char> bukv = File.ReadAllText(path).ToList<char>();
            Zad1(bukv);


            //Console.WriteLine("Задание 6.2_2");
            

            LinkedList<LinkedList<int>> ints = new LinkedList<LinkedList<int>>();
            Console.WriteLine("Сколько будет строк в матрице?");
            int cnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько столбцов будет в матрице?");
            int st = int.Parse(Console.ReadLine());
            for (int i = 0; i < cnt; i++)
            {
                LinkedList<int> l = new LinkedList<int>();
                for (int j = 0; j < st; j++)
                {
                    Console.WriteLine($"Укажи значения {i+1} строки");
                    int number = int.Parse(Console.ReadLine());
                    l.AddLast(number);
                    if (j + 1 == st)
                    {
                        ints.AddLast(l);
                    }
                }
            }

            LinkedList<LinkedList<int>> ints1 = new LinkedList<LinkedList<int>>();
            Console.WriteLine("Сколько будет строк в матрице?");
            int cnt1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько столбцов будет в матрице?");
            int st1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < cnt1; i++)
            {
                LinkedList<int> l1 = new LinkedList<int>();
                for (int j = 0; j < st1; j++)
                {
                    Console.WriteLine($"Укажи значения {i + 1} строки");
                    int number = int.Parse(Console.ReadLine());
                    l1.AddLast(number);
                    if (j + 1 == st1)
                    {
                        ints1.AddLast(l1);
                    }
                }
            }
            MultMatric(ints, ints1);


            Console.WriteLine("Домашнее Задание 3. Средняя температура за год");
            Dictionary<string, int[]> mamamia = new Dictionary<string, int[]>()
            {
                ["Jan"] = radik1(),
                ["Feb"] = radik2(),
                ["Mar"] = radik3(),
                ["Apr"] = radik4(),
                ["May"] = radik5(),
                ["Jun"] = radik6(),
                ["Jul"] = radik7(),
                ["Aug"] = radik8(),
                ["Sep"] = radik9(),
                ["Oct"] = radik10(),
                ["Nov"] = radik11(),
                ["Dec"] = radik12(),
            };
            Console.WriteLine(string.Join(" ", HomeTask3(mamamia)));*/
            int sluch = 0;
            int cnt = 0;
            while (sluch == 0)
            {
                Random rnd = new Random();
                sluch = rnd.Next(0,2);
                cnt++;
            }
            

            Console.WriteLine($"{sluch}  {cnt}");

                Console.ReadKey();
        }
        static int[] HomeTask3(Dictionary<string, int[]> t)
        {
            string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] tt = new int[12];
            for (int i = 0; i < month.Length; i++)
            {
                tt[i] = t[month[i]].Sum() / 30;
            }
            return tt;
        }
        static int[] radik1()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }

        static int[] radik2()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik3()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik4()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik5()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik6()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik7()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik8()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }

        static int[] radik9()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik10()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik11()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }
        static int[] radik12()
        {
            int[] mak = new int[30];
            Random r = new Random();
            for (int i = 0; i < mak.Length; i++)
            {
                mak[i] = r.Next(-30, 30);
            }
            return mak;
        }


    }
}
