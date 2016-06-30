namespace Ioc.Container.Console
{
    public class Shopper
    {
        private readonly ICreditCard _creditCard;

        public Shopper(ICreditCard creditCard)
        {
            _creditCard = creditCard;
        }

        public void Charge()
        {
            var chargeMessage = _creditCard.Charge();
            System.Console.WriteLine(chargeMessage);
        }
    }
}