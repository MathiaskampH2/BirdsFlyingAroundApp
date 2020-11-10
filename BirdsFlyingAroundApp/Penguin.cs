using System;

namespace BirdsFlyingAroundApp
{

    /// <summary>
    /// Penguin class inherits from Bird
    /// overrides Bird's methods to math it's own
    /// </summary>
    public class Penguin : Bird
    {
        public override string MakeSound()
        {
            return "I make a growl sound";
        }

        public override string Eat()
        {
            return "I eat fish";
        }
    }
}