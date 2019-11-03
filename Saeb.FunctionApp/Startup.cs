using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Saeb.FunctionApp;
using Saeb.FunctionApp.Domain;

[assembly: FunctionsStartup(typeof(Startup))]

namespace Saeb.FunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient<IHitchhikerGuideToTheGalaxy, HitchhikerGuideToTheGalaxy>();
            builder.Services.AddTransient<ISuperComputer, SuperComputer>();
        }
    }
}
