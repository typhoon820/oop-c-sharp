using System;
using System.IO;
using System.Linq;

namespace ConsoleApplication4
{
    internal class Program
    {
        public static void deleteCircle(Figures figures, int radius)
        {
            figures.Shapes.RemoveAll(shape => shape is Circle circle && circle.Radius < radius);
        }

        public static void Main(string[] args)
        {
            Figures figures = new Figures(@"figures.txt");
            figures.Print(Console.Out);
            figures.sort();
            deleteCircle(figures, 3);
            figures.Print(Console.Out);
            StreamWriter sw = new StreamWriter(@"./figures-sorted.txt");
            sw.AutoFlush = true;
            Console.SetOut(sw);
            figures.Print(Console.Out);
        }
    }
}