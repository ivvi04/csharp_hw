int ToLevel(int number, int level)
{   int buf  = 1;

    for (int i = 0; i < level; i++) { 
        buf *= number; 
    }
    return buf;
}

void Task25 () {
    Console.WriteLine("Выбрано задание 25");

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень: ");
    int level = Convert.ToInt32(Console.ReadLine());

    if (level < 1) {
        Console.WriteLine("Введенная сепень меньше 1");
    } else {
        int noumberToLevel = ToLevel(number, level);
        Console.WriteLine($"{number}^{level} = {noumberToLevel}");
    }
}

void Task27 () {
    Console.WriteLine("Выбрано задание 27");

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (number > 0) {
        sum += number % 10;
        number = number / 10;
    }

    Console.WriteLine($"Сумма чисел равна {sum}");
}

int[] GenNumberArray (int length, int max) {
    int[] array = new int[length];
    Random numberRandom = new Random();

    for (int i = 0; i < length; i++) { 
        array[i] = numberRandom.Next(1, max);
    }
    
    return array;
}

void Task29 () {
    Console.WriteLine("Выбрано задание 29");
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальный диапозон чисел: ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    int[] array = GenNumberArray(length, max);

    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) { 
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

Console.Write("Выбирете задание (25, 27, 29): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task) {
    case 25:
        Task25();
        break;
    case 27:
        Task27();
        break;
    case 29:
        Task29();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}

