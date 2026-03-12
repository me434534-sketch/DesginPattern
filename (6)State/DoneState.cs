using System;
using System.Collections.Generic;
using System.Text;

namespace _6_State
{
    internal class DoneState:ITaskState
    {
        public void DisplayStatus()
        {
            Console.WriteLine("Task is done");
        }
    }
}
