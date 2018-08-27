using System;
using System.Collections.Generic;
using NUnit.Framework;
using WindowsGame.Common;
using WindowsGame.Common.Objects;

namespace WindowsGame.SystemTests.Common.Managers
{
	[TestFixture]
	public class TextManagerSystemTests : BaseSystemTests
	{
		[SetUp]
		public void SetUp()
		{
			// System under test.
			TextManager = MyGame.Manager.TextManager;
			TextManager.Initialize(CONTENT_ROOT);
		}

		[Test]
		public void LoadTextDataTest()
		{
			IList<TextData> textDataList = TextManager.LoadTextData("LevelScreen", 20, 0, -1.0f, -4.0f);
			Assert.That(textDataList, Is.Not.Null);
			ShowTextDataList(textDataList);
		}

		private static void ShowTextDataList(IEnumerable<TextData> textDataList)
		{
			foreach (TextData textData in textDataList)
			{
				Console.WriteLine(textData.Text);
			}
		}

		[TearDown]
		public void TearDown()
		{
			TextManager = null;
		}

	}
}