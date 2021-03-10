namespace _03_10_WorkflowExercise
{
    interface IActivity   //we will implement this in classes:  Steps() & Tasks().
    {
        public string ActivityName { get; set; }
        public void Execute();
    }
}