using System.Collections.Generic;
using System.Linq;

namespace FennisForge.Demo
{
    public class Actor
    {
        public List<IStat> Stats { get; set; }

        public List<Feature> Features { get; set; }

        public object GetStatValue(string name)
        {
            var value = Stats.Single(x => x.Name == name).GetValue();
         
            foreach(var feature in Features)
            {
                value = GetNewValue(feature, value, name);
            }

            return value;
        }

        public static object GetNewValue(IFeature rootFeature, object value, string name)
        {
            var newValue = value;
            var stat = rootFeature.Stats.SingleOrDefault(x => x.Name == name).GetValue();

            if (stat != null)
            {
                // add to newValue
            }

            foreach (var feature in rootFeature.Features)
            {
                newValue = GetNewValue(feature, newValue, name);
            }

            return newValue;
        }
    }
}
