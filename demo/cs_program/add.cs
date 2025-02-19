using System;
using System.Collections.Generic;
using System.Text;
public class MyProgram
{
    public static void Main(String[] args)
    {
 
        { 

            int a, b, sum;
            input(out a, b) ;
            sum = a + b;
            Console.WriteLine(sum) ;
        }
        
    }
    
    // .NET can only read single characters or entire lines from the console.
    // The following functions are designed to help input specific data types.
    // 'out' is a pass-by-reference modifier in C#.
    
    private static void input(out double result)
    {
        while (!double.TryParse(Console.ReadLine(), out result));
    }
    
    private static void input(out int result)
    {
        while (!int.TryParse(Console.ReadLine(), out result));
    }
    
    private static void input(out bool result)
    {
        while (!bool.TryParse(Console.ReadLine(), out result));
    }
    
    private static void input(out string result)
    {
        result = Console.ReadLine();
    }
}

