using MyApp;
using System;
using System.Runtime.InteropServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //num1
            /*
            Money money1 = new Money(10, 50);
            Money money2 = new Money(5, 75);

            Product product1 = new Product("Хлеб", money1);
            Product product2 = new Product("Молоко", money2);

            money1.DisplayAmount();

            product1.DisplayProductInfo();
            product2.DisplayProductInfo();

            product1.ReducePrice(2, 25);
            product2.ReducePrice(6, 0);

            Console.WriteLine("После уменьшения цен:");
            product1.DisplayProductInfo();
            product2.DisplayProductInfo();
            */
            //num2
            /*
            Kettle kettle = new Kettle("Чайник", "Чайник - устройство для кипячения воды.");
            Microwave microwave = new Microwave("Микроволновка", "Микроволновка - устройство для разогрева пищи.");
            Car car = new Car("Автомобиль", "Автомобиль - транспортное средство для передвижения.");
            Steamship steamship = new Steamship("Пароход", "Пароход - водный транспорт.");

            kettle.Show();
            kettle.Desc();
            kettle.Sound();

            Console.WriteLine();

            microwave.Show();
            microwave.Desc();
            microwave.Sound();

            Console.WriteLine();

            car.Show();
            car.Desc();
            car.Sound();

            Console.WriteLine();

            steamship.Show();
            steamship.Desc();
            steamship.Sound();
            */
            //num3
            /*
            Violin violin = new Violin("Скрипка", "Скрипка - струнный музыкальный инструмент.", "Скрипка появилась в XVI веке.");
            Trombone trombone = new Trombone("Тромбон", "Тромбон - духовой медный музыкальный инструмент.", "Тромбон был создан в XV веке.");
            Ukulele ukulele = new Ukulele("Укулеле", "Укулеле - струнный музыкальный инструмент с четырьмя струнами.", "Укулеле пришло из Португалии в Гавайи в XIX веке.");
            Cello cello = new Cello("Виолончель", "Виолончель - струнный музыкальный инструмент.", "Виолончель была создана в XVI-XVII веках.");

            violin.Show();
            violin.Desc();
            violin.HistoryInfo();
            violin.Sound();

            Console.WriteLine();

            trombone.Show();
            trombone.Desc();
            trombone.HistoryInfo();
            trombone.Sound();

            Console.WriteLine();

            ukulele.Show();
            ukulele.Desc();
            ukulele.HistoryInfo();
            ukulele.Sound();

            Console.WriteLine();

            cello.Show();
            cello.Desc();
            cello.HistoryInfo();
            cello.Sound();
            */
            //num4
            /*
            string asd = "sdf";
            President pres = new President(asd);
            Manager manager = new Manager(asd);
            Security security = new Security(asd);
            Engineer engineer = new Engineer(asd);
            pres.Print();
            manager.Print();
            security.Print();
            engineer.Print();
            */
        }
    }
    public class Money
    {
        private int dollars;
        private int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public int Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }

        public int Cents
        {
            get { return cents; }
            set { cents = value; }
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Сумма: {dollars}.{cents}");
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void ReducePrice(int dollars, int cents)
        {
            if (Price.Dollars > dollars || (Price.Dollars == dollars && Price.Cents >= cents))
            {
                Price.Dollars -= dollars;
                Price.Cents -= cents;
            }
            else
            {
                Console.WriteLine("Недостаточно средств для уменьшения цены.");
            }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Наименование: {Name}");
            Console.Write("Цена: ");
            Price.DisplayAmount();
        }
    }


    public class Device
    {
        protected string Name;
        protected string Description;

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void Sound()
        {
            Console.WriteLine("Издает звук устройства.");
        }

        public void Show()
        {
            Console.WriteLine($"Название устройства: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Описание устройства: {Description}");
        }
    }
    public class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description)
        {
        }
    }
    public class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description)
        {
        }
    }
    public class Car : Device
    {
        public Car(string name, string description) : base(name, description)
        {
        }
    }
    public class Steamship : Device
    {
        public Steamship(string name, string description) : base(name, description)
        {
        }
    }


    public class MusicalInstrument
{
    protected string Name;
    protected string Description;
    protected string History;

    public MusicalInstrument(string name, string description, string history)
    {
        Name = name;
        Description = description;
        History = history;
    }

    public void Sound()
    {
        Console.WriteLine("Издает звук музыкального инструмента.");
    }

    public void Show()
    {
        Console.WriteLine($"Название музыкального инструмента: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Описание музыкального инструмента: {Description}");
    }

    public void HistoryInfo()
    {
        Console.WriteLine($"История создания музыкального инструмента: {History}");
    }
}
    public class Violin : MusicalInstrument
{
        public Violin(string name, string description, string history) : base(name, description, history)
        {
        }
    }
    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description, string history) : base(name, description, history)
        {
        }
    }
    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description, string history) : base(name, description, history)
        {
        }
    }
    public class Cello : MusicalInstrument
    {
        public Cello(string name, string description, string history) : base(name, description, history)
        {
        }
    }


    public abstract class Worker
    {
        public abstract void Print();
    }
    public class President : Worker
    {
        public string Country { get; set; }

        public President(string country)
        {
            Country = country;
        }

        public override void Print()
        {
            Console.WriteLine("President");
        }
    }
    public class Manager : Worker
    {
        public string Company { get; set; }

        public Manager(string company)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine("Manager");
        }
    }
    public class Security : Worker
    {
        public string Secur { get; set; }

        public Security(string secur)
        {
            Secur = secur;
        }

        public override void Print()
        {
            Console.WriteLine("Security");
        }
    }
    public class Engineer : Worker
    {
        public string Engin { get; set; }

        public Engineer(string engin)
        {
            Engin = engin;
        }

        public override void Print()
        {
            Console.WriteLine("Engineer");
        }
    }

} 