namespace BirdsFlyingAroundApp
{
    public abstract class Bird
    {
        // These methods doesn't give any sense. Due to the bird not knowing its location as its gets born.
        //public abstract void SetLocation(double longitude, double latitude);
        //public abstract void SetAltitude(double altitude);

        public abstract string MakeSound();

        public abstract string Eat();

    }
}