using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Saeb.FunctionApp.Domain;
using Shouldly;
using Xunit;

namespace Saeb.FunctionApp.IntegrationTests
{
	[Collection(TestsCollection.Name)]
	public class SuperFunctionTests
	{
		readonly SuperFunction _sut;

		public SuperFunctionTests(TestHost testHost)
		{
			_sut = new SuperFunction(testHost.ServiceProvider.GetRequiredService<IHitchhikerGuideToTheGalaxy>());
		}

		[Fact]
		public void Test()
		{
			// arrange
			var req = new DefaultHttpRequest(new DefaultHttpContext());

			// act
			var result = (OkObjectResult)_sut.AnswerToLifeTheUniverseAndEverything(req);

			// assert
			result.Value.ShouldBe(42);
		}
	}
}
