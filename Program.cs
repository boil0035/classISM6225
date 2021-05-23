using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//comment
//comment2 
namespace Group4_Assignment1
{
	class Program
	{
		/*---------------------------------------------------------------------------------
		| Question #1 C# program to find the initial and final index of a given target point's value
		----------------------------------------------------------------------------------- */
		public static void TargetRange(int[] marks, int target)
		{

			int n = marks.Length;
			int start = -1;
			int end = -1;

			Console.Write("Input the number of elements to be stored in the array :");
			n = Convert.ToInt32(Console.ReadLine());
			Console.Write("Please Enter {0} elements in the array :\n", n);
			// Display Elements entered
			for (int i = 0; i < n; i++)
			{
				Console.Write("Element - {0} : ", i + 1);
				marks[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.Write("Please enter the Target:");
			target = Convert.ToInt32(Console.ReadLine());
			Console.Write("Target value : {0} :\n", target);

			// Loop from beginning to find first occurrence
			for (int i = 0; i < n; i++)
			{
				if (marks[i] != target)
					continue;
				if (start == -1)
					start = i;
				end = i;
			}

			if (start != -1)
			{
				Console.WriteLine(String.Format("Element {0} is found at position [{1},{2}] \n", target, start, end));
			}
			else
			{
				Console.Write(String.Format("Target {0} Not Found - [-1,-1] \n", target));
			}

		}
		/*---------------------------------------------------------------------------------
		| Question 2: Reverse String 
		----------------------------------------------------------------------------------- */

		static void StringReverse(string strInput1, string strInput2, string strInput3, string strInput4)

		{
			// Reverse using for loop 

			//Convert input string to char array and loop through 
			char[] stringArray1 = strInput1.ToCharArray();
			char[] stringArray2 = strInput2.ToCharArray();
			char[] stringArray3 = strInput3.ToCharArray();
			char[] stringArray4 = strInput4.ToCharArray();
			string reverse = String.Empty;
			string reverse2 = String.Empty;
			string reverse3 = String.Empty;
			string reverse4 = String.Empty;

			for (int i = stringArray1.Length - 1; i >= 0; i--)

			{
				reverse += stringArray1[i];
			}

			for (int i = stringArray2.Length - 1; i >= 0; i--)
			{
				reverse2 += stringArray2[i];
			}

			for (int i = stringArray3.Length - 1; i >= 0; i--)
			{
				reverse3 += stringArray3[i];
			}

			for (int i = stringArray4.Length - 1; i >= 0; i--)

			{
				reverse4 += stringArray4[i];
			}
			Console.WriteLine(String.Format("Output: {0} {1} {2} {3} ", reverse, reverse2, reverse3, reverse4));

		}

		/*---------------------------------------------------------------------------------
		| Question 3 : Minimum Sum of sorted Array values
		----------------------------------------------------------------------------------- */
		static int minimuSum(int[] arr, int n)
		{
			Console.Write("\n\n Find Minmum Sum of elements of array:\n");
			Console.Write("--------------------------------------\n");
			Console.Write("Input the number of elements to be stored in the array :");
			n = Convert.ToInt32(Console.ReadLine());
			Console.Write("Please Enter {0} elements in the array :\n", n);
			// Display Elements entered
			for (int i = 0; i < n; i++)
			{
				Console.Write("Element - {0} : ", i + 1);
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}
			int sum = arr[0];

			for (int i = 1; i < n; i++)
			{
				if (arr[i] == arr[i - 1])
				{
					// While current element is same as previous or has become smaller than previous.
					int j = i;
					while (j < n && arr[j] <= arr[j - 1])
					{
						arr[j] = arr[j] + 1;
						j++;
					}
				}
				sum = sum + arr[i];
			}
			return sum;
		}
		/*---------------------------------------------------------------------------------
		| Q4:Sort the given string in decreasing order of frequency of occurrence of each character.
		----------------------------------------------------------------------------------- */

		public static string FrequencySort(string s)
		{
			Dictionary<char, int> map = new Dictionary<char, int>();
			foreach (char c in s)
			{
				if (map.ContainsKey(c))
				{
					int value = map[c];
					map[c] = ++value;
				}
				else
					map[c] = 1;
			}
			var sortedMap = map.OrderByDescending(c => c.Value);
			StringBuilder sb = new StringBuilder();
			foreach (KeyValuePair<char, int> pair in sortedMap)
			{
				int n = pair.Value;
				while (n-- > 0)
					sb.Append(pair.Key);
			}
			return sb.ToString();
		}



		/*---------------------------------------------------------------------------------
		| Q5: function to compute intersection of two arrays
		----------------------------------------------------------------------------------- */
		static void intersect1(int[] arr1, int[] arr2, int m, int p)
		{
			int i = 0, j = 0;
			// Sorting the first Array
			Array.Sort(arr1);
			foreach (int x in arr1) Console.Write(x + " ");
			Console.Write(" \n");

			// Sorting the Second Array Arr2
			Array.Sort(arr2);
			foreach (int x in arr2) Console.Write(x + " ");
			Console.Write(" \n");
			// Data Processing
			Console.WriteLine("Intercept Output:");
			while (i < m && j < p)
			{
				if (arr1[i] < arr2[j])
				{
					i++;
				}
				else if (arr2[j] < arr1[i])
				{
					j++;
				}
				else
				{

					Console.Write(arr2[j++] + " ");
					i++;
				}
			}
		}
		/*---------------------------------------------------------------------------------
		| Q5: Solution #2
		----------------------------------------------------------------------------------- */

		public static void intersectDict(List<int> dataSource1, List<int> dataSource2)
		{

			dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
			dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
			//Method Syntax
			var MS = dataSource1.Intersect(dataSource2).ToList();
			//Query Syntax
			var QS = (from num in dataSource1
					  select num)
			.Intersect(dataSource2).ToList();
			foreach (var item in MS)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
		/*---------------------------------------------------------------------------------
		| Q6: function to compute intersection of two arrays
		----------------------------------------------------------------------------------- */
		static void containsDuplicate(char[] arr2, int k)
		{
			int start = 0;
			int end = 0;
			k = 3;

			char dup = 'c';
			//Searches for duplicate element  
			//Console.WriteLine("Duplicate elements in given array: ");
			for (int i = 0; i < arr2.Length; i++)
			{
				for (int j = i + 1; j < arr2.Length; j++)
				{
					if (arr2[i] == arr2[j])
						//Console.WriteLine(arr2[j]);
						dup = arr2[j];
					// start modification
					if (start == -1)
						start = i;
					end = j;
					// end modification
				}

			}
			//Finding Position of the duplicate element
			if (start != -1)
			{
				Console.WriteLine(String.Format("Element {0} is found at position [{1},{2}] \n", dup, start, end));
				if (end - start == k)
				{
					Console.WriteLine("True \n");
				}
				else
				{
					Console.Write("False \n");
				}

			}
		}

		static void Main(string[] args)
		{
			bool forever = true;
			do
			{
				Console.WriteLine("|======================Menu====================|\n");
				Console.WriteLine("1. Find the initial and final index of a given target");
				Console.WriteLine("2. Functions to split and reverse a string");
				Console.WriteLine("3. Complete the method to print the minimum possible sum as output");
				Console.WriteLine("4. Sort the given string in decreasing order of frequency .");
				Console.WriteLine("5. Sort and compute intersection of two arrays");
				Console.WriteLine("6. Absolute difference between i and j");
				Console.WriteLine("9. Quit");
				Console.WriteLine("\n");
				Console.WriteLine("Please make a choice and  Press enter");

				int choice = Convert.ToInt32(Console.ReadLine());
				switch (choice)
				{
					case 1:
						Console.WriteLine("|------Q1 Find Position of target's value------|\n");
						int[] marks = { 5, 6, 6, 9, 9, 12 };
						int target = 9;
						TargetRange(marks, target);
						break;
					case 2:
						Console.WriteLine("|----------------Q2: String reverse-------------|\n");
						StringReverse("University", "of", "South", "Florida");
						break;
					case 3:
						Console.WriteLine("|----------------Q3: Minimum Sum------------|\n");
						int[] arr = { 2, 2, 3, 5, 6 };
						int n = arr.Length;
						Console.WriteLine("Output :" + minimuSum(arr, n));
						break;
					case 4:
						Console.WriteLine("|----------------Q4: Frequency Sort---------|\n");
						Console.WriteLine("Please enter a word.");
						string s = Console.ReadLine();
						Console.WriteLine("Reversed Output: " + FrequencySort(s));
						break;
					case 5:
						Console.WriteLine("|----------------Q5: Intersection -------------|\n");
						int[] arr1 = { 7, 2, 4, 5, 6 };
						int[] arr2 = { 5, 3, 2, 7 };
						int m = arr1.Length;
						int p = arr2.Length;
						intersect1(arr1, arr2, m, p);
						Console.WriteLine("\n");
						List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
						List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
						Console.WriteLine("Output Q5 Solution#2 \n");
						intersectDict(dataSource1, dataSource2);
						break;
					case 6:
						char[] arr5 = { 'a', 'g', 'h', 'a' };
						int k = arr5.Length;
						containsDuplicate(arr5, k);
						break;
					case 9:
						Console.WriteLine("You've decided to quit.");
						forever = false;
						break;

				}
			} while (forever);






		}
	}
}
