void Task41 () {
    int count = 0;
    Console.Write("Введите элементы (через пробел): ");
    string? str = Console.ReadLine();
    if (str != null) {
        int[] array = Array.ConvertAll(str.Split(), int.Parse);
        for (int i = 0; i < array.Length; i++) { 
            if (array[i] > 0) {
                count += 1;
            }
        }
    }
    Console.WriteLine($"Ответ: {count}");
}

void Task43 () {
    Console.Write("Введите b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k1 * x + b1, 2);
    Console.WriteLine($"Ответ: ({x}, {y})");
}

Console.Write("Выбирете задание (41, 43): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task) {
    case 41:
        Console.WriteLine($"Выбрано задание {task}");
        Task41();
        break;
    case 43:
        Console.WriteLine($"Выбрано задание {task}");
        Task43();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}