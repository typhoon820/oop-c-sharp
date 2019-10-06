using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Figures figures = new Figures(@"figures.txt");
            figures.Print(Console.Out);
            figures.sort();
            StreamWriter sw = new StreamWriter(@"./figures-sorted.txt");
            sw.AutoFlush = true;
            Console.SetOut(sw);
            figures.Print(Console.Out);
        }
    }
}