using FennisForge.Demo.Dragonborn;
using System.Collections.Generic;

namespace FennisForge.Demo
{
    public static class PlayerCharacterFactory
    {
        public static Actor GetBasePlayerCharacter()
        {
            return new Actor
            {
                Stats = new List<IStat>
                {
                    new Stat<int>("Strength", 10),
                    new Stat<int>("Constitution", 10),
                    new Stat<int>("Dexerity", 10),
                    new Stat<int>("Intelligence", 10),
                    new Stat<int>("Wisdom", 10),
                    new Stat<int>("Charisma", 10)
                },

                Features = new List<Feature>
                {
                    new DragonbornRace()
                }
            };
        }
    }
}
