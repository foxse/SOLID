using DemoLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();

            dvd.Actors = new List<string>() { "Mark Dacascos" }; 

            Console.ReadLine();
        }
    }
}
