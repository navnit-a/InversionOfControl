namespace Ioc.Container.Console
{
    public class MasterCard : ICreditCard
    {
        public string Charge()
        {
            return "Swiping the Master Card";
        }
    }
}