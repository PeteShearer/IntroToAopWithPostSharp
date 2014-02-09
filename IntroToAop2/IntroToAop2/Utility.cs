using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAop2
{
    public class Utility
    {
        [NoNullParams]
        public string ReverseString(string input)
        {
            var inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            return new string(inputArray);
        }

        [NoNullParams]
        public string[] MakeStringArrayFromThreeStrings(string item1, string item2, string item3)
        {
            // This method is completely useless.  I just wanted multiple params to test the NoNullParamsAttribute with.
            return new[] { item1, item2, item3 };
        }

        public bool DoesStringStartWithACapitalLetter(string input)
        {
            var firstLetter = input[0];
            return Char.IsUpper(firstLetter);
        }

        public string StringToRot13(string input)
        {
            // From http://www.dotnetperls.com/rot13
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}
