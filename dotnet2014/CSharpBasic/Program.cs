using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   int x = 13;
            int y = 14;
            int sum = x + y;
            string name = "David Beckham";
            Console.WriteLine("hello,dotnet");
            Console.WriteLine("{0}", x);//the value of x
            Console.WriteLine("{0}+{1}={2}", x, y, sum);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Substring(1, 4));
            Console.WriteLine(name.IndexOf("v"));
            Console.ReadKey();
          */
            #region //用+进行连接
            //用+进行连接
            
            int length = 30, loops = 5000;
            DateTime startTime, endTime;
            string strSourse = new string('X', length);
            string strDest = "";
            startTime = DateTime.Now;
            for (int i = 0; i < loops; i++)
            {
                strDest += strSourse;
            }
            endTime = DateTime.Now;
            Console.WriteLine("StringBuilder took " + (endTime - startTime).TotalSeconds + " seconds."); 
            #endregion


            #region 用StringBuilder进行字符串连接
            //用StringBuilder进行字符串连接
            startTime = DateTime.Now;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < loops; i++)
            {
                builder.Append(strSourse);
            }
            strDest = builder.ToString();
            endTime = DateTime.Now;
            Console.WriteLine("StringBuilder took " + (endTime - startTime).TotalSeconds + " seconds."); 
            #endregion
            //
            #region array
            int.Parse("123");
            int result = Convert.ToInt32("123");
            int[] nums = new int[6] { 1, 2, 3, 4, 5, 6 };
            string[] ss = new string[4]{ "a", "b", "c", "c" };
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, nums[i]);
            } 
            #endregion
            #region foreach
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            foreach (string item in ss)
            {
                Console.WriteLine(item);
            } 
            #endregion
            #region //out a|b|c|c
            //out a|b|c|c
            string[] strs = new string[4] { "a", "b", "c", "c" };
            Console.WriteLine(Join(strs, "|")); 
            #endregion
            #region //LIST的用法
            //LIST的用法
            List<int> list = new List<int>();
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(1);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(2);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(3);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(4);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(5);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(6);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Sort(); 
            #endregion

            #region //键值对的集合
            //键值对的集合
            Dictionary<string, long> phonebook = new Dictionary<string, long>();

            phonebook.Add("Tom", 56886777);
            phonebook.Add("Jack", 568867337);
            phonebook["Micky"] = 567728828;
            if (phonebook.ContainsKey("Alex"))
                Console.WriteLine("phone number of  Alex :" + phonebook["Alex"]);
            else
                Console.WriteLine("not found Alex");
            foreach (var item in phonebook)
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
            Console.ReadKey(); 
            #endregion

        
        }
        static double readDouble()
        {
            double result;
            double.TryParse(Console.ReadLine(), out result);
            return result;

        }
        static string Join (string[] strs, string seperator)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i <strs.Length-1; i++)
            {
                builder.Append(strs[i]);
                builder.Append(seperator);
            }
            builder.Append(strs[strs.Length-1]);
            return builder.ToString();
        }

    }
}
