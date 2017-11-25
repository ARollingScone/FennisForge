using System.Collections.Generic;

namespace FennisForge.Demo.Dragonborn
{
    public class DragonbornRace : Feature
    {
        public DragonbornRace()
        {
            Stats = new List<IStat>
            {
                new Stat<int>("Strength", 2),
                new Stat<int>("Charisma", 1)
            };

            Features = new List<IFeature>
            {
                // Draconic Ancestry
                // Damage Resistance
                new BreathWeapon()
            };
        }
    }
}
