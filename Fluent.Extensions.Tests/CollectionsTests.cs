using System.Collections.Generic;
using NUnit.Framework;

namespace Fluent.Extensions.Tests
{
	[TestFixture]
	public class CollectionsTests
	{
		[Test]
		public void CollectionsDotFluentExtensionsCanBeUsed()
		{
			var l = new List<int>();
			10.AddTo(l);
			CollectionAssert.AreEqual(l, new [] {10});
		}
	}
}
