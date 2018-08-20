using System;
using System.IO;

namespace WindowsGame.Common.Library.Interfaces
{
	public interface IFileProxy
	{
		Stream GetStream(String path);
	}
}
