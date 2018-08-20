using Foundation;
using UIKit;

namespace SimpsonsTrivia.IOS
{
	[Register("AppDelegate")]
	class Program : UIApplicationDelegate
	{
		private WindowsGame.Common.AnGame game;

		internal void RunGame()
		{
			game = new WindowsGame.Common.AnGame();
			game.Run();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main(string[] args)
		{
			UIApplication.Main(args, null, "AppDelegate");
		}

		public override void FinishedLaunching(UIApplication app)
		{
			RunGame();
		}
	}
}