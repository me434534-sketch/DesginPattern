using System;
using System.Collections.Generic;
using System.Text;

namespace _6_State
{
    internal class InProgressState:ITaskState
    {
        public void DisplayStatus()
        {
            Console.WriteLine("Task is in progress...");
        }
    }
}
