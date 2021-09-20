using SpectatorProject.Model;
using System;
using System.Globalization;
using System.Threading;

namespace SpectatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Name name = new Name("Látó", "László");
            Console.WriteLine("Teljes név tulajdonság: " + name.Fullname);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            DateTime dt = new DateTime(2022, 3, 15);
            string dateString = dt.ToString();
            CreditCard creditCard = new CreditCard(dt, "11");
            if (creditCard.Expired)
            {
                Console.WriteLine("Lejárat tulajdonság: Lejárt.");
            }
            else
            {
                Console.WriteLine("Lejárat tulajdonság: Érvényes.");
            }
            Status status = Status.Active;
            BonusCard bonusCard = new BonusCard(30000, "12", status);
            Spectator viewer = new Spectator(name, creditCard, bonusCard);
            if (bonusCard.Usable)
            {
                Console.WriteLine("A bonuszkártya használható:");
            }

            Console.WriteLine(viewer);
        }

    }
}
