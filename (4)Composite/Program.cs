namespace _4_Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("book 1", 200);
            Book book2 = new Book("book 2", 300);
            Box box1 = new Box("box 1");
            Box box2 = new Box("Box 2");

            box1.Add(book1);
            box1.Add(book2);
            box2.Add(box1);
            box2.Add(new Book("book 3", 150));

            box2.ShowDetails();
            Console.WriteLine($"Total Pages in {box2.Name}: {box2.GetPages()}");
        }
    }
}
