using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Please enter the number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i <= num; i++) 
            //    Console.WriteLine(i);
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //for (int i = 1; i < 13; i++)
            //    Console.WriteLine(i*num);
            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //for (int i = 1; i < number; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Please enter a string: ");
            //string? text = Console.ReadLine();
            //string result=string.Empty;
            //Console.WriteLine("the string reverse is: ");
            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    result +=text[i];
            //}
            //Console.WriteLine(result);
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //string result = num.ToString();
            //for (int i = result.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(result[i]);
            //}
            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers. 
            //Console.WriteLine("Please enter the start number: ");
            //int.TryParse(Console.ReadLine(), out int snum);
            //Console.WriteLine("Please enter the end number: ");
            //int.TryParse(Console.ReadLine(), out int dnum);
            //for (int i = snum; i < dnum; i++)
            //{
            //    if (i%1==0 && i%i==0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array. 
            //Console.WriteLine("please enter the number:");
            //decimal.TryParse(Console.ReadLine(), out decimal result);
            //int x=(int)result;
            //string y=Convert.ToString(x,2);
            //Console.WriteLine(y);
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n* n. 
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out int s);
            //string[,] matrix = new string[s, s];
            //for (int r = 0; r < matrix.GetLength(0); r++)
            //{
            //    Console.WriteLine($"enter the person {r+1} info: ");
            //    for (int c = 0; c < matrix.GetLength(1); c++)
            //    {
            //        matrix[r, c]=Console.ReadLine();
            //    }
            //    Console.WriteLine();
            //}
            //for (int r = 0; r < matrix.GetLength(0); r++)
            //{
            //    for (int c = 0; c < matrix.GetLength(1); c++)
            //    {

            //        Console.Write(matrix[r, c]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = { 1, 5, 7, 8 };
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //    sum += arr[i];
            //Console.WriteLine($"The sum is: {sum}");
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order. 
            //int[] arr1 = { 1, 3, 10 };
            //int[] arr2 = { 5, 2, 7 };
            //int[] arr3 = new int[6];
            //arr3 = arr1.Concat(arr2).ToArray();
            //Array.Sort(arr3);
            //foreach (int item in arr3)
            //    Console.WriteLine(item);
            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.WriteLine("enter the number of elements : ");
            //int.TryParse(Console.ReadLine(), out int elem);
            //int[] arr = new int[elem];
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++) //insert elements
            //{
            //    Console.WriteLine($"please enter number {i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //for (int i = 0; i < arr.Length; i++) //count number of element repeat
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }

            //    }
            //}
                #endregion

                #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
                //int[] numbers = { 3, 2, 7, 4, 5 };
                //int n=numbers[0];
                //for (int i = 1; i < numbers.Length; i++)
                //{
                //    if (numbers[i]<n)
                //        n=numbers[i];

                //}
                //Console.WriteLine("The minumum number is: ");
                //Console.WriteLine(n);
                //for (int i = 1; i < numbers.Length; i++)
                //{
                //    if (numbers[i] > n)
                //        n = numbers[i];

                //}
                //Console.WriteLine("The minumum number is: ");
                //Console.WriteLine(n);
                #endregion

                #region 16- Write a program in C# Sharp to find the second largest element in an array.
                //int[] num = { 2, 4,9, 1, 7 };
                //int max = num[0];
                //for (int i = 1; i < num.Length; i++)
                //{
                //    if(num[i] >=max)
                //      max= num[i];
                //}
                //int ind=Array.IndexOf(num,max);
                //int[] newArray = new int[5];
                //for (int i = 0; i < num.Length; i++)
                //{
                //    if (i == ind)
                //        continue;
                //        newArray[i] = num[i];

                //}
                //max= newArray[0];
                //for (int i = 0;i < num.Length; i++)
                //{
                //    if (newArray[i] > max)
                //        max = newArray[i];
                //}
                //Console.WriteLine("the second largest number is: ");
                //    Console.WriteLine(max);
                #endregion

                #region 18- Given a list of space separated words, reverse the order of the words.
                //Console.WriteLine("Enter the sentences: ");
                //string text=Console.ReadLine();
                //string[] arr = text.Split(" ");
                //for (int i = arr.Length - 1; i >= 0; i--)
                //{
                //    Console.Write(arr[i]);
                //    Console.Write(" "); 
                //}
                #endregion

                #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
                //Console.WriteLine("enter the number of rows in the array: ");
                //int.TryParse(Console.ReadLine(), out int raw);
                //Console.WriteLine("enter the number of columns in the array: ");
                //int.TryParse(Console.ReadLine(), out int col);
                //int[,] array1 =new int[raw,col];
                //int[,] array2 =new int[raw,col];
                //for (int i = 0; i < array1.GetLength(0); i++)
                //{
                //    Console.WriteLine($"Enter raw {i+1}");
                //    for (int j = 0; j < array1.GetLength(1); j++)
                //    {
                //        int.TryParse(Console.ReadLine(), out array1[i, j]);
                //    }
                //}
                //for (int i = 0; i < array1.GetLength(0); i++)
                //{
                //    for (int j = 0; j < array1.GetLength(1); j++)
                //    {
                //        array2[i, j] = array1[i, j];
                //    }
                //}
                //Console.WriteLine("the second array: ");
                //for (int i = 0; i < array2.GetLength(0); i++)
                //{
                //    Console.WriteLine($"raw {i + 1}");
                //    for (int j = 0; j < array2.GetLength(1); j++)
                //    {
                //        Console.Write(array1[i, j]);
                //        Console.WriteLine(" ");
                //    }
                //    Console.WriteLine();

                //}
                #endregion

                #region 20 - Write a Program to Print One Dimensional Array in Reverse Order
                //Console.WriteLine("enter the number of elements: ");
                //int.TryParse(Console.ReadLine(), out int value);
                //int[] arr=new int[value];
                //for (int i = 0; i < arr.Length; i++) //insert elements
                //{
                //    Console.WriteLine($"enter element number {i+1}: ");
                //    int.TryParse(Console.ReadLine(), out arr[i]);
                //}
                //Console.WriteLine("---------------------");
                //Console.WriteLine("after reverse elements: ");
                //for (int i = arr.Length-1; i>=0; i--) //print elements in reverse
                //{
                //    Console.WriteLine(arr[i]);
                //}
                #endregion

            }
    }
}
