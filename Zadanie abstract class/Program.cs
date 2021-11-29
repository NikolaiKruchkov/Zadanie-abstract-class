using System;

namespace Zadanie_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Dog dog1 = new Dog();
            cat1.Say();
            dog1.Say();
            cat1.ShowInfo();
            dog1.ShowInfo();

        }
    }



    abstract class Animal
    {
        public abstract string Nazvanie { get; set; }
        
        public abstract  void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Nazvanie);
            Say();
        }
        public Animal()
        {
            Nazvanie = "Животное";
        }
    }
    class Cat : Animal
    {
        string nazvanie;
        public override string Nazvanie
        {
            get
            {
                return nazvanie;
            }
            set
            {
                nazvanie = "Кошка";
            }
        }
        public static string zvuk = "Мяю";

        public override void Say()
        {
            Console.WriteLine(Cat.zvuk);
        }
    }

    class Dog: Animal
        {
            string nazvanie;
            public override string Nazvanie
            {
                get
                {
                    return nazvanie;
                }
                set
                {
                nazvanie = "Собака";
                }
            }
            public static string zvuk = "Гав";

            public override void Say()
            {
                Console.WriteLine(Dog.zvuk);
            }




        }
    


}
