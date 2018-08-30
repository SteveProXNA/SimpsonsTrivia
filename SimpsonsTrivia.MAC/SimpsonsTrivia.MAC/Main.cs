#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;

using MonoMac.AppKit;
using MonoMac.Foundation;
#endregion
using WindowsGame.Common;

namespace XamarinMacClassic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            NSApplication.Init();

            using (var game = new AnGame())
            {
                game.Run();
            }
        }
    }
}