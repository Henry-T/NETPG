using System;

public class Exception {
	public static void Main(string[] args) {
		Console.WriteLine("before exceptionTest()");
		exceptionTest();
		Console.WriteLine("after exceptionTest()");
	}

	private static void exceptionTest() {
		try {
			int a = 1;
			int b = 0;
			//int c = a/b;
		} catch(System.Exception ex) {
			Console.WriteLine("catch block");
		} finally {
			Console.WriteLine("finally block");
		}
		Console.WriteLine("after try-catch-finally");
	}
}