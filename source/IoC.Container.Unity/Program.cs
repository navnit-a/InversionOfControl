using System;
using Microsoft.Practices.Unity;

namespace IoC.Container.Unity
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var container = new UnityContainer();
            //container.RegisterType<ICreditCard, MasterCard>();

            // Using a singleton
            container.RegisterType<ICreditCard, MasterCard>( new ContainerControlledLifetimeManager());

            // Setter injection
            //container.RegisterType<ICreditCard, MasterCard>(new InjectionProperty("ChargeCount", 5));

            //var shopper = container.Resolve<Shopper>(new ParameterOverride("creditCard", new Visa())); // override

            var shopper1 = container.Resolve<Shopper>();
            shopper1.Charge();
            Console.WriteLine(shopper1.ChargesForCurrentCart);

            var shopper2 = container.Resolve<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCart);

            Console.Read();

            //container.RegisterType<ICreditCard, Visa>("BackCard");
            //var card = new MasterCard();
            //container.RegisterInstance(card);
        }

    }
}