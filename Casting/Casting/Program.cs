using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            #region Upcasting,boxing,implicit
            //Eagle eagle = new Eagle();
            //Animal animal = eagle;
            //Bird eagle1 = new Eagle();
            //Animal eagle2 = new Eagle();
            //Object eagle3 = new Eagle();
            //int a = 5;
            //bool isMaried = false;
            //string word = "Soz";
            //object[] arr = {eagle,eagle1,a,isMaried,word};
            //Console.WriteLine(eagle3);
            #endregion

            #region Downcasting,unboxing,explicit
            //Animal eagle = new Eagle();
            //Animal shark = new Shark();

            //insecurity way
            //Eagle castingEagle =(Eagle) shark;

            //Security way - 1
            //if(eagle is Eagle)
            //{
            //    Eagle castEagle = (Eagle)eagle;
            //}
            //else
            //{
            //    Console.WriteLine("Her heyvan qartal deyil");
            //}

            //Security way - 2

            //Eagle castEagle = eagle as Eagle;
            //if (castEagle != null)
            //{
            //    castEagle.Fly();
            //}
            //else
            //{
            //    Console.WriteLine("Her heyvan qartal deyil");
            //}
            //int a = 5;
            //string word = "Soz";
            //bool isMarried = false;

            //object[] arr = {  shark, a, word, eagle, isMarried };

            //foreach (var item in arr)
            //{
            //    Eagle castEagle = item as Eagle;
            //    if (castEagle != null)
            //    {
            //        castEagle.Fly();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Her object qartal deyil!!!");
            //    }
            //}
            #endregion

            #endregion

            #region Custom Implicit,explicit
            //Manat manat = new Manat(510);
            //Dollar dollar = (Dollar)manat;
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region Operators in custom type
            Person p1 = new Person("Melek", 24);
            Person p2 = new Person("Vasif", 37);
            Person p3 = new Person("Mustafa", 21);

            //Console.WriteLine(p2 - p1);
            Console.WriteLine(p1 > p2);
            #endregion
        }
    }
    #region Operators in custom type
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public static int operator -(Person p1,Person p2)
        {
            return p1.Name.Length - p2.Name.Length;
        }

        public static bool operator <(Person p1,Person p2)
        {
            return p1.Age < p2.Age;
        }

        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }
    }
    #endregion

    #region Custom Implicit,explicit
    class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }

        //public static implicit operator Dollar(Manat manat)
        //{
        //    double usd = manat.Azn / 1.7;
        //    return new Dollar(usd);
        //}

        public static explicit operator Dollar(Manat manat)
        {
            double usd = manat.Azn / 1.7;
            return new Dollar(usd);
        }
    }

    class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        {
            Usd = usd;
        }
    }
    #endregion

    #region Casting
    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    class Eagle : Bird
    {
        public int EagleAge { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    class Shark : Fish
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }
    #region Upcasting,boxing,implicit

    #endregion
    #endregion
}
