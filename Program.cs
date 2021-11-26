using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowInfo();
            Console.WriteLine();
            dog.ShowInfo();
            
            Console.ReadKey();
        }
    }
    abstract class Animal
    {

        public abstract string Name { get; set; }

        public Animal()
        {
            Name = "Копатыч";
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine("Привет, меня зовут {0}", Name);
            Say();

        }
                        
    }

    class Cat : Animal
    {
        public override string Name { get; set; }

      
        public override void Say()
        {
            Console.WriteLine("Мяу мяу");
        }
                     
    }

    class Dog : Animal
    {
        public override string Name { get; set; }

     
        public override void Say()
        {
            Console.WriteLine("Гав гав");
        }

    }

}
