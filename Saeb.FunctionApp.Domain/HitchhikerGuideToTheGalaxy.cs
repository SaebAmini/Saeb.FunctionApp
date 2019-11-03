namespace Saeb.FunctionApp.Domain
{
	public interface IHitchhikerGuideToTheGalaxy
	{
		int GetTheAnswerToLifeTheUniverseAndEverything();
	}

	public class HitchhikerGuideToTheGalaxy : IHitchhikerGuideToTheGalaxy
	{
		readonly ISuperComputer _superComputer;

		public HitchhikerGuideToTheGalaxy(ISuperComputer superComputer)
		{
			_superComputer = superComputer;
		}

		public int GetTheAnswerToLifeTheUniverseAndEverything() => _superComputer.CalculateTheAnswerToLifeTheUniverseAndEverything();
	}
}
