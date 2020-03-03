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
            contestant.registrationNumber = UserInterface.GetUserInputInt("Enter contestant's REGISTRATION NUMBER, then press enter:  ");
            contestant.firstName = UserInterface.GetUserInputString ("Enter FIRST NAME of contestant, then hit enter: ");
            contestant.lastName= UserInterface.GetUserInputString("Enter LAST NAME of contestant, then hit enter: ");
            contestant.emailAddress = UserInterface.GetUserInputString("Enter contestant's EMAIL ADDRESS, then hit enter: ");

            contestants.Add(contestant.registrationNumber, contestant);
           
            
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
        public void PrintContestantList()
        {
            foreach (KeyValuePair<int, Contestant> pair in contestants)
            {
                Console.WriteLine("Registration#:  "+pair.Value.registrationNumber+"  Name:  "+pair.Value.firstName+" "+pair.Value.lastName+"  "+pair.Value.emailAddress+"");

            }
        }

    }
}
