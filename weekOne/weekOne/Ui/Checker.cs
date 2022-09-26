using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekOne.Ui
{
    public static class Checker
    {
        
        public static T? Convert<T>(string prompt)
        {
            bool valid = true;
            string userInput;

            while (valid)
            {
                userInput = inputFromUser.UserInput(prompt);

                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if(converter != null)
                    {
                        return (T)converter.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid inpu, please try again");
                }
            }
            return default;
        }
    }
}
