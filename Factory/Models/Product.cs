namespace Factory.Models
{
    public abstract class Product
    {
        public abstract string CardType { get;}
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }
    }
}