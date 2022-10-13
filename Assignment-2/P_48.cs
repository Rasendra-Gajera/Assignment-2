//Write a program in C# Sharp to find the second smallest element in an array.
//Test Data :
//Input the size of array : 5
//Input 5 elements in the array (value must be <9999) :
//element - 0 : 0
//element - 1 : 9
//element - 2 : 4
//element - 3 : 6
//element - 4 : 5
//Expected Output :
//The Second smallest element in the array is : 4 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_2
{
    class P_48
    {
	    public static void Main(string[] args)
	    {
		int i, j, temp;
		int[] arr = new int[5];
 
		Console.Write("Enter five numbers:");
		for (i = 0; i < arr.Length; i++)
		{
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}
 
		for (i = 0; i < 5; i++)
		{
			for (j = i + 1; j < 5; j++)
			{
				if (arr[i] > arr[j])
				{
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
		}
		Console.WriteLine("Second smallest element:" + arr[1]);
	}
}

        }
 