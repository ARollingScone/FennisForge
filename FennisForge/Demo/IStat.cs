namespace FennisForge.Demo
{
    public interface IStat
    {
        string Name { get; }

        object GetValue();
    }
}
