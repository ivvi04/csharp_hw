int[] GenNumberArrayInt (int length, int min, int max) {
    int[] array = new int[length];
    Random numberRandom = new Random();

    for (int i = 0; i < length; i++) { 
        array[i] = numberRandom.Next(min, max);
    }
    
    return array;
}

void PrintArrayInt (int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) { 
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

void Task34 () {
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = GenNumberArrayInt(length, 100, 999);
    int count = 0;
    PrintArrayInt(array);
    for (int i = 0; i < array.Length; i++) { 
        if (array[i] % 2==0) {
            count += 1;
        }
    }
    Console.WriteLine($"Количество четных чисел {count}");
}

void Task36 () {
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный диапазон: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный диапазон: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] array = GenNumberArrayInt(length, min, max);
    int sum = 0;
    PrintArrayInt(array);
    for (int i = 1; i < array.Length; i+=2) { 
        sum += array[i];
    }
    Console.WriteLine($"Сумма равна {sum}");
}

double[] GenNumberArrayDouble (int length, int min, int max) {
    double[] array = new double[length];
    Random numberRandom = new Random();

    for (int i = 0; i < length; i++) { 
        array[i] = Math.Round(numberRandom.NextDouble() * (min - max) + max, 2);
    }
    
    return array;
}

void PrintArrayDouble (double[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) { 
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

void Task38 () {
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальный диапазон: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный диапазон: ");
    int max = Convert.ToInt32(Console.ReadLine());
    double[] array = GenNumberArrayDouble(length, min, max);
    PrintArrayDouble(array);
    double minNumber = array[0];
    double maxNumber = array[array.Length - 1];

    for (int i = 1; i < array.Length - 1; i++) { 
        if (array[i] < minNumber) {
           minNumber = array[i];
        }
        if (array[i] > maxNumber) {
           maxNumber = array[i];
        }
    }    

    Console.WriteLine($"Разница равна {Math.Round(maxNumber - minNumber, 2)}");
}

Console.Write("Выбирете задание (34, 36, 38): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task) {
    case 34:
        Console.WriteLine($"Выбрано задание {task}");
        Task34();
        break;
    case 36:
        Console.WriteLine($"Выбрано задание {task}");
        Task36();
        break;
    case 38:
        Console.WriteLine($"Выбрано задание {task}");
        Task38();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}

