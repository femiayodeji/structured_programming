namespace Factory.Models
{
    // concrete product
    public class TitaniumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCHarge;
        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
         _cardType = "Titanium";
         _creditLimit = creditLimit;
         _annualCHarge = annualCharge;   
        }

        public override string CardType{
            get => _cardType;
        }

        public override int CreditLimit{
            get => _creditLimit; set => _creditLimit = value;
        }

        public override int AnnualCharge{
            get => _annualCHarge; set => _annualCHarge = value;
        }
    }
}