namespace IoC.Container.Ninjec
{
    public class MasterCard : ICreditCard
    {
        public string Charge()
        {
            ChargeCount++;
            return "Swiping the Master Card";
        }

        public int ChargeCount { get; set; }
    }
}