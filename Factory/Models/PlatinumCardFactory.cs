namespace Factory.Models
{
    public class PlatinumCardFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public PlatinumCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard(){
            return new PlatinumCreditCard(_creditLimit, _annualCharge);
        }
    }
}