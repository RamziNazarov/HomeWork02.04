using System;

namespace HomeWork02._04
{
    class Rectangle 
    {
        public double side1 {get;}
        public double side2 {get;}
        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double Area 
        {
            get
            {
                return AreaCalculator(this.side1,this.side2);
            }
        }
        public double Perimetr
        {
            get
            {
                return PerimetrCalculator(this.side1,this.side2);
            }
        }
        static double AreaCalculator (double side1,double side2)
        {
            double Area1 = side1 + side2;
            return Area1;
        }
        static double PerimetrCalculator (double side1,double side2)
        {
            return 2;
        }
        public Rectangle() 
        {

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1,side2);
            System.Console.WriteLine("Вывод площади прямоугольника через свойство класса Rectangle: " + rectangle.Area);
            System.Console.WriteLine("Вывод периметр прямоугольника через свойство класса Rectangle: " + rectangle.Perimetr);
            Console.ReadKey(); 
        }
    }
}
