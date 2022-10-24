using System;
using System.Threading;

namespace ThreadE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Greetings");
            Thread.Sleep(1000);
            Console.WriteLine("Judges");
            Thread.Sleep(1000);
            Console.WriteLine("My name is Jeans");
            Thread.Sleep(1500);
            Console.WriteLine("Im practicing code and moving forward");
            Thread.Sleep(2000);
            Console.WriteLine("Thank you");
            Thread.Sleep(1000);
            */

            new Thread(() =>
          
            {
                Thread.Sleep(1000);
                Console.WriteLine("Greetings");
            }).Start();
            new Thread(() =>
            
            {
                Thread.Sleep(1000);
                Console.WriteLine("Judges");
            }).Start();
            new Thread(() =>
            
            {
                Thread.Sleep(1000);
                Console.WriteLine("My name is Jeans");
            }).Start();
            new Thread(() =>
           
            {
                Thread.Sleep(1000);
                Console.WriteLine("Im practicing code and moving forward");
            }).Start();
           
            new Thread(() =>

            {
                Thread.Sleep(1000);
                Console.WriteLine("Thank you!");
            }).Start();




            Console.ReadLine();
        }
    }   
}
