using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MonoGame.Framework;
using WindowsGame.Common;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace SimpsonsTrivia.WP8
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class GamePage : SwapChainBackgroundPanel
	{
		readonly AnGame _game;

		public GamePage(string launchArguments)
		{
			this.InitializeComponent();

			_game = XamlGame<AnGame>.Create(launchArguments, Window.Current.CoreWindow, this);
		}
	}
}
