using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Fluent.Extensions.Tests
{
	[TestFixture]
	class AutoFluentTests
	{
		[Test]
		public void DemoteSender()
		{
			var res = "";
			Action<string, string> a = (str1, str2) => { res = str1 + str2; };
			Action<object, string> demoted = a.DemoteSender();

			demoted("a", "b");
			Assert.That(res, Is.EqualTo("ab"));
		}
	}
}
