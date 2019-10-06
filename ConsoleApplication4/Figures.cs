using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ConsoleApplication4
{
    public class Figures
    {
        public string Name { get; set; }
        public List<Shape> Shapes { get; set; }

        public Figures(string filePath)
        {
            Shapes = new List<Shape>();
            filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), filePath);
            StreamReader reader = new StreamReader(filePath);
            Name = reader.ReadLine();
            string type = reader.ReadLine();
            while (type != null)
            {
                switch (type)
                {
                    case "Circle":
                        Shapes.Add(new Circle(reader));
                        break;
                    case "Rectangle":
                        Shapes.Add(new Rectangle(reader));
                        break;
                }

                type = reader.ReadLine();
            }
        }

        public void Print(TextWriter streamWriter)
        {
            streamWriter.WriteLine(Name);
            Shapes.ForEach(shape => shape.draw(streamWriter));
            streamWriter.Close();
        }

        public void sort()
        {
            Shapes.Sort();
        }
    }
}