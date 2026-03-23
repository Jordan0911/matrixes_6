namespace matrixes_6
{
    internal class Program
    {
        static int[,] Tablet_maker()
        {
            int multiplier = 1,n=0;
            int[,] matrix = new int[10, 10];
            for(int i = matrix.GetLength(0); i > 0; i--)
            {
                for(int j = matrix.GetLength(1); j > 0; j--)
                {
                    matrix[i, j] = n * multiplier;
                    n++;
                }
                multiplier++;
                n = 1;
            }
            return matrix;

        }
        static void Matrix_printer(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"[{matrix[i, j]}]"+'\t');
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
