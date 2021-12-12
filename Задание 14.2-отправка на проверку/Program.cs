using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14._2_отправка_на_проверку
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Персик");
            dog.ShowInfo();
            Cat cat = new Cat("Снегирка");
            cat.ShowInfo();

            Console.ReadKey();
        }
        abstract class Animal
        {
            public abstract string Name { get; set; }

            public abstract void Say();

            public virtual void ShowInfo()
            {
                Console.WriteLine(" {0} ", Name);
                Say();
            }
            public Animal(string name)
            {
                Name = name;
            }
        }
        class Dog : Animal
        {

            string name;
            public override string Name      //переопределяем свойство
            {
                get //срабатывает при попытки  получить значение
                {
                    return name;
                }
                set //срабатывает при попытки установить значение
                {
                    name = value;
                }
            }
                 public Dog(string name) : base(name)
                 {

                 }

                 public override void Say()
                 {
                   Console.WriteLine("\"Гав\"");

                 }
           
        }
        class Cat : Animal
        {

            string name;
            public override string Name      //переопределяем свойство
            {
                get //срабатывает при попытки  получить значение
                {
                    return name;
                }
                set //срабатывает при попытки установить значение
                {
                    name = value;
                }
            }
            public Cat(string name) : base(name)
            {

            }

            public override void Say()
            {
                Console.WriteLine("\"Мяу\"");

            }

        }





    }
}
