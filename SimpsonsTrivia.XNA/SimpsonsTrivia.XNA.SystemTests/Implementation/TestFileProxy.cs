﻿using System;
using System.IO;
using WindowsGame.Master.Interfaces;

namespace WindowsGame.SystemTests.Implementation
{
	public class TestFileProxy : IFileProxy
	{
		public Stream GetStream(String path)
		{
			return new FileStream(path, FileMode.Open);
		}
	}
}