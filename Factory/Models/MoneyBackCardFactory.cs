namespace Factory.Models
{
    // concrete creator
    public class MoneyBackCardFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard(){
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
    }
}