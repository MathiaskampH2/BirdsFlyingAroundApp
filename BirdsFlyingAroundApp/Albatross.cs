namespace BirdsFlyingAroundApp
{
    /// <summary>
    /// Albatross class is a subclass of Bird class
    /// Inherits from both Bird and ICanFly
    /// Overrides Bird's methods
    /// </summary>
    public class Albatross : Bird, ICanFly
    {
        public string BirdCanFly()
        {
            return "I can fly";
        }

        public override string MakeSound()
        {
            return "I make a whining, squeaking, grunting, and moaning sound";
        }

        public override string Eat()
        {
            return "I eat fish";
        }
    }
}