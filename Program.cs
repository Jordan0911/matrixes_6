namespace matrixes_6
{
    internal class Program
{
    static int [] Column_sum(int[,] matrix)
    {
        int sum = 0;
        int[] result = new int [matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                sum += matrix[i, j];
            }
            result[i] = sum;
            sum = 0;
        }
        return result;
    }
    static double[] Row_average(int[,] matrix)
    {
        int sum = 0;
            double[]result=new double[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j=0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
            result[i] = sum / matrix.GetLength(1);
            sum = 0;
        }
        return result;
    }
    static int Number_in_interval(int x,int y, int[,] matrix)
    {
        int result = 0;

            for (int i = 0;i < matrix.GetLength(0); i++)
            {
                for (   int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]>x && matrix[i, j] < y)
                    {
                        result++;
                    }
                }
            }
            return result;
    }
    static int[,] Tablet_maker()
    {
        int multiplier = 1, n = 1;
        int[,] matrix = new int[11, 11];

        for (int i = matrix.GetLength(0)-1; i > 0; i--)
        {
            for (int j = matrix.GetLength(1)-1; j > 0; j--)
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
                if(i==0 || j == 0) { }
                else
                {
                    Console.Write($"[{matrix[i, j]}]" + '\t');
                }
            }

        }
    }
    static void Main(string[] args)
    {
        int x=10, y=20;
        int[,] matrix = Tablet_maker();
        Matrix_printer(matrix);
        Console.WriteLine(Number_in_interval(x,y,matrix));
    }
}
}
