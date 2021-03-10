using System;

namespace _03_10_WorkflowExercise
{
    class Task : IActivity
    {
        public string ActivityName { get; set; }

        public Task(string taskname)
        {
            ActivityName = taskname;
        }

        public void Execute()
        {
            Console.WriteLine("Executing Task: " + ActivityName);
        }
    }
}