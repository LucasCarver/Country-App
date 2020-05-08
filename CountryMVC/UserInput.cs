using System;
using System.Collections.Generic;
using System.Text;

namespace CountryMVC
{
    static class UserInput
    {
        public static string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().Trim();
        }
    }
}