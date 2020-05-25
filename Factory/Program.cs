using System;
using Factory.Models;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACTORY DESIGN PATERN\n");

            CardFactory factory = null;
            CreditCard creditCard = null;
            
            //MoneyBack
            factory = new MoneyBackFactory(5000,0);
            creditCard = factory.GetCreditCard();
            Console.WriteLine("Card Type: {0} \nCredit Limit: {1} \nAnnual Charge: {2}", creditCard.CardType, creditCard.CreditLimit,creditCard.AnnualCharge);

            Console.WriteLine("--------------");
            
            //Titanium
            factory = new TitaniumFactory(10000,500);
            creditCard = factory.GetCreditCard();
            Console.WriteLine("Card Type: {0} \nCredit Limit: {1} \nAnnual Charge: {2}", creditCard.CardType, creditCard.CreditLimit,creditCard.AnnualCharge);

            Console.WriteLine("--------------");
            
            //Platinum
            factory = new PlatinumFactory(500000,1000);
            creditCard = factory.GetCreditCard();
            Console.WriteLine("Card Type: {0} \nCredit Limit: {1} \nAnnual Charge: {2}", creditCard.CardType, creditCard.CreditLimit,creditCard.AnnualCharge);
        }
    }
}
