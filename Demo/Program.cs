using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arrays [2D Array - Jagged Array - Marks]
            int[][] marks = new int[3][];
            marks[0] = new int[] { 85, 90, 78 }; // Marks for student 1
            marks[1] = new int[] { 88, 92 }; // Marks for student 2
            marks[2] = new int[] { 80 }; // Marks for student 3
            int[][] marks2 = [new int[3] { 10, 20, 30 }, new int[2] { 10, 20 }, new int[1] { 10 }];
            for (int i = 0; i < marks.Length; i++ )

            {
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.WriteLine(marks[i][j] + " ");
                }
                Console.WriteLine();
            }

            #endregion

            #region Array Methods
            //1- class member methods [static methods]
            //int[] numbers = new int[] { 1, 23 , 5, 6, 0,10 };
            //int[] numbers2 = new int[5];
            //Array.Sort(numbers); // Sorts the array in ascending order
            //Array.Reverse(numbers); // Reverses the order of the elements in the array
            //Array.Copy(numbers, numbers2, 3);// Copies elements within the array
            //Array.ConstrainedCopy(numbers, 1, numbers2, 1, 3); // Copies elements within the array with constraints
            //Console.WriteLine(Array.IndexOf(numbers, 10));
            //Console.WriteLine(Array.LastIndexOf(numbers, 10));

            //int[]Arr = (int[]) Array.CreateInstance(typeof(int), 5); // Creates a new array of integers with a specified size
            //int[ , ]Arr = (int[ , ]) Array.CreateInstance(typeof(int), 5,6); // Creates a new array of integers with a specified size

            //for (int i = 0; i < numbers2.Length; i++) 
            //{ 
            //    Console.WriteLine(numbers2[i]); // Prints the sorted array
            //}

            //2- object member methods [non static methods]
            //int[] numbers = new int[] { 1, 2,3,4,5 };
            //int[] numbers2 = new int[5];
            //numbers.CopyTo(numbers2, 0); // Copies elements from one array to another
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.WriteLine(numbers2[i]); // Prints the copied array
            //}
            //numbers2 = numbers; // This will not create a copy, it will just reference the same array
            //numbers.SetValue(10, 0); // Sets the value of the first element in the array to 10
            //Console.WriteLine(numbers[0]); // Prints the first element of the array
            //Console.WriteLine(numbers.GetValue(0)); // Gets the value of the first element in the array
            #endregion

            #region Boxing and Unboxing
            // Boxing: Converting a value type to an object type
            // unboxing: Converting an object type back to a value type

            //object obj = new object();
            //obj = "Mariam"; //Reference type
            //obj = 10; // Boxing from int to object
            //obj = 10.5; // Boxing from double to object
            //obj = true; // Boxing from bool to object
            //obj = new DateTime(); // Boxing from DateTime to object
            //Animal = dog

            int x = 15;
            object obj = 10;
            obj = "Mariam";
            x = (int)obj; // Unboxing from object to int


            #endregion

            #region Nullable Types && Null coalescing operator
            ////Nullable types ==> value types allow null as a valid value 
            ////Nullable ==> Allow its type or Null
            #region Examples
            //string Name = null;
            ////int num = null;
            //int[] numbers;
            //numbers = null;

            //int? num = 10;
            //num =null;

            //double ? salary = 100.5;
            //salary = null;


            #endregion

            #region Casting between nullable type and value type
            //int x = 5;
            //int? Y = 10;
            //Y=x; // Implicit conversion from int to int?

            //int? x = 10;
            //x= null; // Nullable int can be assigned null
            ////int Y =(int)x; // Unboxing from int? to int, will throw an exception if x is null
            //if (x != null)
            //{
            //    Y = (int)x; // Safe unboxing, only if x is not null
            //}
            //else
            //{
            //    Y = 0; // Default value if x is null
            //}
            //Console.WriteLine(Y); // Output: 0 if x is null, otherwise the value of x

            //if(x is not null)
            //{
            //    Y = (int)x; // Safe unboxing, only if x is not null
            //}
            //else
            //{
            //    Y = 0; // Default value if x is null
            //}

            //y = x is not null ? (int)x : 0; // Using the null-coalescing operator to provide a default value
            //Console.WriteLine(Y); // Output: 0 if x is null, otherwise the value of x

            //y = x ?? 0; // Using the null-coalescing operator to provide a default value
            //Console.WriteLine(Y); // Output: 0 if x is null, otherwise the value of x
            #endregion


            #endregion

            #region null propagration operator
            //double salary = default;
            //Console.WriteLine(salary);

            //int[] Arr;
            //Arr = default;
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //for (int i = 0;(Arr is not null) && (i < Arr.Length); i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //for (int i = 0; i < Arr?.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}



            //Employee {id, name ,Department}
            //Department { DeptId , DeptName}
            //Employee?.Department?.DetName

            //int[] Numbers = { 1, 2, 3 };
            //Numbers = null;

            //Console.WriteLine(Numbers?.Length);
            //int? Num = null;
            //Console.WriteLine(Num);

            #endregion

            #region null forgeviness operator
            //string Name = null!;
            //string email = _config["Email"]!; // Using null-forgiving operator to suppress the warning

            #endregion


            #region funcion 1
            //static void printshape(int counter =10 , string pattern = "Shape")
            //{
            //    for (int i = 0; i < counter; i++)
            //    {
            //        Console.WriteLine(pattern + " " + i);
            //    }
            //}


            #endregion

            #region function 2 swap
            //static void Swap(ref int a, ref int b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //int x = 5, y = 10;
            #endregion

            #region function [reference type parameter] [ passing by value, by reference]
            #region example1
            //// passing by value
            //       int[] number  = { 1, 2, 3, 4, 5 };
            //   int result = SumArray(number);
            //   Console.WriteLine(result);
            //       Console.WriteLine(number [0]);

            #endregion


            #endregion

            #region \ @
            //Console.WriteLine("Hello/n rld!");
            //Console.WriteLine(@"Hello\n rld!"); // Using verbatim string literal to ignore escape sequences
            //Console.WriteLine("hello \\ world!");
            //Console.WriteLine("hello \t world!");
            //string filePath ="C:\Users\Documents\file.txt"; // Using verbatim string literal for file paths
            #endregion

            #region function [value type parameter] [ passing by value, by reference]
            //passing by value
            //int a= 5, b = 10;
            //Console.WriteLine($"a before swap= {a}");
            //Console.WriteLine($"b before swap= {b}");
            //Swap(a,b); // This will not swap the values because a and b are passed by value
            //Console.WriteLine($"a after swap= {a}"); // a will still be 5
            //Console.WriteLine($"b after swap= {b}"); // b will still be 10

            #endregion

            #region Function 3 [sumArray change element]
            //static int SumArray(int[] arr)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sum += arr[i];
            //    }
            //    return sum;
            //}

            #endregion

            #region Function 4 [sumArray change element by reference]
            //static void SumArray(ref int[] arr)
            {
                //int sum = 0;
                //if (Arr is not null)
                //    {
                //    Arr[0] = 100;
                //    for (int i = 0; i < Arr.Length; i++)
                //    {
                //        sum += Arr[i];
                //    }
                //    return sum;
                }
            }


        #endregion

        #region example 2
        //    //passing by value
        //    int[] Numbers = { 1, 2, 3, 4, 5 };
        //    int result = SumArray(Numbers);
        //    Console.WriteLine(result);
        //Console.WriteLine(Numbers[0]); // This will print the original value of Numbers[0] because it is passed by value


        #endregion

        #region function 5 [MultiplySum]
        //static int MultiplySum (int x , int y ) 
        //{
        //    return x * y;
        //    return x + y;
        //}




        #endregion

        #region Function [ passing by out] [ sumMultiply]
        //int A = 10, B = 5;
        //Multiplysum(A, B, out Sum , out IMultiply);
        //Console.writeLine(Sum);
        //Console.writeLine(Multiply);

        #endregion
    }
}

