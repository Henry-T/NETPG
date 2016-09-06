using System;
using System.IO;

public class Program {
	public static void Main(String[] args)
	{
		var e = Directory.EnumerateFiles(Directory.GetCurrentDirectory(), 
			"data\\*values\\*.xml", SearchOption.AllDirectories);

		foreach (var entry in e) {
			Console.WriteLine(entry);
		}
	}
}