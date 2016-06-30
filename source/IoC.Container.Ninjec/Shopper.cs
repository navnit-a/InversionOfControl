namespace IoC.Container.Ninjec
{
    public class Shopper
    {
        private readonly ICreditCard _creditCard;

        public Shopper(ICreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        public int ChargesForCurrentCart
        {
            get { return _creditCard.ChargeCount; }
        }

        public void Charge()
        {
            var chargeMessage = _creditCard.Charge();
            System.Console.WriteLine(chargeMessage);
        }
    }
}