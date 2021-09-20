using System;
using System.Collections.Generic;
using System.Text;

namespace SpectatorProject.Model
{
    /// <summary>
    /// Kredit kártya osztály
    /// </summary>
    class CreditCard
    {
        private DateTime expiredDate;
        private string cardNumber;

        public CreditCard(DateTime expiredDate, string cardNumber)
        {
            this.expiredDate = expiredDate;
            this.cardNumber = cardNumber;
        }

        public DateTime ExpiredDate { get => expiredDate; set => expiredDate = value; }
        public string CardNumber { get => cardNumber; set => cardNumber = value; }

        public bool Expired
        {
            get
            {
                if (expiredDate < DateTime.Now)
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
            string result = "\nHitelkártya adatai: ";
            result += "Hitelkártya kártyaszáma: " + cardNumber;
            result += "\nLejárati dátum:" + expiredDate;

            if (Expired)
            {
                result += "\nA kártya lejárt";
            }
            else
            {
                result += "\nA kártya aktív";
            }
            return result;
        }
    }

}