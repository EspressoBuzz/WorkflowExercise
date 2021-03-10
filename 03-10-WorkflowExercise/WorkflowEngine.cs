using System;
using System.Collections.Generic;
using System.Text;

namespace _03_10_WorkflowExercise
{
    class WorkflowEngine
    {
        public readonly List<IActivity> activitylist = new List<IActivity>();

        public void AddStep(IActivity onestep)
        {
            activitylist.Add(onestep);

        }
        public void Run()  //executes list of steps
        {
            foreach (var thisstep in activitylist)
            {
                thisstep.Execute();
            }
        }
    }
}