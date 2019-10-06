using System;
using System.IO;

namespace ConsoleApplication4
{
    public abstract class Shape: IComparable<Shape>
    {
        public int LineWeight { get; set; }

        public string Color { get; set; }

        public abstract void draw(TextWriter writer);

        protected Shape()
        {
        }

        protected Shape(StreamReader reader)
        {
            this.Color = reader.ReadLine();
            this.LineWeight =  Int32.Parse(reader.ReadLine());
        }

        public int CompareTo(Shape other)
        {
            return LineWeight.CompareTo(other.LineWeight);
        }
    }
}