using System;
using Ninject.Modules;

namespace IoC.Container.Ninjec
{
    public class MyModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ICreditCard>().ToMethod(x =>
            {
                Console.WriteLine(
                    $"Creating Master Card..{DateTime.Now.ToShortDateString()}");
                return new MasterCard();
            });
        }
    }
}