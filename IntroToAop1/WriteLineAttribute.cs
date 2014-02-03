using PostSharp.Aspects;
using System;

namespace IntroToAop1
{
    [Serializable] 
    public class WriteLineAttribute : OnMethodBoundaryAspect 
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Entering {0} at {1}", args.Method.Name, DateTime.Now.Ticks.ToString());
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Leaving {0} at {1}", args.Method.Name, DateTime.Now.Ticks.ToString());
        } 
    }
}
