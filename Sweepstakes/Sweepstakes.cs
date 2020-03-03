using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;

        //Variables

        private string name;

        //name property
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Constructor

        public Sweepstakes()
        {
            name = "";


        }

        //Methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = UserInterface.GetUserInputInt("Enter contestant's REGISTRATION NUMBER, then press enter:  ");
            contestant.FirstName = UserInterface.GetUserInputString ("Enter FIRST NAME of contestant, then hit enter: ");
            contestant.LastName= UserInterface.GetUserInputString("Enter LAST NAME of contestant, then hit enter: ");
            contestant.EmailAddress = UserInterface.GetUserInputString("Enter contestant's EMAIL ADDRESS, then hit enter: ");

            contestants.Add(contestant.RegistrationNumber, contestant);
           
            
        }
        public Contestant ChooseContestWinner(Contestant contestant,Random rnd)
        {
            List<Contestant> sweepstakesList = new List<Contestant>();
            foreach (KeyValuePair<int, Contestant> pair in contestants)
            {
                sweepstakesList.Add(pair.Value);

            }
            
            Contestant sweepstakesWinner = sweepstakesList[rnd.Next(0, sweepstakesList.Count)];

            return sweepstakesWinner;
        }
        public void PrintContestantList(Contestant contestant)
        {
            foreach (KeyValuePair<int, Contestant> pair in contestants)
            {
                Console.WriteLine("Registration#:  "+contestant.RegistrationNumber+"  Name:  "+contestant.FirstName+" "+contestant.LastName+"  "+contestant.EmailAddress+"");

            }
        }

    }
}
