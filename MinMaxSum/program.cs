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
using System;
using System.Collections.Generic;
using System.Linq;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        // Sort the array
        arr.Sort();
        
        // Calculate minSum (sum of the first 4 elements)
        long minSum = 0;
        for (int i = 0; i < 4; i++)
        {
            minSum += arr[i];
        }
        
        // Calculate maxSum (sum of the last 4 elements)
        long maxSum = 0;
        for (int i = arr.Count - 4; i < arr.Count; i++)
        {
            maxSum += arr[i];
        }
        
        // Print the result
        Console.WriteLine($"{minSum} {maxSum}");
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
