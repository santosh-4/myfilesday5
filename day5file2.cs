using System;
   public abstract class Animal
    {
        private string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("the dog is Eating");
        }
    }
    public class AbstractClass
{
    public static void Main(string[] args)
    {
        Dog d = new Dog();
        d.SetName(Console.ReadLine());
        Console.WriteLine("name of the dog is :");
        Console.WriteLine(d.GetName());
        d.Eat();
    }
}