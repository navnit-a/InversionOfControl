using System;
using Ninject;

namespace IoC.Container.Ninjec
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var kernel = new StandardKernel();

            var kernel = new StandardKernel(new MyModule());
            
            //kernel.Bind<ICreditCard>().To<MasterCard>().Named("Visa");
            
            //kernel.Bind<ICreditCard>().To<MasterCard>();
            
            //kernel.Bind<ICreditCard>().ToMethod(x =>
            //{
            //    Console.WriteLine(
            //        $"Creating Master Card..{DateTime.Now.ToShortDateString()}");
            //    return new MasterCard();
            //});

            // In Singleton
            //kernel.Bind<ICreditCard>().To<MasterCard>().InSingletonScope();

            //ICreditCard card = kernel.Get<ICreditCard>("Visa");

            // Rebind
            //kernel.Rebind<ICreditCard>().To<Visa>();

            var shopper = kernel.Get<Shopper>();
            shopper.Charge();
            Console.WriteLine(shopper.ChargesForCurrentCart);

            var shopper2 = kernel.Get<Shopper>();
            shopper2.Charge();
            Console.WriteLine(shopper2.ChargesForCurrentCart);

            Console.Read();
        }
    }
}