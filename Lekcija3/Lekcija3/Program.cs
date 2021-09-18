using System;

namespace Lekcija3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Dagnija");
            Person person2 = person;

            // person.Name = "Dagnija111";
            person.Age = 50;
            person.IsMale = false;
            person.Money = 1000.00;
            person.Initial = 'D';

            Console.WriteLine(person.Age);
            Console.WriteLine(person2.Age);

            person2.Age = 26;

            Console.WriteLine(person.Age);
            Console.WriteLine(person2.Age);

            string greeting = person.GetGreeting();

            Console.WriteLine(greeting);         
        }
    }
}
