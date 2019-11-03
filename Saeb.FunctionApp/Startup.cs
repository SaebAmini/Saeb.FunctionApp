using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Saeb.FunctionApp;
using Saeb.FunctionApp.Domain;

[assembly: FunctionsStartup(typeof(Startup))]

namespace Saeb.FunctionApp
{
	public class Startup : FunctionsStartup
	{
		public IConfiguration Configuration { get; private set; }

		public override void Configure(IFunctionsHostBuilder builder)
		{
			InitializeConfiguration(builder);

			builder.Services.AddSingleton(Configuration.Get<SuperComputerSettings>());

			builder.Services.AddTransient<IHitchhikerGuideToTheGalaxy, HitchhikerGuideToTheGalaxy>();
			builder.Services.AddTransient<ISuperComputer, SuperComputer>();
		}

		private void InitializeConfiguration(IFunctionsHostBuilder builder)
		{
			var executionContextOptions = builder
				.Services
				.BuildServiceProvider()
				.GetService<IOptions<ExecutionContextOptions>>()
				.Value;

			Configuration = new ConfigurationBuilder()
				.SetBasePath(executionContextOptions.AppDirectory)
				.AddJsonFile("appsettings.json")
				.AddEnvironmentVariables()
				.Build();
		}
	}
}
