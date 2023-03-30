using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03hm
{
    abstract class Component
    {
        protected string name;
        protected string summa;
        public Component(string name, string price)
        {
            this.name = name;
            this.summa = summa;
        }
        abstract public void Add(Component c);
        abstract public void Remove(Component c);
        abstract public void Print();
    }
    class Composite : Component
    {
        public List<Component> components = new List<Component>();
        public Composite(string name, string summa) : base(name, summa)
        {
            this.name = name;
            this.summa = summa;
        }
        public override void Add(Component c)
        {
            components.Add(c);
        }
        public override void Remove(Component c)
        {
            components.Remove(c);
        }
        public override void Print()
        {
            Console.WriteLine($"{name} - {summa}");
            foreach (Component c in components)
            {
                Console.WriteLine(c);
            }
        }
    }
    class Leaf : Component
    {
        public Leaf(string name, string price) : base(name, price)
        {
            this.name = name;
            this.summa = summa;
        }
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }
        public override void Print()
        {
            throw new NotImplementedException();
        }
        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
    }
    class Client
    {
        public void Print(Component c)
        {
            c.Print();
        }
        public void Add(Component c1, Component c2)
        {
            c1.Add(c2);
            c1.Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Composite reception = new Composite("Рецершен", "500");
            reception.Add(new Leaf("Газета Дрим", "50"));
            reception.Add(new Leaf("Смертная прелесть", "750"));
            reception.Add(new Leaf("Квадрант", "250"));
            Composite room1 = new Composite("Мебель", "1200");
            client.Add(reception, room1);
        }
    }
}
