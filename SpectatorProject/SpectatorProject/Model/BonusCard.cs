using System;
using System.Collections.Generic;
using System.Text;

namespace SpectatorProject.Model
{
    class BonusCard
    {

        private float balance;
        private string cardNumber;
        private Status cardStatus;

        public BonusCard(float balance, string cardNumber, Status cardStatus)
        {
            this.balance = balance;
            this.cardNumber = cardNumber;
            this.cardStatus = cardStatus;
        }

        public bool Usable
        {

            get
            {
                if (balance > 0 && cardStatus == Status.Active)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public override string ToString()
        {

            string result = "\nBonusz kártya adatai:";
            result += "\nBonusz kártya kártyaszáma: " + cardNumber;
            result += "\nBonusz kártya egyenlege: " + balance;
            if (Usable)
            {
                result += "\nA bonusz kártya használható";
            }
            else
            {
                result += "\nA bonusz kártya nem használható";
            }
            return result;
        }
    }























}
