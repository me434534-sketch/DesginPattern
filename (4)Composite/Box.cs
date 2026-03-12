using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Composite
{
    internal class Box:IBook
    {
        public string Name { get; set; }    
        private List<IBook> items = new List<IBook>();

        public Box(string name)
        {
            Name = name;
        }

        public void Add(IBook item)
        {
            items.Add(item);
        }

        public void ShowDetails(int indent = 0)
        {
            Console.WriteLine(new String('-', indent)+
            $"Box: {Name}");
            foreach(var item in items)
            {
                item.ShowDetails(indent+2);
            }
        }

        public int GetPages()
        {
            int total = 0;
            foreach(var item in items)
            {
                total+= item.GetPages();
            }
            return total;   
        }
    }
}
