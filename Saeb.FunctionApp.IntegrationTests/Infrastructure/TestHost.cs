using System;
using System.IO;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs.Host.Bindings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Saeb.FunctionApp.IntegrationTests
{
	public class TestHost
	{
		public TestHost()
		{
			var startup = new TestStartup();
			var host = new HostBuilder()
				.ConfigureWebJobs(startup.Configure)
				.ConfigureServices(ReplaceTestOverrides)
				.Build();

			ServiceProvider = host.Services;
		}

		public IServiceProvider ServiceProvider { get; }

		private void ReplaceTestOverrides(IServiceCollection services)
		{
			// services.Replace(new ServiceDescriptor(typeof(ServiceToReplace), testImplementation));
		}

		private class TestStartup : Startup
		{
			public override void Configure(IFunctionsHostBuilder builder)
			{
				SetExecutionContextOptions(builder);
				base.Configure(builder);
			}

			private static void SetExecutionContextOptions(IFunctionsHostBuilder builder)
			{
				builder.Services.Configure<ExecutionContextOptions>(o => o.AppDirectory = Directory.GetCurrentDirectory());
			}
		}
	}
}
