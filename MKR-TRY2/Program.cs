using System;

namespace MKR_TRY2
{
    interface IShape
    {
        string sizeFigure { get; }
        string Type();
        string Area();
    }

    class Square : IShape
    {
        protected double r { get; set; }
        public Square(double r)
        {
            this.r = r;
        }
        public string sizeFigure
        {
            get
            {
                return $"Cторона: {r}";
            }
        }
        public string Area()
        {
            double s = r * r;
            return $"Площа = {s.ToString("F")}";
        }
        public string Type()
        {
            return "Фiгура: квадрат";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square[] rectangle = { new Square(4.25), new Square(7), new Square(8.75) };
            foreach (Square str in rectangle)
            {
                Console.WriteLine($"{str.Type()}\n{str.sizeFigure}\n{str.Area()}\n");
            }
        }
    }
}