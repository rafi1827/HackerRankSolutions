using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static string timeConversion(string s)
    {
        string output;
        if(s.EndsWith("AM")){
            if(s.StartsWith("12")){
                output="00"+s.Remove(0,2);
                output = output.Remove(output.Length - 2, 2);
            }else{
                output=s.Remove(s.Length-2,2);
            }
        }
        else{
            if(s.StartsWith("12")){
                output=s.Remove(s.Length-2,2);     
        }
        else{
            int hr=int.Parse(s.Substring(0,2));
            hr+=12;
            output=hr+s.Remove(0,2);
            output = output.Remove(output.Length - 2, 2);
        }

    }
    return output;

}
}

class Solution
{
    public static void Main(string[] args)
    {

        string? s = Console.ReadLine();

        string result = Result.timeConversion(s);

        Console.WriteLine(result);

        
    }
}
