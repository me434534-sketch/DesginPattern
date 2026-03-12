using System;
using System.Collections.Generic;
using System.Text;

namespace _6_State
{
    internal class Task
    {
        public string Name { get; set; }
        private ITaskState currentState;

        public Task(string name, ITaskState state)
        {
            Name = name;
            currentState = state;
        }

        public void SetState(ITaskState state)
        {
            currentState = state;
        }

        public void DisplayStatus()
        {
            Console.Write(Name + ": ");
            currentState.DisplayStatus();
        }
    }
}
