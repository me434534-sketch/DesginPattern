namespace _6_State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task("Create UI", new InProgressState());
            Task task2 = new Task("Write Tests", new ReadyForReviewState());
            Task task3 = new Task("Deploy App", new DoneState());

            task1.DisplayStatus();
            task2.DisplayStatus();
            task3.DisplayStatus();

            task1.SetState(new ReadyForReviewState());
            task1.DisplayStatus();

        }
    }
}
