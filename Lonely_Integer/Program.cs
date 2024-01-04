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

    /*
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> a)
    {

        int result = 0;

        List<int> b = a;
        for (int i = 0; i < a.Count; i++)
        {
            List<int> x = b.FindAll(b => b == a[i]);
            if (x.Count == 1)
            {
                result = a[i];
                break;
            }
            else
                x.Clear();
        }

        return result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {


        int n = Convert.ToInt32(Console.ReadLine()?.Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result);


    }
}
