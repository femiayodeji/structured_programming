namespace Factory.Models
{
    public class TitaniumCardFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;
        
        public TitaniumCardFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard(){
            return new TitaniumCreditCard(_creditLimit, _annualCharge);
        }
    }
}