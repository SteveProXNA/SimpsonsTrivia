using System.Reflection;
using WindowsGame.Common;
using NUnit.Framework;

namespace WindowsGame.SystemTests.TheGame
{
	[TestFixture]
	public class GameManagerTests : BaseSystemTests
	{
		[Test]
		public void RegistrationTest()
		{
			var manager = MyGame.Manager;
			var properties = manager.GetType().GetProperties();
			foreach (PropertyInfo property in properties)
			{
				object obj = property.GetValue(manager, null);
				Assert.That(obj, Is.Not.Null, property.ToString());
			}
		}

	}
}