
void Task54 () {
    int [,] matrix = Matrix.GenMatrixInt(Matrix.CreateMatrixInt(3, 4), 1, 10);
    Console.WriteLine("Сформированная матрица: ");
    Matrix.PrintMatrixInt(matrix);

    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++) {
            for (int k = 0; k < matrix.GetLength(1) - j - 1; k++) {
                if (matrix[i, k] < matrix[i, k + 1]) {
                    int buf = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = buf;
                }
            }
        }
    }

    Console.WriteLine("Сортированная матрица: ");
    Matrix.PrintMatrixInt(matrix);
}

void Task56 () {
    int [,] matrix = Matrix.GenMatrixInt(Matrix.CreateMatrixInt(4, 4), 1, 10);
    Matrix.PrintMatrixInt(matrix);

    int row = 1;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) {
            sum += matrix[i,j];
        }
        if (sum < minSum || i == 0) {
            minSum = sum;
            row = i + 1;
        }
    }

    Console.WriteLine($"Строка с наименьшей суммой: {row}");
}

void Task58 () {
    int [,] matrix1 = Matrix.GenMatrixInt(Matrix.CreateMatrixInt(2, 3), 1, 10);
    Console.WriteLine("Первая матрица: ");
    Matrix.PrintMatrixInt(matrix1);
    int [,] matrix2 = Matrix.GenMatrixInt(Matrix.CreateMatrixInt(3, 1), 1, 10);
    Console.WriteLine("Вторая матрица: ");
    Matrix.PrintMatrixInt(matrix2);

    if (matrix1.GetLength(1) != matrix2.GetLength(0)) {
        Console.WriteLine("Кол-во столбцов первой матрицы не совпадает с кол-вом строк второй!");
    } else {
        int [,] matrixResult =Matrix.CreateMatrixInt(matrix1.GetLength(0), matrix2.GetLength(1));

        for (int i = 0; i < matrix1.GetLength(0); i++) {
            for (int j = 0; j < matrix2.GetLength(1); j++) {
                for (int k = 0; k < matrix1.GetLength(1); k++) {
                    matrixResult[i,j] += matrix1[i,k] * matrix2[k,j];
                }
            }
        }
        Console.WriteLine("Перемноженная матрица: ");
        Matrix.PrintMatrixInt(matrixResult);
    }
}

void Task60 () {
    int[,,] matrix3D = new int[2, 2, 2];
    int[] numbers = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
    int number;
    int cnt = 0;
    Random numberRandom = new Random();

    for (int i = 0; i < numbers.Length; i++) {
        number = numberRandom.Next(1, 9);
        while (Array.Find(numbers, element => element == number) > 0) {
            number = numberRandom.Next(1, 9);
        }
        numbers[i] = number;
    }


    for (int i = 0; i < matrix3D.GetLength(0); i++) {
        for (int j = 0; j < matrix3D.GetLength(1); j++) {
            Console.Write("|");
            for (int k = 0; k < matrix3D.GetLength(2); k++) {
                matrix3D[i,j,k] = numbers[cnt];
                cnt += 1;
                Console.Write($"{matrix3D[i,j,k], 1}({i},{j},{k})|");
            }
            Console.WriteLine();
        }
    }
}

void Task62 () {
    int [,] matrix =Matrix.CreateMatrixInt(5, 5);

    int row = 0, cow = 0, size = matrix.GetLength(0), currentCount = 1;

    while (size > 0) {
        for (int i = cow; i <= cow + size - 1; i++) 
            matrix[row, i] = currentCount++;

        for (int j = row + 1; j <= row + size - 1; j++) 
            matrix[j, cow + size - 1] = currentCount++;

        for (int i = cow + size - 2; i >= cow; i--) 
            matrix[row + size - 1, i] = currentCount++;

        for (int i = row + size - 2; i >= row + 1; i--) 
            matrix[i, cow] = currentCount++;

        row = row + 1;
        cow = cow + 1;
        size = size - 2;
    }

    string str;
    for (int i = 0; i < matrix.GetLength(0); i++) { 
        for (int j = 0; j < matrix.GetLength(1); j++) { 
            str = string.Format("{0:d" + currentCount.ToString().Length + "}",matrix[i,j]);
            Console.Write($"{str} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Выбирете задание (54, 56, 58, 60, 62): ");
int task = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Выбрано задание {task}");

switch (task) {
    case 54:
        Task54();
        break;
    case 56:
        Task56();
        break;
    case 58:
        Task58();
        break;
    case 60:
        Task60();
        break;
    case 62:
        Task62();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}

