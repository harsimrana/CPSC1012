namespace Week08Day01Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Week 08: Day 01: Demo01
            // 2D arrays 

            int r, c; // r and c are loop controllers
            // One D Array
            int[] studentMarks = new int[10];

            // Access any element from 1 D
            studentMarks[0] = 23; 
            
            // 2d Array               Rows,Columns
            int[,] classMarks = new int[3 , 3];

            // Access any element from 2D
            //         Ri  Ci  - Ri - row index Ci - column index
            // First row
            classMarks[0, 0] = 35;
            classMarks[0, 1] = 50;
            classMarks[0, 2] = 34;

            // Second row 
            classMarks[1, 0] = 5;
            classMarks[1, 1] = 4;
            classMarks[1, 2] = 3;

            // Third row 
            classMarks[2, 0] = 15;
            classMarks[2, 1] = 14;
            classMarks[2, 2] = 13;


            //print values using loops
            for (r = 0; r <= 2; r++)
            {
                for (c = 0; c <= 2; ++c)
                {
                    Console.Write($" {classMarks[r, c],7:0}");
                }
                Console.WriteLine("");
            }
            
        }
    }
}
