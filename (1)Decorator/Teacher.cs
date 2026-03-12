using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Decorator
{
    internal class Teacher : ITeacher
    {
        public void Show()
        {
            Console.WriteLine("Teacher");
        }
    }
}
