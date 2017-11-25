using System.Collections.Generic;

namespace FennisForge.Demo
{
    public interface IFeature
    {
        List<IStat> Stats { get; }

        List<IFeature> Features { get; }

        List<string> FeatureNotes { get; }

        List<IAction> Actions { get; }
    }
}
