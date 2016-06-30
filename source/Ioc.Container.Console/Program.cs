namespace Ioc.Container.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var resolver = new Resolver();
            resolver.Register<Shopper, Shopper>();
            //resolver.Register<ICreditCard, MasterCard>();
            resolver.Register<ICreditCard, Visa>();

            var shopper = resolver.Resolve<Shopper>();
            shopper.Charge();
        }
    }
}