using System;
using System.IO;

namespace ConsoleApplication4
{
    public class Rectangle : Shape
    {
        public Tuple<int, int> LeftBottomPoint { get; set; }
        public Tuple<int, int> RightTopPoint { get; set; }

        public override void draw(TextWriter streamWriter)
        {
            streamWriter.WriteLine(format: "I am a {0} rectangle with angles at {1}, {2}", 
                Color, LeftBottomPoint, RightTopPoint);
        }

        public Rectangle()
        {
        }

        public Rectangle(StreamReader reader) : base(reader)
        {
            string[] leftBottom = reader.ReadLine()?.Split(' ');
            string[] rightTop = reader.ReadLine()?.Split(' ');
            LeftBottomPoint = new Tuple<int, int>(Int32.Parse(leftBottom[0]), Int32.Parse(leftBottom[0]));
            RightTopPoint = new Tuple<int, int>(Int32.Parse(rightTop[0]), Int32.Parse(rightTop[0]));
            reader.ReadLine();

        }
    }
}