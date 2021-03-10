using System;

namespace _03_10_WorkflowExercise
{
    class Program
    {
        static void Main()
        {
            var engine = new WorkflowEngine();
            var step1 = new Step("Step1");
            var step2 = new Step("Step2");
            engine.AddStep(step1);
            engine.AddStep(step2);

            engine.AddStep(new Step("Step3"));
            engine.AddStep(new Step("Step4"));

            engine.AddStep(new Task("Task1"));
            engine.AddStep(new Task("Task2"));
            engine.AddStep(new Task("Task3"));
            engine.AddStep(new Task("Task4"));

            engine.Run();

            Console.ReadLine();
        }
    }
}