using System;

namespace BirdsFlyingAroundApp
{
    public class Penguin : Bird
    {
        public override void SetLocation(double longitude, double latitude)
        {
            //sæt en lokation
        }

        public override void SetAltitude(double altitude)
        {
            //Denne metode vil aldrig blive implementeret for en pingvin
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            //Denne metode tegner én pingvin
        }

    }
}