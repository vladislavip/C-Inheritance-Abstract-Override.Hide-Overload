using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class LeoBank:AbstractBank
    {
        public override string cardNameAndSurname { get; protected set; }

        public override string cardCode { get; protected set; }
        public override int CVV { get; protected set; }

        public override double cardBalance { get; protected set; }

        public LeoBank(string cardNameAndSurname, string cardCode, int CVV, double cardBalance) : base(cardNameAndSurname, cardCode, CVV, cardBalance)
        {

            this.cardNameAndSurname = cardNameAndSurname;
            this.cardCode = cardCode;
            this.CVV = CVV;
            this.cardBalance = cardBalance;


        }


        public override double cardPlus( double increment)
        {
            double newValue = this.cardBalance - increment;
            this.cardBalance = newValue;
            return newValue;
        }


        public override double cardMinus( double decrement)
        {
            double newValue = this.cardBalance - decrement;
            this.cardBalance = newValue;
            return newValue;

        }
    }
}

