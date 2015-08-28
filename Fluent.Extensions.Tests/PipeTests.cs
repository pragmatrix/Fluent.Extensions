using NUnit.Framework;

namespace Fluent.Extensions.Tests
{
	[TestFixture]
	class PipeTests
	{
		[Test]
		public void Pipe()
		{
			var res = 10.Pipe(a => a*a);
			Assert.That(res, Is.EqualTo(100));
		}
	}
}
