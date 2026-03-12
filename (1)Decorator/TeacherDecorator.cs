using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Decorator
{
    internal class TeacherDecorator : ITeacher
    {
        protected ITeacher teacher;

        public TeacherDecorator(ITeacher teacher)
        {
            this.teacher = teacher;
        }

        public virtual void Show()
        {
            teacher.Show();
        }
    }
}
