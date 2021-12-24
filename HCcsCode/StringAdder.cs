using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

// String adder problem

namespace HCcsCode
{
    // visibility: public internal private
    static class StringExtention
    {
        public static string Reverse(this string self)
        {
            var charArray = self.ToCharArray();
            for (var i=0; i<self.Length/2; i++)
            {
                var tmp = charArray[i];
                charArray[i] = charArray[self.Length - 1 - i];
                charArray[self.Length - 1 - i] = tmp;
            }

            return new string(charArray);
        }


        public static string Reverse2(this string self)
        {
            char[] charArray = self.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    public class StringAdder
    {
        private string str1;
        private string str2;
        private string result;


        public StringAdder(string str1, string str2)
        {
            this.str1 = str1;
            this.str2 = str2;
        }


        public string Adder(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                var temp = str2;
                str2 = str1;
                str1 = temp;
            }

            // var str3 = string.ChooseLongerBetween(str1, str2);

            str2 = str2.PadLeft(totalWidth: str1.Length, paddingChar: '0');


            var carry = 0;
            var res = 0;
            for (int i = str1.Length - 1; i >= 0; --i)
            {
                var sum = (str1[i] - '0') + (str2[i] - '0') + carry;
                carry = sum / 10;
    
                if (carry == 1)
                    res+=1;

                res = sum % 10;
                result += res.ToString();
            }

            return result.Reverse2();
        }

        class Program
        {
            static void Main(string[] args)
            {
                var str1 = "123";
                var str2 = "4567";

                var xx = str2.Reverse();
                var yy = str2.Reverse2();
                //var strAdder = new StringAdder(str1, str2);

                //Console.WriteLine(strAdder.Adder(str1, str2));
                //Debug.Assert(str1 + str2 == "4690");
            }
        }
    }
}