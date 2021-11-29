// See https://aka.ms/new-console-template for more information

using System;

// Console.WriteLine("Hello, World!");
public class StringContains {
    static void Main() {
        string str = "KGB";

        Console.WriteLine(str.Contains("G")); // True
        Console.WriteLine(str.Contains("Y")); // False
        Console.WriteLine(str.Contains(""));       // True

        Console.WriteLine(str.IndexOf(""));        // 0
    }
}