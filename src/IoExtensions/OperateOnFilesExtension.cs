using System;
using System.IO;
using System.Linq;

namespace IoExtensions
{
	public static class OperateOnFilesExtension
	{
		public static void OperateOnFiles(this DirectoryInfo directory, string search, Action<FileInfo> action)
		{
			directory.EnumerateFiles(search).ToList().ForEach(action.Invoke);
		}
	}
}
