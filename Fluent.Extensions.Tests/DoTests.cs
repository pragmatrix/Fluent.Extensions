using NUnit.Framework;

namespace Fluent.Extensions.Tests
{
	[TestFixture]
	public class DoTests
	{
		[Test]
		public void DoIsCanBeUsedWithoutAUsingAndReturnsTheCorrectInstance()
		{
			var value = 0;

			10
				.Do(v => value += v)
				.Do(v => value *= v);

			Assert.That(value, Is.EqualTo(100));
		}
	}
}
