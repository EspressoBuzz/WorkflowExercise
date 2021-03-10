using System;

namespace _03_10_WorkflowExercise
{
    class Step : IActivity
    {
        public string ActivityName { get; set; }

        public Step(string stepname)
        {
            ActivityName = stepname;
        }

        void IActivity.Execute()
        {
            Console.WriteLine("Executing Step: " + ActivityName);
        }
    }
}