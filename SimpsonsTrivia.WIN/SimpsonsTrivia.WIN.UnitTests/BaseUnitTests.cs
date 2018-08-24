using NUnit.Framework;
using Rhino.Mocks;
using WindowsGame.Common;
using WindowsGame.Common.Managers;
using WindowsGame.Common.TheGame;
using WindowsGame.Master.Interfaces;

namespace WindowsGame.UnitTests
{
	public abstract class BaseUnitTests
	{
		protected IButtonManager ButtonManager;
		protected ICollisionManager CollisionManager;
		protected IConfigManager ConfigManager;
		protected IContentManager ContentManager;
		protected IDeviceManager DeviceManager;
		protected IImageManager ImageManager;
		protected IInputManager InputManager;
		protected IQuestionManager QuestionManager;
		protected IRandomManager RandomManager;
		protected IResolutionManager ResolutionManager;
		protected IScoreManager ScoreManager;
		protected IScreenManager ScreenManager;
		protected ISoundManager SoundManager;
		protected ISpriteManager SpriteManager;
		protected IStorageManager StorageManager;
		protected ITextManager TextManager;
		protected IThreadManager ThreadManager;
		protected IFileManager FileManager;
		protected ILogger Logger;

#pragma warning disable 618
		[TestFixtureSetUp]
#pragma warning restore 618
		public void TestFixtureSetUp()
		{
			ButtonManager = MockRepository.GenerateStub<IButtonManager>();
			CollisionManager = MockRepository.GenerateStub<ICollisionManager>();
			ConfigManager = MockRepository.GenerateStub<IConfigManager>();
			ContentManager = MockRepository.GenerateStub<IContentManager>();
			DeviceManager = MockRepository.GenerateStub<IDeviceManager>();
			ImageManager = MockRepository.GenerateStub<IImageManager>();
			InputManager = MockRepository.GenerateStub<IInputManager>();
			QuestionManager = MockRepository.GenerateStub<IQuestionManager>();
			RandomManager = MockRepository.GenerateStub<IRandomManager>();
			ResolutionManager = MockRepository.GenerateStub<IResolutionManager>();
			ScoreManager = MockRepository.GenerateStub<IScoreManager>();
			ScreenManager = MockRepository.GenerateStub<IScreenManager>();
			SoundManager = MockRepository.GenerateStub<ISoundManager>();
			SpriteManager = MockRepository.GenerateStub<ISpriteManager>();
			StorageManager = MockRepository.GenerateStub<IStorageManager>();
			TextManager = MockRepository.GenerateStub<ITextManager>();
			ThreadManager = MockRepository.GenerateStub<IThreadManager>();
			FileManager = MockRepository.GenerateStub<IFileManager>();
			Logger = MockRepository.GenerateStub<ILogger>();
		}

		protected void SetUp()
		{
			IGameManager manager = new GameManager
			(
				ButtonManager,
				CollisionManager,
				ConfigManager,
				ContentManager,
				DeviceManager,
				ImageManager,
				InputManager,
				QuestionManager,
				RandomManager,
				ResolutionManager,
				ScoreManager,
				ScreenManager,
				SoundManager,
				SpriteManager,
				StorageManager,
				TextManager,
				ThreadManager,
				FileManager,
				Logger
			);

			MyGame.Construct(manager);
		}

#pragma warning disable 618
		[TestFixtureTearDown]
#pragma warning restore 618
		public void TestFixtureTearDown()
		{
			ButtonManager = null;
			CollisionManager = null;
			ConfigManager = null;
			ContentManager = null;
			DeviceManager = null;
			ImageManager = null;
			InputManager = null;
			QuestionManager = null;
			RandomManager = null;
			ResolutionManager = null;
			ScoreManager = null;
			ScreenManager = null;
			SoundManager = null;
			SpriteManager = null;
			StorageManager = null;
			TextManager = null;
			ThreadManager = null;
			FileManager = null;
			Logger = null;
		}

	}
}