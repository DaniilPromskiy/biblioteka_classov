using System;
using System;

namespace PromskiyDaniil_CatFramework
{
    public class Tiger : Cat
    {
        private double weight;
        private int fluffiness;

        public override int Fluffiness => fluffiness;

        public double Weight => weight;

        public Tiger(double weight, int fluffiness = 150)
        {
            if (weight < 15.0 || weight > 35.0)
                throw new CatException($"Unable to create a tiger with weight: {weight}");
            if (fluffiness < 5 || fluffiness > 85)
                throw new CatException($"Unable to create a tiger with fluffiness: {fluffiness}");

            this.weight = weight;
            this.fluffiness = fluffiness;
        }

        public override string FluffinessCheck()
        {
            return "Ням";
        }

        public override string ToString()
        {
            return $"A tiger with weight: {Weight} fluffiness: {Fluffiness}";
        }
    }
}