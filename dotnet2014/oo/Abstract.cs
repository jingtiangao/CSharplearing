using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oo
{
    class Abstract
    {
        static void Main(string[] args)
        {
            Chinese s1 = new Chinese();
            Korean s2 = new Korean();

        }
    }
    abstract class Person
    {

        public string Name { get; set; }
        //抽象或非抽象方法
        public void Sleep()
        {
            Console.WriteLine("I am Sleep");
        }
        public abstract void SayHello();
        //抽象方法没有方法体，即不可用大括号
        //只能加小括号

        //当不能确定方法的实现时定义为抽象方法
            

    }

    class Chinese :Person
    {
        public override void SayHello()
        {
            Console.WriteLine("I am Chinese");
        }
        
    }
    class Korean : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("I am Korean");
        }
    }

}
