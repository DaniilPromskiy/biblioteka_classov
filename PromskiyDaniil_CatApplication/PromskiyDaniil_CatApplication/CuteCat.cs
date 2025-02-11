using System;

namespace PromskiyDaniil_CatFramework
{
    public class CuteCat : Cat
    {
        private int fluffiness;

        public override int Fluffiness => fluffiness;

        public CuteCat(int fluffiness = 55)
        {
            if (fluffiness < 1 || fluffiness > 100)
                throw new CatException($"Unable to create a cute cat with fluffiness: {fluffiness}");

            this.fluffiness = fluffiness;
        }

        public override string FluffinessCheck()
        {
            if (Fluffiness == 1) return "Sphynx";
            if (Fluffiness <= 30) return "Slightly";
            if (Fluffiness <= 45) return "Medium";
            if (Fluffiness <= 85) return "Heavy";
            return "may";
        }

        public override string ToString()
        {
            return $"A cute cat with fluffiness: {Fluffiness}";
        }
    }
}