using System.Collections.Generic;

namespace FennisForge.Demo.Dragonborn
{
    public class BreathWeapon : Feature
    {
        public BreathWeapon()
        {
            Actions = new List<IAction>
            {
                new Attack
                {
                    HitType = new SaveHit("Dexerity"),
                    Target = HitTarget.Cone,
                    HitRange = 5
                }
            };
        }
    }
}
