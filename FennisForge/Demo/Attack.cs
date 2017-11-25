using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FennisForge.Demo
{
    public interface IAction
    {

    }

    public enum HitTarget
    {
        Self,
        Creature,
        Cone,
        Circle,
        Other
    }

    public interface IHitType {}

    public class AcHitType : IHitType
    {

    }

    public class SaveHit : IHitType
    {
        public SaveHit(string statName) { }
    }

    public class Attack : IAction
    {
        public IHitType HitType { get; set; }

        public HitTarget Target { get; set; }

        public int HitRange { get; set; }
    }
}
