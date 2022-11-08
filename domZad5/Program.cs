using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace domZad5
{
    public struct Zhitel
    {
        public string name;
        public int pasport;
        public string problem;
        public byte tip;
        public bool um;
        public Zhitel(string Name, int Pasport, string Problem, byte Tip, bool Um)
        {
            name = Name;
            pasport = Pasport;
            problem = Problem;
            tip = Tip;
            um = Um;
        }

    }
    
    public struct Student
    {
        public string Sname;
        public string name;
        public DateTime age;
        public string exam;
        public int balli;

        public Student(string Sname, string name, DateTime age, string exam, int balli)
        {
            this.Sname = Sname;
            this.name = name;
            this.age = age;
            this.exam = exam;
            this.balli = balli;
        }
    }
    internal class Program
    {
        public static void Zad3()
        {
            Zhitel zhitel1 = new Zhitel("Азат Глаза Назад", 12345, "Откуда пени", 4, true);
            Zhitel zhitel2 = new Zhitel("Илья", 01053, "Просто спросить", 7, true);
            Zhitel zhitel3 = new Zhitel("Амир", 18181, "Отопление", 10, false);
            Zhitel zhitel4 = new Zhitel("Ильназ", 99999, "Денег нет", 2, true);
            Zhitel zhitel5 = new Zhitel("Данон", 11111, "Отопление", 8, true);
            Stack<Zhitel> peredZin = new Stack<Zhitel>();
            peredZin.Push(zhitel1);
            peredZin.Push(zhitel2);
            peredZin.Push(zhitel3);
            peredZin.Push(zhitel4);
            peredZin.Push(zhitel5);

            LinkedList<string> winddeng = new LinkedList<string>();
            LinkedList<string> windotopl = new LinkedList<string>();
            while (peredZin.Count > 0)
            {
                var chel = peredZin.Pop();
                byte skand = chel.tip;
                string ima = chel.name;
                string frasa = chel.problem;
                bool imtellect = chel.um;
                if (imtellect == false)
                {
                    Random rnd = new Random();
                    int sluch = rnd.Next(0, 2);
                    if (sluch == 0)
                    { winddeng.AddLast(ima); }
                    else if (sluch == 1)
                    { windotopl.AddLast(ima); }
                }
                else if (frasa == "Откуда пени" || frasa == "Денег нет" || frasa == "Просто спросить")
                {
                    if (skand <= 5)
                    {
                        winddeng.AddLast(ima);
                    }
                    else
                    {
                        Console.WriteLine("На сколько человек хотите обогнать");
                        int obgon = int.Parse(Console.ReadLine());
                        if (winddeng.Count <= obgon)
                        {
                            winddeng.AddFirst(ima);
                        }
                        else
                        {
                            Console.WriteLine("Скольких хотите обогнать");
                            int kolvo = int.Parse(Console.ReadLine());
                            Vper(ref winddeng, kolvo, ima);
                        }
                    }
                }
                else if (frasa == "Отопление")
                {
                    if (skand <= 5)
                    {
                        windotopl.AddLast(ima);
                    }
                    else if (skand > 5)
                    {
                        Console.WriteLine("На сколько человек хотите обогнать");
                        int obgon = int.Parse(Console.ReadLine());
                        if (windotopl.Count <= obgon)
                        {
                            windotopl.AddFirst(ima);
                        }
                        else
                        {
                            Vper(ref windotopl, obgon, ima);
                        }
                    }
                }
            }
            Console.WriteLine("ОЧередь в денежное окно");
            foreach (string ocher in winddeng)
            {
                Console.WriteLine(ocher);
            }
            Console.WriteLine("ОЧередь в окно отопления");
            foreach (string ocher in windotopl)
            {
                Console.WriteLine(ocher);
            }

        }   
        static void Vper(ref LinkedList<string> a,int b,string y)
        {
            int len = a.Count;
            int cnt = 0;
            foreach (string s in a)
            {
                string namee = s;
                
                cnt++;
                if (len - b == cnt)
                {
                    a.AddAfter(a.Find(s), y);
                    return;
              
                }
            }

            
        }
        public static void Task_4()
        {
            int[,] graph = { { 0, 1, 1, 0, 0, 0, 1 },
                            { 1, 0, 1, 1, 0, 0, 0 },
                            { 1, 1, 0, 0, 0, 0, 0 },
                            { 0, 1, 0, 0, 1, 0, 0 },
                            { 0, 0, 0, 1, 0, 1, 0 },
                            { 0, 0, 0, 0, 1, 0, 1 },
                            { 1, 0, 0, 0, 0, 1, 0 } };
            Queue<int> queue = new Queue<int>();
            int[] nodes = new int[9];
            for (int i = 0; i < 7; i++)
            { nodes[i] = 0; }
            queue.Enqueue(0);
            while (queue.Count != 0)
            {
                int node = queue.Peek();
                queue.Dequeue();
                nodes[node] = 2;
                for (int j = 0; j < 7; j++)
                {
                    if (graph[node, j] == 1 && nodes[j] == 0)
                    {
                        queue.Enqueue(j);
                        nodes[j] = 1;
                    }
                }
                Console.WriteLine(node + 1);
            }
            Console.ReadKey();

        }
        static void Task1()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            Student stud1 = new Student("Залялетдинов", "Азат", DateTime.Parse("03/11/2004"), "Информатика", 89);
            Student stud2 = new Student("Сагдуллин", "Амир", DateTime.Parse("07/07/2004"), "Информатика", 88);
            Student stud3 = new Student("Рофланов", "Илья", DateTime.Parse("01/11/2003"), "Информатика", 15);
            Student stud4 = new Student("Зиганшин", "Халиль", DateTime.Parse("15/07/2005"), "Физика", 101);
            Student stud5 = new Student("Ахметзянов", "Камиль", DateTime.Parse("14/08/2003"), "Английский", 96);
            Student stud6 = new Student("Братухин", "Илья", DateTime.Parse("19/03/2004"), "Физика", 69);
            Student stud7 = new Student("Головина", "Маша", DateTime.Parse("13/07/2003"), "Информатика", 95);
            Student stud8 = new Student("Андрей", "Калашиноков", DateTime.Parse("23/11/2004"), "Информатика", 13);
            Student stud9 = new Student("Морозов", "Даниил", DateTime.Parse("29/02/2004"), "Английский", 89);          
            Student stud10 = new Student("Мошкина", "Маша", DateTime.Parse("16/11/2004"), "Физика", 65);

            students.Add(stud1.Sname, stud1);
            students.Add(stud2.Sname, stud2);
            students.Add(stud3.Sname, stud3);
            students.Add(stud4.Sname, stud4);
            students.Add(stud5.Sname, stud5);
            students.Add(stud6.Sname, stud6);
            students.Add(stud7.Sname, stud7);
            students.Add(stud8.Sname, stud8);
            students.Add(stud9.Sname, stud9);
            students.Add(stud10.Sname, stud10);

            Console.WriteLine("введите команды: Новый студнт/ Удалить/ Сортировать");
            string k = Console.ReadLine().ToLower();
            switch (k)
            {
                case "новый студент":
                    Console.WriteLine("введите Имя");
                    string nam = Console.ReadLine();
                    Console.WriteLine("введите фамилию");
                    string snam = Console.ReadLine();
                    Console.WriteLine("введите год рождения");
                    DateTime ag = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("введите какой экзамен сдавал");
                    string ex = Console.ReadLine();
                    Console.WriteLine("введите какие у него баллы");
                    int bal = int.Parse(Console.ReadLine());
                    students.Add(snam, new Student { Sname = snam, name = nam, age = ag, exam = ex, balli = bal });
                    foreach (var s0 in students)
                    {
                        Console.WriteLine($" Фамилия: {s0.Value.Sname}, Имя: {s0.Value.name}, День рождения: {s0.Value.age.ToShortDateString()}, Экзамен: {s0.Value.exam}, Баллы: {s0.Value.balli}");
                    }
                    break;

                case "удалить":
                    Console.WriteLine("Введите фамилию студента, которого вы хотите удалить");
                    string surname = Console.ReadLine();
                    if (students.ContainsKey(surname))
                    {
                        students.Remove(surname);
                    }
                    foreach (var s0 in students)
                    {
                        Console.WriteLine($" Фамилия: {s0.Value.Sname}, Имя: {s0.Value.name}, День рождения: {s0.Value.age.ToShortDateString()}, Экзамен: {s0.Value.exam}, Баллы: {s0.Value.balli}");
                    }
                    break;

                case "сортировать":
                    var sorted = students.OrderBy(x => x.Value.balli).ToDictionary(x => x.Key, x => x.Value.balli);
                       Console.WriteLine(String.Join("\n", sorted));
                    break;

                default:
                    Console.WriteLine("Вы ввели не то слово");
                    break;
            }
            


        }
        /*static string zd2(int[] arr, int[] arrrr)
        {
            int c1 = 0;
            int c2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                    { c1++; }
                if (arrrr[i] == 5)
                    { c2++; }
            }

            return c1 == c2 ? "sdfsdfsd" : "asdfsadf";
            if (c1 == c2) { return "Drinks All Round! Free Beers on Bjorg!"; }
            else { return "Ой, Бьорг - пончик! Ни для кого пива"; }
        }*/

        static void Main(string[] args)
        {
            /*Console.WriteLine("Задание 1");
            Task1();

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите количество бросков костей");
            int N = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] Bavarian = new int[N];
            for (int i = 0; i < Bavarian.Length; i++)
                Bavarian[i] = random.Next(0, 9);
            int[] Scandinavian = new int[N];
            for (int i = 0; i < Scandinavian.Length; i++)
                Scandinavian[i] = random.Next(0, 9);
            Console.WriteLine(zd2(Bavarian, Scandinavian));*/

            Console.WriteLine("Задание 3");
            Zad3();


            Console.WriteLine("Задание 4");
            Task_4();


            Console.ReadKey();
        }
        
    }
}
