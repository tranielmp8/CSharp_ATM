using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardHolder
    {
        public string CardNum { get; set; } = "";
        public int Pin { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public double Balance { get; set; } 

        public CardHolder(string CardNum, int Pin, string FirstName, string LastName, double Balance) 
        {
            this.CardNum = CardNum;
            this.Pin=Pin;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Balance = Balance;
        }


    }
}
