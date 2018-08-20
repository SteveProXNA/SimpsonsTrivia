using System;
using System.IO;
using Microsoft.Xna.Framework;
using WindowsGame.Common.Library.Interfaces;

namespace WindowsGame.Common.Implementation
{
	public class RealFileProxy : IFileProxy
	{
		public Stream GetStream(String path)
		{
			return TitleContainer.OpenStream(path);
		}
	}
}