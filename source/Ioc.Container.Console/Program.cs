using System;
using System.Threading;

namespace Ioc.Container.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //ICreditCard creditCard = new MasterCard();
            //ICreditCard otherCreditCard = new Visa();

            Resolver resolver = new Resolver();
            int count = 1000;
            while (count != 0)
            {
                Shopper shopper = new Shopper(resolver.ResolveCreditCard());
                shopper.Charge();
                count--;
                Thread.Sleep(200);
            }
        }
    }
}

public class Resolver
{
    public ICreditCard ResolveCreditCard()
    {
        var random = new Random().Next(2);
        Console.WriteLine(random);
        if (random == 1)
        {
            return new Visa();
        }
        return new MasterCard();
    }
}

public class Visa : ICreditCard
{
    public string Charge()
    {
        return "Charging with the visa";
    }
}

public class MasterCard : ICreditCard
{
    public string Charge()
    {
        return "Swiping the Master Card";
    }
}

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
        Console.WriteLine(chargeMessage);
    }
}

public interface ICreditCard
{
    string Charge();
}