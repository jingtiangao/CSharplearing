using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oo
{
    class Test
    {
        static void Main(string[] args)
        {
            ChatRobot r1 = new ChatRobot("小夏");
            ChatRobot r2 = new ChatRobot("小秋");
            Console.WriteLine("请选择机器人：1->小夏，2—>小秋");
            ChatRobot r;
            int result = ChatRobot.ReadInt();
            if (result == 1)
                r = r1;
            else if (result == 2)
                r = r2;
            else
            {
                Console.WriteLine("输入错误，应输入1或2");
                return;
            }
            r.Eat(8);
            r.SayHello();
            while (true)
            {
                string line = Console.ReadLine();
                r.TalkTo(line);
                
            }
            Console.ReadLine();


        }
    }
    class ChatRobot
    {
        public string Name { get; set; }
        private int _foodLevel;
        public ChatRobot()
        {
            _foodLevel = 0;
        }
        public ChatRobot(string strName)
        {
            _foodLevel = 0;
            Name = strName;
        }
        public void SayHello()
        {
            Console.WriteLine("hello ,i am {0}", Name);

        }
        public void Eat(int foodCount)
        {
            if (_foodLevel + foodCount > 100)
            { Console.WriteLine("我吃不下这么多");

            return;
            }
            _foodLevel += foodCount;
        }
        public void TalkTo(string msg)
        {
            if (_foodLevel <= 0)
            {
                Console.WriteLine("饿死了，不说了");
                return;
            }
            if (msg.Contains("姓名") || msg.Contains("名字"))
            {
                this.SayHello();
            }
            else if (msg.Contains("女朋友"))
            {
                Console.WriteLine("年龄小，不考虑");

            }
            else
                Console.WriteLine("听不懂");

            _foodLevel--;
        }
        public static int ReadInt()
        {
            int result;
            int.TryParse(Console.ReadLine(), out result);
            return result;
        }

    }
    
}
