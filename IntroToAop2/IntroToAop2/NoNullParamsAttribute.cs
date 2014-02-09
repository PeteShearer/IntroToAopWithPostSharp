using PostSharp.Aspects;
using System;
using System.Text;

namespace IntroToAop2
{
    [Serializable] 
    public class NoNullParamsAttribute : OnMethodBoundaryAspect 
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            var messages = new StringBuilder();

            for (int i = 0; i < args.Arguments.Count; i++)
            {
                if (args.Arguments.GetArgument(i) == null)
                {
                    messages.AppendFormat("Parameter {0} cannot be null. ", args.Method.GetParameters()[i].Name);
                }
            }

            if (messages.Length > 0)
            {
                throw new ArgumentException(messages.ToString());
            }
        }
    }
}

