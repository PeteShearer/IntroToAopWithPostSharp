using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAop2
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new Utility();
            try
            {
                //Console.WriteLine(utils.ReverseString(null));
                Console.WriteLine(utils.MakeStringArrayFromThreeStrings("Pete", null, null));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
