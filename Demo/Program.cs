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
        }
    }
}
