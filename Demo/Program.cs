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
        }
    }
}
