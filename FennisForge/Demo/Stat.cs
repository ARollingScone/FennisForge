namespace FennisForge.Demo
{
    public class Stat<T> : IStat
    {
        public string Name { get; }

        public T BaseValue { get; }

        public T TotalValue { get; }

        public Stat(string name, T baseValue)
        {
            Name = name;
            BaseValue = baseValue;
        }

        public object GetValue()
        {
            return BaseValue;
        }
    }
}
