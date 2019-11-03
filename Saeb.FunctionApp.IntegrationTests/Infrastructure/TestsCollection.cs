using Xunit;

namespace Saeb.FunctionApp.IntegrationTests
{
	[CollectionDefinition(Name)]
	public class TestsCollection : ICollectionFixture<TestHost>
	{
		public const string Name = nameof(TestsCollection);
	}
}
