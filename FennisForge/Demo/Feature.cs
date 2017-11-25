using System.Collections.Generic;

namespace FennisForge.Demo
{
    public class Feature : IFeature
    {
        public List<IStat> Stats { get; set; }

        public List<IFeature> Features { get; set; }

        public List<string> FeatureNotes { get; set; } 

        public List<IAction> Actions { get; set; }
    }
}
