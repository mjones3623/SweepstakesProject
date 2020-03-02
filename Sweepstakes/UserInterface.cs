using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        public static string GetFirstNameInput(Contestant contestant)
        {
            Console.WriteLine("Enter FIRST NAME of contestant, then hit enter: ");
            contestant.firstName = Console.ReadLine();
                                   
            return contestant.firstName;
        }
        public static string GetLastNameInput(Contestant contestant)
        {
            Console.WriteLine("Enter LAST NAME of contestant, then hit enter: ");
            contestant.lastName = Console.ReadLine();
            return contestant.lastName;
        }
        public static string GetEmailAddressInput(Contestant contestant)
        {
            Console.WriteLine("Enter the contestant's EMAIL ADDRESS, then hit enter: ");
            contestant.emailAddress = Console.ReadLine();
            return contestant.emailAddress;
        }
        public static int GetRegistrationNumberInput(Contestant contestant)
        {
            Console.WriteLine("Enter the contestant's REGISTRATION NUMBER, then hit enter: ");
            contestant.registrationNumber = Int32.Parse(Console.ReadLine());
            return contestant.registrationNumber;
        }


    }
}
