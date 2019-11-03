namespace Saeb.FunctionApp.Domain
{
	public interface ISuperComputer
	{
		int CalculateTheAnswerToLifeTheUniverseAndEverything();
	}

	public class SuperComputer : ISuperComputer
	{
		readonly SuperComputerSettings _superComputerSettings;

		public SuperComputer(SuperComputerSettings superComputerSettings)
		{
			_superComputerSettings = superComputerSettings;
		}

		public int CalculateTheAnswerToLifeTheUniverseAndEverything() => _superComputerSettings.TheAnswerToLifeTheUniverseAndEverything;
	}
}
