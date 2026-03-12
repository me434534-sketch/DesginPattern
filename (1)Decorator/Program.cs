namespace _1_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacher teacher = new Teacher();

            teacher = new SalaryDecorator(teacher);
            teacher = new NationalityDecorator(teacher);
            teacher = new StreetDecorator(teacher);

            teacher.Show();
        }
    }
}
