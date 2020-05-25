namespace Factory.Models
{
    // concrete product
    public class PlatinumCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;
        public PlatinumCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType{
            get => _cardType;
        }

        public override int CreditLimit{
            get => _creditLimit; set => _creditLimit = value;
        }

        public override int AnnualCharge{
            get => _annualCharge; set => _annualCharge = value;
        }
    }
}