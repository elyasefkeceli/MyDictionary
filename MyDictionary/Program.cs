using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("elyase","keceli");
            Console.WriteLine(myDictionary.Length);

            myDictionary.Add("engin", "töngel");
            Console.WriteLine(myDictionary.Length);

            

        }
    }
}
