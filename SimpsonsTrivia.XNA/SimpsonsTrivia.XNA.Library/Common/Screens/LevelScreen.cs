using Microsoft.Xna.Framework;
using System;
using WindowsGame.Common.Interfaces;
using WindowsGame.Common.Library;
using WindowsGame.Common.Static;

namespace WindowsGame.Common.Screens
{
	public class LevelScreen : BaseScreen, IScreen
	{
		private Byte questionNo;
		private Boolean cheatMode;
		private OptionType optionType;

		public override void Initialize()
		{
			LoadTextData();
		}

		public override void LoadContent()
		{
			MyGame.Manager.ImageManager.GenerateNextActor();

			// TODO implement logic from TitleScreen
			cheatMode = MyGame.Manager.ConfigManager.GlobalConfigData.CheatMode;

			questionNo = MyGame.Manager.QuestionManager.QuestionNumber;
			MyGame.Manager.QuestionManager.LoadQuestion(questionNo);
			if (MyGame.Manager.ConfigManager.GlobalConfigData.RandomAnswers)
			{
				MyGame.Manager.QuestionManager.RandomizeAnswerList(questionNo);
			}

			// Correct option is now set!
			optionType = GetOptionType();
		}

		public ScreenType Update(GameTime gameTime)
		{
			return ScreenType.Play;
		}

		public override void Draw()
		{
			// Draw all text first.
			MyGame.Manager.QuestionManager.DrawQuestion(questionNo);
			MyGame.Manager.QuestionManager.DrawQuestionNumber();
			MyGame.Manager.QuestionManager.DrawQuestionTotal();
			MyGame.Manager.TextManager.Draw(TextDataList);

			MyGame.Manager.ImageManager.DrawHeader();
			MyGame.Manager.ImageManager.DrawCurrActor();

			MyGame.Manager.SoundManager.DrawVolumeIcon();
			MyGame.Manager.DeviceManager.DrawViewButton();
			MyGame.Manager.SoundManager.DrawVolumeIcon();

			Engine.Game.Window.Title = "Level";
		}

		private static OptionType GetOptionType()
		{
			return MyGame.Manager.QuestionManager.CorrectOptionType;
		}

	}
}