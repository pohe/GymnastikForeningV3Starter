using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastikForening
{
    public class HoldKatalog
    {
        private List<Hold> holdListe;

        public HoldKatalog()
        {
            holdListe = new List<Hold>();
        }

        public void TilføjHold(Hold hold) // der må ikke være dubletter
        {
            holdListe.Add(hold);
        }

        public Hold FindHold(string holdId)
        {
            foreach (Hold hold in holdListe)
            {
                if (hold.HoldId == holdId)
                    return hold;
            }
            
            return null;
        }

        public void PrintHoldListe()
        {
            foreach (Hold hold in holdListe)
            {
                Console.WriteLine(hold);
            }
        }

        

        public List<Hold> HentHoldListe(string holdNavn)
        {
            List<Hold> liste = new List<Hold>();
            foreach (Hold hold in holdListe)
            {
                if (hold.HoldNavn == holdNavn)
                {
                    liste.Add(hold);
                }
            }
            return liste; 
        }

        public override string ToString()
        {
            string returString = "";
            foreach (Hold hold in holdListe)
            {
                returString = returString + hold.ToString() + " \n";
            }
            return returString;
        }

        public int SamletAntalDeltagerePåAlleHold()
        {
            int sum = 0;
            
            return sum;

        }

        public int GennemsnitligeDeltagerePrHold()
        {
            int antal = 0;
            return 0;
        }

        public int FlestDeltagerePåHold()
        {
            
            return 0; 
        }

        public Hold HoldMedFlestDeltagere()
        {
            return null;
        }

        public double MaxIndtjenningpåHold(Hold hold)
        {
            
            return 0;
        }

        public Hold HoldMedHøjstIndtjenning()
        {
            return null;
        }

    }
}
