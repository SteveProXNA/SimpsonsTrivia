using System;
using NUnit.Framework;
using WindowsGame.Common;
using WindowsGame.Common.Managers;
using WindowsGame.Common.Static;
using WindowsGame.Common.TheGame;
using WindowsGame.Master.Interfaces;
using WindowsGame.Master.IoC;
using WindowsGame.SystemTests.Master.Implementation;

namespace WindowsGame.SystemTests
{
	public abstract class BaseSystemTests
	{
		protected IButtonManager ButtonManager;
		protected IConfigManager ConfigManager;
		protected IContentManager ContentManager;
		protected IImageManager ImageManager;
		protected IInputManager InputManager;
		protected IQuestionManager QuestionManager;
		protected IRandomManager RandomManager;
		protected IResolutionManager ResolutionManager;
		protected IScoreManager ScoreManager;
		protected IScreenManager ScreenManager;
		protected ISoundManager SoundManager;
		protected ITextManager TextManager;
		protected IThreadManager ThreadManager;
		protected IFileManager FileManager;
		protected ILogger Logger;

		// mklink /D C:\SimpsonsTrivia.XNA.Content  C:\SVN\SimpsonsTrivia\SimpsonsTrivia.XNA\SimpsonsTrivia.XNA\SimpsonsTrivia.XNA\bin\x86\Debug\
		protected const String CONTENT_ROOT = @"C:\SimpsonsTrivia.XNA.Content\";

#pragma warning disable 618
		[TestFixtureSetUp]
#pragma warning restore 618
		public void TestFixtureSetUp()
		{
			Registration.Initialize();
			IoCContainer.Initialize<IFileProxy, TestFileProxy>();

			IGameManager manager = GameFactory.Resolve();
			MyGame.Construct(manager);
		}

#pragma warning disable 618
		[TestFixtureTearDown]
#pragma warning restore 618
		public void TestFixtureTearDown()
		{
			GameFactory.Release();
		}

	}
}