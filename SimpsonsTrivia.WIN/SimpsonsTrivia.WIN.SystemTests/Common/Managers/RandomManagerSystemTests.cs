using System;
using NUnit.Framework;
using WindowsGame.Common;

namespace WindowsGame.SystemTests.Common.Managers
{
	[TestFixture]
	public class RandomManagerSystemTests : BaseSystemTests
	{
		[SetUp]
		public void SetUp()
		{
			RandomManager = MyGame.Manager.RandomManager;
			RandomManager.Initialize();
		}

		[Test]
		public void GenerateOneTest()
		{
			Int32 number = RandomManager.Next(10);
			Console.WriteLine("Generate: " + number);
		}

		[Test]
		public void GeneratTwoTest()
		{
			Int32 number = RandomManager.Next(1, 10);
			Console.WriteLine("Generate: " + number);
		}

		[TearDown]
		public void TearDown()
		{
			RandomManager = null;
		}

	}
}