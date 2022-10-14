using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace domZad5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            




            Console.ReadKey();
        }
        public static class Dict
        {
            public static string Uchenik
            {
                return 
            }
            Dictionary<int, Student> students = new Dictionary<int, Student>
            {
                [0] = new Student { secondName = "Зиагншин", firstName = "Халиль", birthYear = 2003, exam = "inf", points = 245 },
                [1] = new Student { secondName = "Сайфуллин", firstName = "Азат", birthYear = 2005, exam = "inf", points = 254 },
                [2] = new Student { secondName = "Романов", firstName = "Илья", birthYear = 2003, exam = "inf", points = 253 },
                [3] = new Student { secondName = "Ахметов", firstName = "Ильдар", birthYear = 2003, exam = "inf", points = 249 },
                [4] = new Student { secondName = "Братухин", firstName = "Илья", birthYear = 2003, exam = "phis", points = 254 },
                [5] = new Student { secondName = "Калашников", firstName = "Андрей", birthYear = 2005, exam = "inf", points = 251 },
                [6] = new Student { secondName = "Залялетдинов", firstName = "Азат", birthYear = 2004, exam = "inf", points = 245 },
                [7] = new Student { secondName = "Ахметзянов", firstName = "Камиль", birthYear = 2004, exam = "eng", points = 241 },
                [8] = new Student { secondName = "Мошкина", firstName = "Мария", birthYear = 2004, exam = "inf", points = 249 },
                [9] = new Student { secondName = "Хузина", firstName = "Карина", birthYear = 2003, exam = "eng", points = 252 }
            };
        }
    }
}
