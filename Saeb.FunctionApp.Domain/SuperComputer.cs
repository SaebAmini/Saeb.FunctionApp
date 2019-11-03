namespace Saeb.FunctionApp.Domain
{
    public interface ISuperComputer
    {
        int CalculateTheAnswerToLifeTheUniverseAndEverything();
    }

    public class SuperComputer : ISuperComputer
    {
        public int CalculateTheAnswerToLifeTheUniverseAndEverything() => 42;
    }
}
