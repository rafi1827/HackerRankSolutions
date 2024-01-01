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


    public static void miniMaxSum(List<int> arr)
    {
        long MinSum=0,MaxSum=0;
      
        List<long> SortedArr = arr.Select(x => (long)x).ToList();
        SortedArr= (from value in SortedArr
                    orderby value ascending 
                    select value).ToList();
        for(int i=0; i<SortedArr.Count-1;i++){
            MinSum+=SortedArr[i];
        }
        for(int i=1; i<SortedArr.Count;i++){
            MaxSum+=SortedArr[i];
        }
        
        Console.Write($"{MinSum} {MaxSum}");

    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
