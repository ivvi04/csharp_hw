void Task10 () {
    Console.WriteLine("Выбрано задание 10");
    Console.Write("Введите трехзначное число: ");
    
    int number = Convert.ToInt32(Console.ReadLine());

    if (number.ToString().Length == 3) {
        //Console.WriteLine("Вторая цифра: " + number.ToString()[1]);
        Console.WriteLine("Вторая цифра: " + ((number / 10) % 10).ToString());
    } else {
        Console.WriteLine("Введено не трехзначное число!");
    }
}

int Get3ndDigit(int number) {
    while (number >= 1000) number /= 10;
    while (number > 10) number %= 10;
    return number;
}

void Task13 () {
    Console.WriteLine("Выбрано задание 13");
    Console.Write("Введите число: ");
    
    int number = Convert.ToInt32(Console.ReadLine());

    if (number.ToString().Length >= 3) {
        //Console.WriteLine("Третья цифра: " + number.ToString()[2]);
        Console.WriteLine("Третья цифра: " + Get3ndDigit(number).ToString());
    } else {
        Console.WriteLine("Третьей цифры нет!");
    }
}

void Task15 () {
    Console.WriteLine("Выбрано задание 15");
    Console.Write("Введите цифру от 1 до 7: ");
    
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 1 && number <= 7) {
        if (number > 5) {
            Console.WriteLine("Выходной день");
        } else {
            Console.WriteLine("Не выходной день");
        }
    } else {
        Console.WriteLine("Введена другая цифра или число!");
    }
}

Console.Write("Выбирете задание (10, 13, 15): ");
int task = Convert.ToInt32(Console.ReadLine());

switch (task) {
    case 10:
        Task10();
        break;
    case 13:
        Task13();
        break;
    case 15:
        Task15();
        break;
    default:
        Console.WriteLine("Выбрано неверный номер задания");
        break;
}

