using WindowsGame.Common.Devices;
using WindowsGame.Common.Implementation;
using WindowsGame.Common.Inputs;
using WindowsGame.Common.Inputs.Types;
using WindowsGame.Common.Interfaces;
using WindowsGame.Common.Library.Interfaces;
using WindowsGame.Common.Library.IoC;
using WindowsGame.Common.Library.Managers;
using WindowsGame.Common.Managers;
using WindowsGame.Common.TheGame;

namespace WindowsGame.Common.Static
{
	public static class Registration
	{
		public static void Initialize()
		{
			IoCContainer.Initialize<IGameManager, GameManager>();

			IoCContainer.Initialize<IButtonManager, ButtonManager>();
			IoCContainer.Initialize<ICollisionManager, CollisionManager>();
			IoCContainer.Initialize<IConfigManager, ConfigManager>();
			IoCContainer.Initialize<IContentManager, ContentManager>();
			IoCContainer.Initialize<IDeviceManager, DeviceManager>();
			IoCContainer.Initialize<IImageManager, ImageManager>();
			IoCContainer.Initialize<IInputManager, InputManager>();
			IoCContainer.Initialize<IQuestionManager, QuestionManager>();
			IoCContainer.Initialize<IRandomManager, RandomManager>();
			IoCContainer.Initialize<IResolutionManager, ResolutionManager>();
			IoCContainer.Initialize<IScoreManager, ScoreManager>();
			IoCContainer.Initialize<IScreenManager, ScreenManager>();
			IoCContainer.Initialize<ISoundManager, SoundManager>();
			IoCContainer.Initialize<ISpriteManager, SpriteManager>();
			IoCContainer.Initialize<IStorageManager, StorageManager>();
			IoCContainer.Initialize<ITextManager, TextManager>();
			IoCContainer.Initialize<IThreadManager, ThreadManager>();

			IoCContainer.Initialize<IJoystickInput, JoystickInput>();
			IoCContainer.Initialize<IKeyboardInput, KeyboardInput>();
			IoCContainer.Initialize<IMouseScreenInput, MouseScreenInput>();
			IoCContainer.Initialize<ITouchScreenInput, TouchScreenInput>();

			IoCContainer.Initialize<IFileProxy, RealFileProxy>();
			IoCContainer.Initialize<IFileManager, FileManager>();

#if (WINDOWS && MOBILE)
			IoCContainer.Initialize<IDeviceFactory, MobilesDeviceFactory>();
			IoCContainer.Initialize<IInputFactory, WindowsInputFactory>();
			IoCContainer.Initialize<ILogger, Logger.Implementation.RealLogger>();
#elif WINDOWS
			IoCContainer.Initialize<IDeviceFactory, WindowsDeviceFactory>();
			IoCContainer.Initialize<IInputFactory, WindowsInputFactory>();
			IoCContainer.Initialize<ILogger, Logger.Implementation.RealLogger>();
#endif
#if !WINDOWS
			IoCContainer.Initialize<IDeviceFactory, MobilesDeviceFactory>();
			IoCContainer.Initialize<IInputFactory, MobilesInputFactory>();
			IoCContainer.Initialize<ILogger, Library.Implementation.TestLogger>();
#endif
		}
	}
}