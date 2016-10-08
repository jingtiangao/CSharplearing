using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oo
{
    class exampleHeritance
    {
        static void Main(string[] args)
        {
            Chinese p1 = new Chinese();
            p1.Name = "李小龙";
            p1.SayHello();
            p1.Kungfu();
            Korean p2 = new Korean();
            p2.Name = "都教授";
            p2.SayHello();
            p2.Zuopaocai();
            Console.ReadKey();
            Person p3 = new Chinese();//要一个人给一个中国人，OK
            Person p4 = new Korean();//要一个人给一个韩国人，OK
            //Chiners p5 =new Person();//要一个中国人给一个人不可以

        }
    }
    class Person
    {
        public string Name { get; set; }
        public void SayHello()
        {
            Console.WriteLine("my name is {0}", this.Name);

        }
    }
    class Chinese : Person
    {
        public string Hukou { get; set; }
        public void Kungfu()
        {
            Console.WriteLine("Kongfu");
        }
        
    }
    class Korean : Person
    {
        public void Zuopaocai()
        {
            Console.WriteLine(" can Zuopaocai");
        }
    }
}
