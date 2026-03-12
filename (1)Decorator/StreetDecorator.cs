using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Decorator
{
    internal class StreetDecorator: TeacherDecorator
    {
        public StreetDecorator(ITeacher teacher) : base(teacher) { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Street Added");
        }
    }
}
