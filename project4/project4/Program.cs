using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter no of students:");
                int num = int.Parse(Console.ReadLine());
                Student[] stu = new Student[num];
                String Name;
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Enter Name of student:");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter Class");
                    int Class = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Section");
                    char Section = char.Parse(Console.ReadLine());

                    stu[i] = new Student(Name, Class, Section);
                    Console.WriteLine("----------------------------------");
                }
                Console.WriteLine("--****--teachers--*****---");
                Console.WriteLine("Enter no of Teachers:");
                int num2 = int.Parse(Console.ReadLine());
                Teacher[] teach = new Teacher[num2];
                for (int i = 0; i < num2; i++)
                {
                    Console.WriteLine("Enter The Name of Teacher:");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter Class:");
                    int Class = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Section:");
                    char Section = char.Parse(Console.ReadLine());

                    teach[i] = new Teacher(Name, Class, Section);

                }
                Console.WriteLine("----------------------------------");
                Console.WriteLine("-*****----Subject--******---");
                Console.WriteLine("Enter no of Subjects:");
                int num3 = int.Parse(Console.ReadLine());
                Subject[] sub = new Subject[num3];
                for (int j = 0; j < num3; j++)
                {
                    Console.WriteLine("Enter Name of Subject:");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter SubjectCode:");
                    int SubjectCode = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Teacher Name:");
                    string Teacher = Console.ReadLine();

                    sub[j] = new Subject(Name, SubjectCode, Teacher);

                }
                
                Console.WriteLine("print The  value of Students Data:");
                foreach (var data in stu)
                {
                    Console.WriteLine($"Name  :   {data.Name}");
                    Console.WriteLine($"Class  :   {data.Class}");
                    Console.WriteLine($"Section  :   {data.Section}");
                }
                Console.WriteLine("-------------------");
                Console.WriteLine("Print details of teacher:");
                foreach (var data in teach)
                {
                    Console.WriteLine($"Name  :   {data.Name}");
                    Console.WriteLine($"Class  :   {data.Class}");
                    Console.WriteLine($"Section  :   {data.Section}");
                }
                foreach (var data in sub)
                {
                    Console.WriteLine($"Name  :   {data.Name}");
                    Console.WriteLine($"Class  :   {data.SubjectCode}");
                    Console.WriteLine($"Section  :   {data.Teacher}");
                }
                Console.ReadKey();

            


        }
    }
}
