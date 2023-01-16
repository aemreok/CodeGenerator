using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = GenerateCode();

            Console.WriteLine("Code => " + code);
            WriteToConsoleCodeIsValid(code);
            WriteToConsoleCodeIsValid("IJKLM6AB");
            WriteToConsoleCodeIsValid("234");
        }

        public static bool IsValidCode(string code)
        {
            string charachterSet = "ACDEFGHKLMNPRTXYZ234579";

            if (code.Length != 8)
            {
                return false;
            }

            return code.All(x => charachterSet.Contains(x));
        }

        public static string GenerateCode()
        {
            string charachterSet = "ACDEFGHKLMNPRTXYZ234579";
            var random = new Random();

            List<string> charachterSetList = new List<string>();

            for (int i = 0; i < 8; i++)
            {
                charachterSetList.Add(charachterSet);
            }

            var charArray = charachterSetList.Select(x => x[random.Next(charachterSet.Length)]).ToArray();

            return new string(charArray);
        }

        public static void WriteToConsoleCodeIsValid(string code)
        {
            if (IsValidCode(code))
            {
                Console.WriteLine(code + " => is valid");
            }
            else
            {
                Console.WriteLine(code + " => is not valid");
            }
        }
    }
}
