using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Decorator
{
    internal class SalaryDecorator : TeacherDecorator
    {
        public SalaryDecorator(ITeacher teacher) : base(teacher) { }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Salary Added");
        }
    }
}
