using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Saeb.FunctionApp.Domain;
using Xunit;

namespace Saeb.FunctionApp.IntegrationTests
{
    public class SuperFunctionTests
    {
        readonly SuperFunction _sut;

        public SuperFunctionTests()
        {
            var startup = new Startup();
            var host = new HostBuilder()
                .ConfigureWebJobs(startup.Configure)
                .Build();

            _sut = new SuperFunction(host.Services.GetRequiredService<IHitchhikerGuideToTheGalaxy>());
        }

        [Fact]
        public void Test()
        {
            // arrange
            var req = new DefaultHttpRequest(new DefaultHttpContext());

            // act
            var result = (OkObjectResult)_sut.AnswerToLifeTheUniverseAndEverything(req);

            // assert
            Assert.Equal(42, result.Value);
        }
    }
}
