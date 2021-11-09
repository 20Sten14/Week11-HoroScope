using System;
using System.IO;

namespace colours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favourite colour:");
            string usercolor = Console.ReadLine();
            Console.WriteLine(Getfavouritecolor(usercolor));
        }

        public static string[] ReadColor()
        {
            string filepath = @"C:\Users\opilane\Samples\personality.txt";
            string[] datafromfile = File.ReadAllLines(filepath);

            return datafromfile;
        }
        public static string Getfavouritecolor(string userinput)
        {
            string[] colour = ReadColor();
            string todaycolor = "";
            foreach (string element in colour)
            {
                if (element.Contains(userinput))
                {
                    todaycolor = element;
                }

            }
            return todaycolor;
        }



    }
}