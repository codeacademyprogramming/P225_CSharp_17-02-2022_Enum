using System;

namespace P225Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Heftenin Gunlerinden Birini Sec");
            //foreach (var item in Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine($"{(byte)item} {item}");
            //}

            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("1-ci gun");
            //        break;
            //    case 10:
            //        Console.WriteLine("2-ci gun");
            //        break;
            //    case 15:
            //        Console.WriteLine("3-ci gun");
            //        break;
            //    default:
            //        break;
            //}

            string[] arr = Enum.GetNames(typeof(WeekDay));

            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
