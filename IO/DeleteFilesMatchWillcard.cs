using System;
using System.IO;

public static class Program  {
	public static int Main(String[] args) {
		var files =	Directory.GetFiles(args[0], "*ids.xml", SearchOption.AllDirectories);
		foreach(var f in files) {
			Console.WriteLine(f);
		}
		return 0;
	}
}