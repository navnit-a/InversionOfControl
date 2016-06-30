namespace IoC.Container.Ninjec
{
    public interface ICreditCard
    {
        string Charge();

        int ChargeCount { get; }
    }
}