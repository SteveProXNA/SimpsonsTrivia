﻿using WindowsGame.Common.Devices;
using WindowsGame.Common.Inputs;
using WindowsGame.Common.Inputs.Types;
using WindowsGame.Common.Interfaces;
using WindowsGame.Common.Managers;
using WindowsGame.Common.TheGame;
using WindowsGame.Master.Implementation;
using WindowsGame.Master.Interfaces;
using WindowsGame.Master.IoC;
using WindowsGame.Master.Managers;

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
			IoCContainer.Initialize<ILogger, RealLogger>();
#elif WINDOWS
			IoCContainer.Initialize<IDeviceFactory, WindowsDeviceFactory>();
			IoCContainer.Initialize<IInputFactory, WindowsInputFactory>();
			IoCContainer.Initialize<ILogger, RealLogger>();
#endif
			//#if !WINDOWS
			//			IoCContainer.Initialize<IDeviceFactory, MobilesDeviceFactory>();
			//			IoCContainer.Initialize<IInputFactory, MobilesInputFactory>();
			//			IoCContainer.Initialize<ILogger, TestLogger>();
			//#endif

#if WINDOWS_UAP
			IoCContainer.Initialize<IDeviceFactory, WindowsDeviceFactory>();
			IoCContainer.Initialize<IInputFactory, WindowsInputFactory>();
			IoCContainer.Initialize<ILogger, TestLogger>();
#endif
		}
}
}