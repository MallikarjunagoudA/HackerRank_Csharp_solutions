using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

List<int> arr = new List<int>() { 5, 4, 4, 2, 2, 8 };
List<int> Res = new List<int>() { };

while (arr.Count>0)
{
    Console.WriteLine(arr.Count);
    Res.Add(arr.Count);
    var min = arr.Min();

    //removeing the min value from array arr, we are using the while here to iterate over the arr array and remove the min element. 
    while (arr.Contains(min))
    {
        arr.Remove(min);

    }
    for(int j =0; j < arr.Count; j++)
    {
        if (arr[j] > min)
        {
            arr[j] = arr[j] - min;
        }
    }
}


