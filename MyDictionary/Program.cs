using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MyDictionary<int, string> courses = new MyDictionary<int, string>();
            
                 
            courses.Add(101, "Introducton to Computer");
            courses.Add(201, "Java");
            courses.Add(202, "OOP");

            Console.WriteLine("Count of items in Mydictionary: "+courses.Len);
            foreach (var item in courses.Keys)
            {
                Console.WriteLine("Keys:"+item);
               // Console.WriteLine("Values"+courses.Keys[item]);
            }
            //Console.WriteLine(courses[101]);
            foreach (var item in courses.Values)
            {
                Console.WriteLine("Values:" + item);
            }
            for (int i = 0; i < courses.Len; i++)
            {
                Console.WriteLine("Key : {0}  ve   Value :  {1}", courses.Keys[i], courses.Values[i]);

            }



          
        }
    }
}
