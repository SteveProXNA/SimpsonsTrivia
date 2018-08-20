using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using WindowsGame.Common.Inputs.Types;
using WindowsGame.Common.Interfaces;
using WindowsGame.Common.Static;

namespace WindowsGame.Common.Inputs
{
	public class WindowsInputFactory : BaseInputFactory, IInputFactory
	{
		public WindowsInputFactory(IJoystickInput joystickInput, IKeyboardInput keyboardInput, IMouseScreenInput mouseScreenInput)
		{
			JoystickInput = joystickInput;
			KeyboardInput = keyboardInput;
			MouseScreenInput = mouseScreenInput;
		}

		public void Update(GameTime gameTime)
		{
			JoystickInput.Update(gameTime);
			KeyboardInput.Update(gameTime);
			MouseScreenInput.Update(gameTime);
		}

		public Boolean Escape()
		{
			return KeyboardInput.KeyHold(Keys.Escape) || JoyEscape();
		}

		public Boolean Advance()
		{
			if (MouseScreenInput.CurrButtonState == ButtonState.Pressed)
			{
				return true;
			}

			return KeyboardInput.KeyHold(Keys.Space);
		}

		public Boolean FullScreen()
		{
			if (!MouseScreenInput.ButtonHold())
			{
				return false;
			}

			return MyGame.Manager.CollisionManager.FullScreen(MouseScreenInput.CurrMouseX, MouseScreenInput.CurrMouseY);
		}

		public OptionType GetOptionType()
		{
			if (MouseScreenInput.ButtonHold())
			{
				return MyGame.Manager.CollisionManager.GetOptionType(MouseScreenInput.CurrMouseX, MouseScreenInput.CurrMouseY);
			}

			if (KeyboardInput.KeyHold(Keys.A) || KeyboardInput.KeyHold(Keys.D1) || KeyboardInput.KeyHold(Keys.NumPad1))
			{
				return OptionType.A;
			}
			if (KeyboardInput.KeyHold(Keys.B) || KeyboardInput.KeyHold(Keys.D2) || KeyboardInput.KeyHold(Keys.NumPad2))
			{
				return OptionType.B;
			}
			if (KeyboardInput.KeyHold(Keys.C) || KeyboardInput.KeyHold(Keys.D3) || KeyboardInput.KeyHold(Keys.NumPad3))
			{
				return OptionType.C;
			}
			if (KeyboardInput.KeyHold(Keys.D) || KeyboardInput.KeyHold(Keys.D4) || KeyboardInput.KeyHold(Keys.NumPad4))
			{
				return OptionType.D;
			}

			return OptionType.None;
		}

		public Boolean LeftArrow()
		{
			if (MouseScreenInput.ButtonHold())
			{
				return MyGame.Manager.CollisionManager.LeftArrow(MouseScreenInput.CurrMouseX, MouseScreenInput.CurrMouseY);
				
			}

			if (KeyboardInput.KeyHold(Keys.Left))
			{
				return true;
			}

			return false;
		}

		public Boolean RghtArrow()
		{
			if (MouseScreenInput.ButtonHold())
			{
				return MyGame.Manager.CollisionManager.RghtArrow(MouseScreenInput.CurrMouseX, MouseScreenInput.CurrMouseY);
			}

			if (KeyboardInput.KeyHold(Keys.Right))
			{
				return true;
			}

			return false;
		}

		public Boolean VolumeIcon()
		{
			if (!MouseScreenInput.ButtonHold())
			{
				return false;
			}

			return MyGame.Manager.CollisionManager.VolumeIcon(MouseScreenInput.CurrMouseX, MouseScreenInput.CurrMouseY);
		}

		public Boolean CheatMode()
		{
			if (!MouseScreenInput.ButtonHold())
			{
				return false;
			}

			return MyGame.Manager.CollisionManager.CheatMode(MouseScreenInput.CurrMouseX, MouseScreenInput.CurrMouseY);
		}

		public Boolean Character()
		{
			if (MouseScreenInput.ButtonHold())
			{
				return MyGame.Manager.CollisionManager.Character(MouseScreenInput.CurrMouseX, MouseScreenInput.CurrMouseY);
			}

			if (KeyboardInput.KeyHold(Keys.Right))
			{
				return true;
			}

			return false;
		}

	}
}