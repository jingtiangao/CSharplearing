using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oo
{
    class duotai
    {
        static void Main(string[] args)
        {
            Chinese p1 = new Chinese();
            p1.Name = "李小龙";
            p1.SayHello();
           
            Korean p2 = new Korean();
            p2.Name = "都教授";
            p2.SayHello();
            Console.ReadKey();
      
        }
    }
    class Person
    {
        public string Name{ get; set;}
        public virtual void SayHello()//不同对象调用它时有不同的行为，定义为虚函数
        {
            Console.WriteLine("I am {0} I come from Earth",Name);
        }
    }
    class Chinese : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("I am {0},I come from China", Name);
        }
        
    }
    class Korean : Person
    {
       
        public override void SayHello()
        {
            Console.WriteLine("大家好。我是{0}，我来自韩国", Name);
        }
    }
}
