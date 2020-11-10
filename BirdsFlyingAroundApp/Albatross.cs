namespace BirdsFlyingAroundApp
{
    public class Albatross:Bird, ICanFly
    {
        public override void SetLocation(double longitude, double latitude)
        {
            throw new System.NotImplementedException();
        }

        public override void SetAltitude(double altitude)
        {
            throw new System.NotImplementedException();
        }

        public override void Draw()
        {
            throw new System.NotImplementedException();
        }

        public string BirdCanFly()
        {
            return "I'm an albatross and i can fly";
        }
    }
}