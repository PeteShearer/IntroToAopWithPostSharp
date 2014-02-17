using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using PostSharp.Patterns.Threading;

namespace IntroToAop3
{
    public class LongRunningClass
    {
        public void LongRunningOperationBlocking()
        {
            Thread.Sleep(3000);
            return;
        }

        [Background]
        public void LongRunningOperationBackground()
        {
            Thread.Sleep(3000);
            return;
        }
    }
}
