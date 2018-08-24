using System;
using Microsoft.Xna.Framework;
using WindowsGame.Common.Static;

namespace WindowsGame.Common.Interfaces
{
	public interface IInputFactory
	{
		void Initialize();
		void Update(GameTime gameTime);

		Boolean Escape();
		Boolean Advance();
		Boolean FullScreen();
		OptionType GetOptionType();
		Boolean LeftArrow();
		Boolean RghtArrow();
		Boolean VolumeIcon();
		Boolean CheatMode();
		Boolean Character();
	}
}