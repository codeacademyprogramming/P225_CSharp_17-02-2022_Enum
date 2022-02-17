using P225HomeWork1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225HomeWork1.Models
{
    class Student
    {
        public StudentType StudentType { get; set; }
        private string _groupNo;
        public string GroupNo 
        {
            get => _groupNo;
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Duzgun Group Nomresi Daxil Edin:");
                    value = Console.ReadLine();
                }
                _groupNo = value;
            }
        }
        private string _fullName;
        public string FullName 
        {
            get => _fullName;
            set
            {
                while (!CheckFullname(value))
                {
                    Console.WriteLine("Duzgun Ad Soyad Daxil Edin:");
                    value = Console.ReadLine();
                }
                _fullName = value;
            }
        }
        public byte Age { get; set; }

        public Student(string groupNo, string fullName,byte age, StudentType studentType)
        {
            GroupNo = groupNo;
            FullName = fullName;
            Age = age;
            StudentType = studentType;
        }

        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 4 && char.IsUpper(groupNo[0]))
            {
                for (int i = 1; i < groupNo.Length; i++)
                {
                    if (!char.IsDigit(groupNo[i]))
                        return false;
                }
                return true;
            }
            return false;
        }

        public static bool CheckFullname(string fullName)
        {
            return fullName.Split(' ').Length >= 2;
        }

        public string Getinfo()
        {
            return $"{FullName} {GroupNo} {Age} {StudentType}";
        }
    }
}
