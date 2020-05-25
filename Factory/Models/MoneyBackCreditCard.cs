namespace Factory.Models
{
    // concrete product
    public class MoneyBackCreditCard : CreditCard
    {
        private readonly string _creditType;   
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _creditType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override string CardType {
            get => _creditType;
        }

        public override int CreditLimit { 
            get => _creditLimit; set => _creditLimit = value;
        }
        public override int AnnualCharge { 
            get => _annualCharge; set => _annualCharge = value;
        }
    }
}