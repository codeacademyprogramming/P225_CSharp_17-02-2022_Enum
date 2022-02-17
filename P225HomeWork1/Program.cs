using P225HomeWork1.Enums;
using P225HomeWork1.Models;
using System;

namespace P225HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telebenin Zemanetlid Olmagni Sec:");
            foreach (var item in Enum.GetValues(typeof(StudentType)))
            {
                Console.WriteLine($"{(byte)item} {item}");
            }

            int selected = int.Parse(Console.ReadLine());

            StudentType studentType = 0;

            switch (selected)
            {
                case 1:
                case 2:
                    studentType = (StudentType)selected;
                    break;
                default:
                    Console.WriteLine("Duzgun Daxil Et");
                    break;
            }

            Student student = new Student("P225", "Hamid Mammadov", 15, studentType);
            Console.WriteLine(student.Getinfo());
        }
    }
}
