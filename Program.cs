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
            System.Console.WriteLine("Задание 2");
            Console.Write("Введите длину прямоугольника: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(side1,side2);
            System.Console.WriteLine("Вывод площади прямоугольника через свойство класса Rectangle: " + rectangle.Area);
            System.Console.WriteLine("Вывод периметр прямоугольника через свойство класса Rectangle: " + rectangle.Perimetr);
            // Book book = new Book();
            // book.title = Console.ReadLine();
            // book.realiz();
            System.Console.WriteLine("Задание 3");
            MyCar my1 = new MyCar();
            my1.currentSpeed = 300;
            my1.GetInfoMaxSpeed();
            System.Console.Write("Включаем фары машины и выключаем: ");
            my1.TurnLight();
            System.Console.Write($"Сила удара машины при скорости {my1.currentSpeed} км/ч и массе {my1.GetInfoWeight()} тонны = ");
            my1.Strenge(my1.currentSpeed);
            my1.FindTime(my1.currentSpeed,500);
            System.Console.WriteLine($"Цвет машины: {my1.carColor}");
            System.Console.WriteLine($"Марка машины: {my1.carModel}");
            System.Console.WriteLine($"Текущая скорость = {my1.currentSpeed} км/ч");
            Console.ReadKey(); 
        }
    }
    //Задание 3
class MyCar 
    {
        public void TurnLight ()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            System.Console.WriteLine("Beeep");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public int GetInfoWeight ()
        {
            return this.weight;
        }
        public int currentSpeed;
        private int maxSpeed = 300;
        private int weight = 3;
        public string carColor = "Серый";
        public string carModel = "BMW";
        public MyCar (int currentSpeed)
        {
            this.currentSpeed = currentSpeed;
        }
        public void FindTime(int currentSpeed, int kilometr)
        {
            if(currentSpeed > maxSpeed)
            {
                System.Console.WriteLine("Текущая скорость не может превышать максимальную!");;
            }
            System.Console.WriteLine($"Для преодоления {kilometr} киллометров со скоростью {currentSpeed} км/ч требуется " + Math.Round(((double)kilometr / (double)currentSpeed),2) + " часов");       
        }
        public void GetInfoMaxSpeed ()
        {
            System.Console.WriteLine("Максимальная скорость машины = " + this.maxSpeed + " км/ч");
        }
        public void Strenge (int currentSpeed)
        {
            if(currentSpeed > maxSpeed)
            {
                Console.WriteLine("Текущая скорость не может превышать максимальную!");
            }
            Console.WriteLine((this.weight*1000) * ((currentSpeed*1000 - 0 )/ 3600) + " Н");
        }
        public MyCar() {}
    }

    //Задание 2
    class Book 
    {   
        public void realiz (Title title,Author author,Content content)
        {
            title.Show();
            author.Show();
            content.Show();
        }
        public string title {
            get
            {
                return title;
            }
            set 
            {
                title = new Title().title;   
            }
        }
        public string author {get;set;}
        public string content {get;set;}
        public void Show()
        {
            Title tit = new Title();
            tit.Show();
            Author auth = new Author();
            auth.Show();
            Content cont = new Content();
            cont.Show();
        }
    }
    class Title 
    {
        public string title {
            get;
            set;
        }
        public void Show ()
        {
            System.Console.WriteLine(this.title);
        }
    }
    class Author 
    {
        public string author {get;set;}
        public void Show ()
        {
            System.Console.WriteLine(this.author);
        }
    }
    class Content 
    {
        public string content {get;set;}
        public void Show ()
        {
            System.Console.WriteLine(this.content);
        }
    }
}
