using System;

namespace MyDictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDiction<int, string> products = new MyDiction<int, string>();
            products.Add(1, "pencil");
            products.Add(2, "ruler");
        }
    }
}
