using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal abstract class AbstractBank
    {

        public abstract string cardNameAndSurname { get; protected set; }

        public abstract string cardCode  { get; protected set; }
        public abstract int CVV { get; protected set; }

        public abstract double  cardBalance { get; protected set; }

        public AbstractBank(string cardNameAndSurname, string cardCode, int CVV, double cardBalance)
        {

            this.cardNameAndSurname = cardNameAndSurname;
            this.cardCode = cardCode;
            this.CVV = CVV;
            this.cardBalance = cardBalance;


        }




        public abstract double  cardPlus( double cardBalance);

        public abstract double cardMinus( double cardBalance);



    }
}
