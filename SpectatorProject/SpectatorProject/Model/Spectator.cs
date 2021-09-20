using System;
using System.Collections.Generic;
using System.Text;

namespace SpectatorProject.Model
{
    class Spectator
    {

        private Name name;
        private CreditCard creditCard;
        private BonusCard bonusCard;

        public Spectator(Name name, CreditCard creditCard, BonusCard bonusCard)
        {
            this.name = name;
            this.creditCard = creditCard;
            this.bonusCard = bonusCard;
        }
        public override string ToString()
        {
            string result = "Néző adatai: ";
            result += "\n" + name + "\n" + creditCard + "\n" + bonusCard;
            return result;
        }

    }
}
