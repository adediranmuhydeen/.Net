using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekOne.Ui
{
    public static class inputFromUser
    {
        public static string UserInput(string prompt)
        {
            Console.WriteLine($"{prompt}");
            return Console.ReadLine();
        }
    }
    public static class GreetMessage
    {
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"{prompt}");
            return Console.ReadLine();
        }
    }
}
