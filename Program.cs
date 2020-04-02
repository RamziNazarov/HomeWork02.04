using System;

namespace HomeWork02._04
{
    class Rectangle 
    {
        public double side1 {get;set;}
        public double side2 {get;set;}
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
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            double side1 = 12;
            double side2 = 13;
            Console.WriteLine((new Rectangle(side1,side2).Area).ToString());
            Console.ReadKey(); 
        }
    }
}
