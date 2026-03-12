using System;
using System.Collections.Generic;
using System.Text;

namespace _6_State
{
    internal class ReadyForReviewState:ITaskState
    {
        public void DisplayStatus()
        {
            Console.WriteLine("Task is ready for review!");
        }
    }
}
