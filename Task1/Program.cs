using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle("Коло", 4 , 8, 25);
            Console.WriteLine("Фiгура    Радiус    Дiаметр   Довжина");
            Console.WriteLine(circle1.Circle2());
        }
    }
    class Circle
    {
        public int radius { get; set; }
        public int diameter { get; set; }
        public int line { get; set; }
        public string name { get; set; }

        public Circle(Circle previousCircle)
        {
            name = previousCircle.name;
            radius = previousCircle.radius;
            diameter = previousCircle.diameter;
            line = previousCircle.line;
        }
        public Circle(string Name, int Radius, int Diametr, int Line)
        {
            name = Name;
            radius = Radius;
            diameter = Diametr;
            line = Line;
        }
        public string Circle2()
        {
            return name + "         " + radius.ToString() + "      " + diameter.ToString() + "           " + line.ToString();
        }
    }
}
