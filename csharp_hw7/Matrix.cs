public static class Matrix{
    public static double[,] CreateMatrixDouble () {
        Console.Write("Введите кол-во строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите кол-во столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        double [,] matrix = new double[rows,cols];
        
        return matrix;
    }

    public static int[,] CreateMatrixInt () {
        Console.Write("Введите кол-во строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите кол-во столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int [,] matrix = CreateMatrixInt(rows,cols);
        
        return matrix;
    }

    public static int[,] CreateMatrixInt (int rows, int cols) {

        int [,] matrix = new int[rows,cols];
        
        return matrix;
    }

    public static double[,] GenMatrixDouble (double[,] matrix) {
        Console.Write("Введите мин. диапазон чисел: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите макс. диапазон чисел: ");
        int max = Convert.ToInt32(Console.ReadLine());

        Random numberRandom = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++) { 
            for (int j = 0; j < matrix.GetLength(1); j++) { 
                matrix[i,j] = Math.Round(numberRandom.NextDouble() * (min - max) + max, 2);
            }
        }
        
        return matrix;
    }

    public static int[,] GenMatrixInt (int[,] matrix) {
        Console.Write("Введите мин. диапазон чисел: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите макс. диапазон чисел: ");
        int max = Convert.ToInt32(Console.ReadLine());

        matrix = GenMatrixInt(matrix);
        
        return matrix;
    }

    public static int[,] GenMatrixInt (int[,] matrix, int min, int max) {

        Random numberRandom = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++) { 
            for (int j = 0; j < matrix.GetLength(1); j++) { 
                matrix[i,j] = numberRandom.Next(min, max);
            }
        }
        
        return matrix;
    }

    public static void PrintMatrixDouble (double[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) { 
            for (int j = 0; j < matrix.GetLength(1); j++) { 
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintMatrixInt (int[,] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++) { 
            for (int j = 0; j < matrix.GetLength(1); j++) { 
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}