using System;

namespace testClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person("Vova");
            person1.SetName("Dmytro");
            Console.WriteLine(person1.GetName()); 
        }
    }
}
     
     
     
     
     
     
