using _19_Class_Study_.Abstract;
using _19_Class_Study_.Data;

namespace _19_Class_Study_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            User seller = new Seller("ersin");
            seller.UserName = "admin";
            Console.WriteLine(seller.UserName);
        }
    }
}
