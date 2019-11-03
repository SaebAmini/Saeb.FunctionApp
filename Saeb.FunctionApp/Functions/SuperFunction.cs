using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Saeb.FunctionApp.Domain;

namespace Saeb.FunctionApp
{
	public class SuperFunction
	{
		readonly IHitchhikerGuideToTheGalaxy _hitchhikerGuideToTheGalaxy;

		public SuperFunction(IHitchhikerGuideToTheGalaxy hitchhikerGuideToTheGalaxy)
		{
			_hitchhikerGuideToTheGalaxy = hitchhikerGuideToTheGalaxy;
		}

		[FunctionName(nameof(AnswerToLifeTheUniverseAndEverything))]
		public IActionResult AnswerToLifeTheUniverseAndEverything(
			[HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequest req)
		{
			return new OkObjectResult(_hitchhikerGuideToTheGalaxy.GetTheAnswerToLifeTheUniverseAndEverything());
		}
	}
}
