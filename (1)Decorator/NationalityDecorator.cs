using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Decorator
{
    internal class NationalityDecorator : TeacherDecorator
    {
        public NationalityDecorator(ITeacher teacher) : base(teacher) { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Nationality Added");
        }
    }
}
