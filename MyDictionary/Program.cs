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

            Console.WriteLine(courses.Len);
            foreach (var item in courses.Keys)
            {
                Console.WriteLine("Keys:"+item);
            }
            foreach (var item in courses.Values)
            {
                Console.WriteLine("Values:" + item);
            }
        }
    }
}
