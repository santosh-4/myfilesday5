using System;
public class Person
{
    public string Name;
    
    public Person(string name)
    {
        Name = name;
    }
    public string ToString()
    {
        return "the name of the individual is :"+Name;
    }
    
    ~Person()
    {
        Name = string.Empty;
    }
}
class client
{
    public static void Main()
    {
        Person[] p = new Person[3];
        Console.WriteLine("Enter the names of the Individuals :");
        for(int i=0;i<p.Length;i++)
        {
            p[i] = new Person(Console.ReadLine());
        }
        for(int i=0; i<p.Length;i++)
        {
            Console.WriteLine(p[i].ToString());
        }
    }
}