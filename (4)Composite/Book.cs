using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace _4_Composite
{
    internal class Book:IBook
    {
        public string Name { get;  set; }
        public int Pages { get; set; }

        public Book(string name, int pages)
        {
            Name = name;
            Pages = pages;
        }

        public void ShowDetails(int indent = 0)
        {
            Console.WriteLine(new string('-', indent) + $"Box: {Name}");
        }

        public int GetPages()
        {
            return Pages;
        }
    }
}

