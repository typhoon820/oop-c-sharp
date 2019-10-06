using System;
using System.IO;

namespace ConsoleApplication4
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public Tuple<int, int> Center { get; set; }

        public override void draw(TextWriter streamWriter)
        {
            streamWriter.WriteLine("I am {0} circle of radius {1}", Color, Radius);
        }

        public Circle()
        {
        }

        public Circle(StreamReader reader) : base(reader)
        {
            string[] center = reader.ReadLine().Split(' ');
            Radius = Int32.Parse(reader.ReadLine());
            Center = new Tuple<int, int>(Int32.Parse(center[0]), Int32.Parse(center[1]));
            reader.ReadLine();
        }
    }
}