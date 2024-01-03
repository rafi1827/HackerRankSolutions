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


    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> result = new List<int>();
        int count = 0;
        foreach (string querie in queries)
        {
            foreach (string value in strings)
            {
                if (querie == value)
                {
                    count++;
                }
            }
            result.Add(count);
            count = 0;

        }


        return result;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int stringsCount = Convert.ToInt32(Console.ReadLine()?.Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            string? stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine()?.Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string? queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(strings, queries);

        Console.WriteLine(String.Join("\n", res));


    }
}
