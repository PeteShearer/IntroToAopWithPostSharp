using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAop1
{
    class Program
    {
        static void Main(string[] args)
        {
            var utils = new Utility();

            Console.WriteLine(utils.ReverseString("PeteOnSoftware"));
            Console.WriteLine(utils.ReverseString("PostSharp"));
            Console.WriteLine(utils.ReverseString("Aspect Oriented Programming"));

            Console.WriteLine(utils.DoesStringStartWithACapitalLetter("Pete"));
            Console.WriteLine(utils.DoesStringStartWithACapitalLetter("software"));
            Console.WriteLine(utils.DoesStringStartWithACapitalLetter("42"));

            Console.WriteLine(utils.StringToRot13("ANAN"));
            Console.WriteLine(utils.StringToRot13("anan"));
            Console.WriteLine(utils.StringToRot13("aaa zzz"));
        }
    }
}
