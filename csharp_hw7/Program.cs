
void Task47 () {
    double [,] matrix = Matrix.GenMatrixDouble(Matrix.CreateMatrixDouble());
    Matrix.PrintMatrixDouble(matrix);
}

void Task50 () {
    int [,] matrix = Matrix.GenMatrixInt(Matrix.CreateMatrixInt(4, 4), 1, 10);
    Matrix.PrintMatrixInt(matrix);

    Console.Write("Введите позицию в строке: ");
    int posRow = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию в столбце: ");
    int posCol = Convert.ToInt32(Console.ReadLine());

    if (posRow < 0 || posRow > matrix.GetLength(0) || posCol < 0 || posCol > matrix.GetLength(1)) {
        Console.WriteLine("Введеной позиции нет в матрице");
    } else {
        Console.WriteLine($"В введеной позиции число {matrix[posRow - 1,posCol - 1]}");
    }
}

void Task52 () {
    int [,] matrix = Matrix.GenMatrixInt(Matrix.CreateMatrixInt(3, 4), 1, 10);
    Matrix.PrintMatrixInt(matrix);

    int sum = 0;
    double avg = 0; 

    for (int i = 0; i < matrix.GetLength(1); i++) { 
        for (int j = 0; j < matrix.GetLength(0); j++) { 
            sum += matrix[j,i];
        }
        avg = (double)sum / matrix.GetLength(0);
        avg = Math.Round(avg, 2);
        Console.WriteLine($"Среднее арифметическое в столбце {i + 1} равняется {avg}");
        sum = 0;
    }
}

Console.Write("Выбирете задание (47, 50, 52): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task) {
    case 47:
        Console.WriteLine($"Выбрано задание {task}");
        Task47();
        break;
    case 50:
        Console.WriteLine($"Выбрано задание {task}");
        Task50();
        break;
    case 52:
        Console.WriteLine($"Выбрано задание {task}");
        Task52();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}

