using System;
using System.Collections.Generic;
using System.Text;

public class PrintLines
{
    public void GetLines(String randomWord)
    {
        Console.Write("\r");
        foreach (char c in randomWord)
        {
            Console.OutputEncoding = Encoding.Unicode; // This is needed to print the underscore
            Console.Write("\u005f "); // \u005f is the Unicode for an underscore
                                     
        }
    }

}