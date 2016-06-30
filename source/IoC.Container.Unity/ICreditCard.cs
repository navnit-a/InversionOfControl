namespace IoC.Container.Unity
{
    public interface ICreditCard
    {
        string Charge();

        int ChargeCount { get; }
    }
}