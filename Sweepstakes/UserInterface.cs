using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string GetUserInputString(string output)
        {
            Console.WriteLine(output);
            return Console.ReadLine();
        }
        public static int GetUserInputInt(string output)
        {
            Console.WriteLine(output);
            return Int32.Parse(Console.ReadLine());
        }

        
        
        public static int GetRegistrationNumberInput(Contestant contestant)
        {
            Console.WriteLine("Enter the contestant's REGISTRATION NUMBER, then hit enter: ");
            contestant.RegistrationNumber = Int32.Parse(Console.ReadLine());
            return contestant.RegistrationNumber;
        }


    }
}
