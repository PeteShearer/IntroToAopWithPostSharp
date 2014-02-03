using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToAop1
{
    public class Utility
    {
        [WriteLine]
        public string ReverseString(string input)
        {
            var inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            return new string(inputArray);
        }

        [WriteLine]
        public bool DoesStringStartWithACapitalLetter(string input)
        {
            var firstLetter = input[0];
            return Char.IsUpper(firstLetter);
        }

        [WriteLine]
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
