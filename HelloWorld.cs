using System;
using System.Runtime.InteropServices;

public class Program {
    
    [DllImport("ffi_test.so")]
    private static extern int ffi_test();
    
	public static void Main(string[] args){
		Console.WriteLine("Hello World from Core CLR!");
		
		var answer = ffi_test();
        System.Console.Out.WriteLine("The answer is of course: " + answer);
	}
}
