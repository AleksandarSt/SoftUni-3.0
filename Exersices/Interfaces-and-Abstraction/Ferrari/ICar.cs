namespace Ferrari
{
    public interface ICar
    {
        string Driver { get; }

        string Model { get; }

        void Brakes();

        void Gas();
    }
}
