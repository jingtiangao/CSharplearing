using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasic
{
    class ExampleIO
    {
        static void Main()
        {
            p.Name="Tom";
            p.SayHello();
            p.eat();
            Person s1=new Person();
            Person s2=new Person("Tom");

        }
        class Person
        {
            public Person()
            {
                Console.WriteLine("Person.Person() fired"};
            }
            public Person(string strName)
            {
                this.Name=strName;
                Console.WriteLine(string strName);

            }
            public string Name;
            public void SayHello()
            {
                Console.WriteLine("hi,I am {0},I came from earth", name);
            }
            public eat()
            {
                Console.WriteLine("person eat fired");
            }

        }
    }
}
