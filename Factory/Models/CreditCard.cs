namespace Factory.Models
{
    public abstract class CreditCard
    {
        public abstract string CardType { get;}
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}