using System;
using NUnit.Framework;
using WindowsGame.Common;
using WindowsGame.Common.Static;

namespace WindowsGame.SystemTests.Common.Managers
{
	[TestFixture]
	public class QuestionManagerSystemTests : BaseSystemTests
	{
		[SetUp]
		public void SetUp()
		{
			QuestionManager = MyGame.Manager.QuestionManager;
			QuestionManager.Initialize(CONTENT_ROOT);
		}

		[Test]
		public void LoadQuestionListTest()
		{
			// Arrange.
			const DifficultyType type = DifficultyType.Easy;

			// Act.
			QuestionManager.LoadQuestionList(type);

			// Assert.
			Console.WriteLine("Number Questions: " + QuestionManager.QuestionList.Count);
		}

		[Test]
		public void RandomizeQuestionListTest()
		{
			// Arrange.
			MyGame.Manager.RandomManager.Initialize();
			QuestionManager.LoadQuestionList(DifficultyType.Easy);

			// Act.
			QuestionManager.RandomizeQuestionList();

			// Assert.
			Console.WriteLine("Number Questions: " + QuestionManager.QuestionList.Count);
		}


		[TearDown]
		public void TearDown()
		{
			QuestionManager = null;
		}

	}
}