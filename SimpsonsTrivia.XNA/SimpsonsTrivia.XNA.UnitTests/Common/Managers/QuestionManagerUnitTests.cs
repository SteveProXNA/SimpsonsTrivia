using System;
using NUnit.Framework;
using WindowsGame.Common.Managers;
using WindowsGame.Common.Objects;

namespace WindowsGame.UnitTests.Common.Managers
{
	[TestFixture]
	public class QuestionManagerUnitTests : BaseUnitTests
	{
		[SetUp]
		public new void SetUp()
		{
			QuestionManager = new QuestionManager();
		}

		[Test]
		public void LoadQuestionDataTest()
		{
			// Arrange.
			const String line = "3;WHICH OF THE FOLLOWING|CHARACTERS IS A NON-SMOKER?;KRUSTY;NELSON;GRAMPA SIMPSON;MRS. KRABAPPLE;page01;02-GeneralSimpsonsTrivia.csv";

			// Act.
			Question question = QuestionManager.LoadQuestion(line);

			// Assert.
			Assert.That(question, Is.Not.Null);
		}

		[TearDown]
		public void TearDown()
		{
			QuestionManager = null;
		}

	}
}